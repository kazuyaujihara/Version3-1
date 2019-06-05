﻿// ---------------------------------------------------------------------------
//  Copyright (c) 2019, The .NET Foundation.
//  This software is released under the Apache License, Version 2.0.
//  The license and further copyright text can be found in the file LICENSE.md
//  at the root directory of the distribution.
// ---------------------------------------------------------------------------

using System;
using Chem4Word.ACME.Controls;
using Chem4Word.Model2.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Chem4Word.ACME.Behaviors
{
    public abstract class BaseEditBehavior : Behavior<Canvas>, INotifyPropertyChanged
    {
        public EditViewModel EditViewModel
        {
            get { return (EditViewModel)GetValue(EditViewModelProperty); }
            set { SetValue(EditViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EditViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EditViewModelProperty =
            DependencyProperty.Register("EditViewModel", typeof(EditViewModel), typeof(BaseEditBehavior), new PropertyMetadata(null));

        private string _currentStatus;


        private EditorCanvas _currentEditor;

        public EditorCanvas CurrentEditor
        {
            get { return _currentEditor; }
            set
            {
                if (_currentEditor!=null)
                {
                    _currentEditor.PreviewKeyDown-= CurrentEditor_PreviewKeyDown;
                }
                _currentEditor = value;
                if (_currentEditor != null)
                {
                    _currentEditor.PreviewKeyDown += CurrentEditor_PreviewKeyDown;
                    _currentEditor.Focusable = true;
                    _currentEditor.Focus();
                }
            }
            
        }

        private void CurrentEditor_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Abort();
            }
        }

      
        public virtual string CurrentStatus
        {
            get
            {
                return _currentStatus;
            }
            protected set
            {
                _currentStatus = value;
                OnPropertyChanged();
            }
        }

        public abstract void Abort();
       

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            if (_currentEditor != null)
            {
                _currentEditor.PreviewKeyDown -= CurrentEditor_PreviewKeyDown;
            }
        }

    }
}