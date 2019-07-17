﻿// ---------------------------------------------------------------------------
//  Copyright (c) 2019, The .NET Foundation.
//  This software is released under the Apache License, Version 2.0.
//  The license and further copyright text can be found in the file LICENSE.md
//  at the root directory of the distribution.
// ---------------------------------------------------------------------------

using System.Collections;
using Chem4Word.ACME.Drawing;
using Chem4Word.Model2;
using Chem4Word.Model2.Annotations;
using Chem4Word.Model2.Helpers;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using Chem4Word.ACME.Controls;

namespace Chem4Word.ACME.Adorners
{
    public class DrawBondAdorner : Adorner
    {
        //private StreamGeometry _outline;
        private SolidColorBrush _solidColorBrush;

        private Pen _dashPen;

        private EditorCanvas CurrentEditor { get; }
        public Globals.BondStereo Stereo { get; set; }

        public string BondOrder { get; set; }

        public Point StartPoint
        {
            get { return (Point) GetValue(StartPointProperty); }
            set { SetValue(StartPointProperty, value); }
        }

        // Using a DependencyProperty as the backing store for StartPoint.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StartPointProperty =
            DependencyProperty.Register("StartPoint", typeof(Point), typeof(DrawBondAdorner),
                                        new FrameworkPropertyMetadata(new Point(0d, 0d),
                                                                      FrameworkPropertyMetadataOptions.AffectsRender));

        public Point EndPoint
        {
            get { return (Point) GetValue(EndPointProperty); }
            set { SetValue(EndPointProperty, value); }
        }

        public Bond ExistingBond { get; set; }

        // Using a DependencyProperty as the backing store for EndPoint.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EndPointProperty =
            DependencyProperty.Register("EndPoint", typeof(Point), typeof(DrawBondAdorner),
                                        new FrameworkPropertyMetadata(new Point(0d, 0d),
                                                                      FrameworkPropertyMetadataOptions.AffectsRender));

        public DrawBondAdorner([NotNull] UIElement adornedElement, double bondThickness) : base(adornedElement)
        {
            _solidColorBrush = new SolidColorBrush(SystemColors.HighlightColor);
            _solidColorBrush.Opacity = 0.5;
            _dashPen = new Pen(SystemColors.HighlightBrush, bondThickness);

            CurrentEditor = (EditorCanvas) adornedElement;

            PreviewKeyDown += DrawBondAdorner_PreviewKeyDown;

            var myAdornerLayer = AdornerLayer.GetAdornerLayer(adornedElement);
            myAdornerLayer.Add(this);

            Focusable = true;
            Focus();
        }

        private void DrawBondAdorner_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            CurrentEditor.RaiseEvent(e);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Brush brush = _solidColorBrush;
            Pen pen = _dashPen;
            BondDescriptor layout;

            var length = CurrentEditor.Chemistry.Model.XamlBondLength;
            if (ExistingBond == null || !ExistingBond.IsCyclic())
            {
                layout = GetBondLayout(StartPoint, EndPoint, length, Stereo, BondOrder);
            }
            else
            {
                layout = GetBondLayout(StartPoint, EndPoint, length, Stereo, BondOrder, ExistingBond.PrimaryRing,
                                       ExistingBond.SubsidiaryRing);
            }

            if (Stereo == Globals.BondStereo.Hatch)
            {
                brush = new LinearGradientBrush
                        {
                            MappingMode = BrushMappingMode.Absolute,
                            SpreadMethod = GradientSpreadMethod.Repeat,
                            StartPoint = new Point(50, 0),
                            EndPoint = new Point(50, 3),
                            GradientStops = new GradientStopCollection()
                                            {
                                                new GradientStop {Offset = 0d, Color = SystemColors.HighlightColor},
                                                new GradientStop {Offset = 0.25d, Color = SystemColors.HighlightColor},
                                                new GradientStop {Offset = 0.25d, Color = Colors.Transparent},
                                                new GradientStop {Offset = 0.30, Color = Colors.Transparent}
                                            },

                            Transform = new RotateTransform
                                        {
                                            Angle = Vector.AngleBetween(Model2.Geometry.BasicGeometry.ScreenNorth,
                                                                        EndPoint - StartPoint)
                                        }
                        };
            }

            switch (BondOrder)
            {
                case Globals.OrderZero:
                case Globals.OrderOther:
                case "unknown":
               
                    pen = pen.Clone();
                    pen.DashStyle = DashStyles.Dot;
                    drawingContext.DrawGeometry(brush, pen, layout.DefiningGeometry);
                    break;
                case Globals.OrderPartial01:
                    pen = pen.Clone();
                    pen.DashStyle = DashStyles.Dash;
                    drawingContext.DrawGeometry(brush, pen, layout.DefiningGeometry);
                    break;
                case Globals.OrderAromatic:
                case Globals.OrderPartial12:
                    var secondPen = pen.Clone();
                    secondPen.DashStyle = DashStyles.Dash;
                    drawingContext.DrawLine(pen, layout.Start, layout.End);
                    var doubleBondDescriptor = (layout as DoubleBondDescriptor);
                    drawingContext.DrawLine(secondPen,
                                            doubleBondDescriptor.SecondaryStart,
                                            doubleBondDescriptor.SecondaryEnd);
                    break;

                case Globals.OrderPartial23:
                    var tbd = (layout as TripleBondDescriptor);
                    secondPen = pen.Clone();
                    secondPen.DashStyle = DashStyles.Dash;
                    drawingContext.DrawLine(pen, tbd.SecondaryStart, tbd.SecondaryEnd);
                    drawingContext.DrawLine(pen, tbd.Start, tbd.End);
                    drawingContext.DrawLine(secondPen, tbd.TertiaryStart, tbd.TertiaryEnd);
                    break;
                case Globals.OrderTriple:
                    tbd = (layout as TripleBondDescriptor);
                    drawingContext.DrawLine(pen, tbd.SecondaryStart, tbd.SecondaryEnd);
                    drawingContext.DrawLine(pen, tbd.Start, tbd.End);
                    drawingContext.DrawLine(pen, tbd.TertiaryStart, tbd.TertiaryEnd);
                    break;
                default:
                    drawingContext.DrawGeometry(brush, pen, layout.DefiningGeometry);
                    break;

            }
        }

        public static BondDescriptor GetBondLayout(Point startPoint, Point endPoint, double bondLength,
                                                   Globals.BondStereo stereo, string order, Ring existingRing = null,
                                                   Ring subsidiaryRing = null)
        {
            BondDescriptor descriptor = null;
            //check to see if it's a wedge or a hatch yet
            if (stereo == Globals.BondStereo.Wedge | stereo == Globals.BondStereo.Hatch)
            {
                var wbd = new WedgeBondDescriptor {Start = startPoint, End = endPoint};
                BondGeometry.GetWedgeBondGeometry(wbd, bondLength);
                return wbd;
            }

            if (stereo == Globals.BondStereo.Indeterminate && (order == Globals.OrderSingle))
            {
                descriptor = new BondDescriptor {Start = startPoint, End = endPoint};
                BondGeometry.GetWavyBondGeometry(descriptor, bondLength);
                return descriptor;
            }

            var ordervalue = Bond.OrderToOrderValue(order);
            //single or dotted bond
            if (ordervalue <= 1)
            {
                descriptor = new BondDescriptor {Start = startPoint, End = endPoint};
                BondGeometry.GetSingleBondGeometry(descriptor);
            }

            List<Point> dummy = new List<Point>();
            //double bond
            if (ordervalue == 2 | ordervalue == 1.5)
            {
                DoubleBondDescriptor dbd = new DoubleBondDescriptor() {Start = startPoint, End = endPoint};
                if (stereo == Globals.BondStereo.Indeterminate)
                {
                    BondGeometry.GetCrossedDoubleGeometry(dbd, bondLength);
                }
                else
                {
                    dbd.PrimaryCentroid = existingRing?.Centroid;
                    dbd.SecondaryCentroid = subsidiaryRing?.Centroid;
                    BondGeometry.GetDoubleBondGeometry(dbd, bondLength);
                }

                descriptor = dbd;
            }

            //tripe bond
            if (ordervalue == 2.5 | ordervalue == 3)
            {
                var tbd = new TripleBondDescriptor() {Start = startPoint, End = endPoint};
                BondGeometry.GetTripleBondGeometry(tbd, bondLength);
                descriptor = tbd;
            }

            return descriptor;
        }
    }
}