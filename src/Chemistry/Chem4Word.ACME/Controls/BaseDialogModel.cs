﻿// ---------------------------------------------------------------------------
//  Copyright (c) 2019, The .NET Foundation.
//  This software is released under the Apache License, Version 2.0.
//  The license and further copyright text can be found in the file LICENSE.md
//  at the root directory of the distribution.
// ---------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;

namespace Chem4Word.ACME.Controls
{
    public class BaseDialogModel
    {
        public Point Centre { get; set; }
        public string Title { get; set; }
        public bool Save { get; set; }
        public Control Content { get; set; }
        public double WindowMinimumWidth { get; set; }
        public double WindowMinimumHeight { get; set; }
    }
}