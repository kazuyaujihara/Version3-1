﻿namespace Chem4Word.Editor.ChemDoodleWeb702
{
    partial class ChemDoodleWeb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChemDoodleWeb));
            this.browser = new System.Windows.Forms.WebBrowser();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBoxExplicit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveExplicitHydrogens = new System.Windows.Forms.Button();
            this.btnAddExplicitHydrogens = new System.Windows.Forms.Button();
            this.groupBoxImplicit = new System.Windows.Forms.GroupBox();
            this.chkToggleShowCarbons = new System.Windows.Forms.CheckBox();
            this.chkColouredAtoms = new System.Windows.Forms.CheckBox();
            this.chkToggleShowHydrogens = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nudBondLength = new System.Windows.Forms.NumericUpDown();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnMirror = new System.Windows.Forms.Button();
            this.SwitchToSingle = new System.Windows.Forms.RadioButton();
            this.SwitchToMulti = new System.Windows.Forms.RadioButton();
            this.groupBoxBondLength = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.groupBoxExplicit.SuspendLayout();
            this.groupBoxImplicit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBondLength)).BeginInit();
            this.groupBoxBondLength.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.AllowWebBrowserDrop = false;
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.IsWebBrowserContextMenuEnabled = false;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.MinimumSize = new System.Drawing.Size(23, 25);
            this.browser.Name = "browser";
            this.browser.ScrollBarsEnabled = false;
            this.browser.Size = new System.Drawing.Size(785, 445);
            this.browser.TabIndex = 0;
            this.browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(689, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButton_OnClick);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(690, 487);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.OkButton_OnClick);
            // 
            // groupBoxExplicit
            // 
            this.groupBoxExplicit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxExplicit.Controls.Add(this.label2);
            this.groupBoxExplicit.Controls.Add(this.label1);
            this.groupBoxExplicit.Controls.Add(this.btnRemoveExplicitHydrogens);
            this.groupBoxExplicit.Controls.Add(this.btnAddExplicitHydrogens);
            this.groupBoxExplicit.Location = new System.Drawing.Point(7, 453);
            this.groupBoxExplicit.Name = "groupBoxExplicit";
            this.groupBoxExplicit.Size = new System.Drawing.Size(133, 98);
            this.groupBoxExplicit.TabIndex = 3;
            this.groupBoxExplicit.TabStop = false;
            this.groupBoxExplicit.Text = "Explicit Hydrogens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remove";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add";
            // 
            // btnRemoveExplicitHydrogens
            // 
            this.btnRemoveExplicitHydrogens.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveExplicitHydrogens.Image = global::Chem4Word.Editor.ChemDoodleWeb702.Properties.Resources.Minus;
            this.btnRemoveExplicitHydrogens.Location = new System.Drawing.Point(16, 59);
            this.btnRemoveExplicitHydrogens.Name = "btnRemoveExplicitHydrogens";
            this.btnRemoveExplicitHydrogens.Size = new System.Drawing.Size(30, 32);
            this.btnRemoveExplicitHydrogens.TabIndex = 1;
            this.btnRemoveExplicitHydrogens.Text = "-";
            this.toolTip1.SetToolTip(this.btnRemoveExplicitHydrogens, "Convert explicit Hydrogens to implicit");
            this.btnRemoveExplicitHydrogens.UseVisualStyleBackColor = true;
            this.btnRemoveExplicitHydrogens.Click += new System.EventHandler(this.RemoveExplicitHydrogens_OnClick);
            // 
            // btnAddExplicitHydrogens
            // 
            this.btnAddExplicitHydrogens.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExplicitHydrogens.Image = global::Chem4Word.Editor.ChemDoodleWeb702.Properties.Resources.Plus;
            this.btnAddExplicitHydrogens.Location = new System.Drawing.Point(16, 22);
            this.btnAddExplicitHydrogens.Name = "btnAddExplicitHydrogens";
            this.btnAddExplicitHydrogens.Size = new System.Drawing.Size(30, 32);
            this.btnAddExplicitHydrogens.TabIndex = 0;
            this.btnAddExplicitHydrogens.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddExplicitHydrogens, "Convert implicit Hydrogens to explicit");
            this.btnAddExplicitHydrogens.UseVisualStyleBackColor = true;
            this.btnAddExplicitHydrogens.Click += new System.EventHandler(this.AddExplicitHydrogens_OnClick);
            // 
            // groupBoxImplicit
            // 
            this.groupBoxImplicit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxImplicit.Controls.Add(this.chkToggleShowCarbons);
            this.groupBoxImplicit.Controls.Add(this.chkColouredAtoms);
            this.groupBoxImplicit.Controls.Add(this.chkToggleShowHydrogens);
            this.groupBoxImplicit.Location = new System.Drawing.Point(146, 453);
            this.groupBoxImplicit.Name = "groupBoxImplicit";
            this.groupBoxImplicit.Size = new System.Drawing.Size(147, 98);
            this.groupBoxImplicit.TabIndex = 4;
            this.groupBoxImplicit.TabStop = false;
            this.groupBoxImplicit.Text = "Rendering Options";
            // 
            // chkToggleShowCarbons
            // 
            this.chkToggleShowCarbons.AutoSize = true;
            this.chkToggleShowCarbons.Location = new System.Drawing.Point(14, 66);
            this.chkToggleShowCarbons.Name = "chkToggleShowCarbons";
            this.chkToggleShowCarbons.Size = new System.Drawing.Size(128, 20);
            this.chkToggleShowCarbons.TabIndex = 2;
            this.chkToggleShowCarbons.Text = "Show All Carbons";
            this.toolTip1.SetToolTip(this.chkToggleShowCarbons, "Check to show implicit Hydrogens");
            this.chkToggleShowCarbons.UseVisualStyleBackColor = true;
            this.chkToggleShowCarbons.CheckedChanged += new System.EventHandler(this.ToggleShowCarbons_CheckedChanged);
            // 
            // chkColouredAtoms
            // 
            this.chkColouredAtoms.AutoSize = true;
            this.chkColouredAtoms.Checked = true;
            this.chkColouredAtoms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColouredAtoms.Location = new System.Drawing.Point(14, 44);
            this.chkColouredAtoms.Name = "chkColouredAtoms";
            this.chkColouredAtoms.Size = new System.Drawing.Size(118, 20);
            this.chkColouredAtoms.TabIndex = 1;
            this.chkColouredAtoms.Text = "Coloured Atoms";
            this.toolTip1.SetToolTip(this.chkColouredAtoms, "Check to show implicit Hydrogens");
            this.chkColouredAtoms.UseVisualStyleBackColor = true;
            this.chkColouredAtoms.CheckedChanged += new System.EventHandler(this.ColouredAtoms_CheckedChanged);
            // 
            // chkToggleShowHydrogens
            // 
            this.chkToggleShowHydrogens.AutoSize = true;
            this.chkToggleShowHydrogens.Checked = true;
            this.chkToggleShowHydrogens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkToggleShowHydrogens.Location = new System.Drawing.Point(14, 22);
            this.chkToggleShowHydrogens.Name = "chkToggleShowHydrogens";
            this.chkToggleShowHydrogens.Size = new System.Drawing.Size(116, 20);
            this.chkToggleShowHydrogens.TabIndex = 0;
            this.chkToggleShowHydrogens.Text = "Show Implicit H";
            this.toolTip1.SetToolTip(this.chkToggleShowHydrogens, "Check to show implicit Hydrogens");
            this.chkToggleShowHydrogens.UseVisualStyleBackColor = true;
            this.chkToggleShowHydrogens.CheckedChanged += new System.EventHandler(this.ToggleShowHydrogens_CheckedChanged);
            // 
            // nudBondLength
            // 
            this.nudBondLength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBondLength.Location = new System.Drawing.Point(16, 25);
            this.nudBondLength.Maximum = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.nudBondLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBondLength.Name = "nudBondLength";
            this.nudBondLength.Size = new System.Drawing.Size(51, 23);
            this.nudBondLength.TabIndex = 15;
            this.toolTip1.SetToolTip(this.nudBondLength, "Change size of drawing (in Word)");
            this.nudBondLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBondLength.ValueChanged += new System.EventHandler(this.BondLength_ValueChanged);
            // 
            // btnFlip
            // 
            this.btnFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFlip.Image = global::Chem4Word.Editor.ChemDoodleWeb702.Properties.Resources.Flip;
            this.btnFlip.Location = new System.Drawing.Point(498, 502);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(48, 48);
            this.btnFlip.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnFlip, "Flip drawing");
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.FlipButton_OnClick);
            // 
            // btnMirror
            // 
            this.btnMirror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMirror.Image = global::Chem4Word.Editor.ChemDoodleWeb702.Properties.Resources.Mirror;
            this.btnMirror.Location = new System.Drawing.Point(552, 502);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(48, 48);
            this.btnMirror.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnMirror, "Mirror drawing");
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.MirrorButton_OnClick);
            // 
            // SwitchToSingle
            // 
            this.SwitchToSingle.AutoSize = true;
            this.SwitchToSingle.Checked = true;
            this.SwitchToSingle.Location = new System.Drawing.Point(7, 21);
            this.SwitchToSingle.Name = "SwitchToSingle";
            this.SwitchToSingle.Size = new System.Drawing.Size(61, 20);
            this.SwitchToSingle.TabIndex = 21;
            this.SwitchToSingle.TabStop = true;
            this.SwitchToSingle.Text = "Single";
            this.toolTip1.SetToolTip(this.SwitchToSingle, "Switch to single molecule mode");
            this.SwitchToSingle.UseVisualStyleBackColor = true;
            this.SwitchToSingle.CheckedChanged += new System.EventHandler(this.SwitchToSingle_CheckedChanged);
            // 
            // SwitchToMulti
            // 
            this.SwitchToMulti.AutoSize = true;
            this.SwitchToMulti.Location = new System.Drawing.Point(7, 47);
            this.SwitchToMulti.Name = "SwitchToMulti";
            this.SwitchToMulti.Size = new System.Drawing.Size(53, 20);
            this.SwitchToMulti.TabIndex = 22;
            this.SwitchToMulti.Text = "Multi";
            this.toolTip1.SetToolTip(this.SwitchToMulti, "Switch to multiple molecule mode");
            this.SwitchToMulti.UseVisualStyleBackColor = true;
            this.SwitchToMulti.CheckedChanged += new System.EventHandler(this.SwitchToMulti_CheckedChanged);
            // 
            // groupBoxBondLength
            // 
            this.groupBoxBondLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxBondLength.Controls.Add(this.nudBondLength);
            this.groupBoxBondLength.Location = new System.Drawing.Point(304, 454);
            this.groupBoxBondLength.Name = "groupBoxBondLength";
            this.groupBoxBondLength.Size = new System.Drawing.Size(104, 97);
            this.groupBoxBondLength.TabIndex = 17;
            this.groupBoxBondLength.TabStop = false;
            this.groupBoxBondLength.Text = "Bond Length";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-100, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 20);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxMode.Controls.Add(this.SwitchToMulti);
            this.groupBoxMode.Controls.Add(this.SwitchToSingle);
            this.groupBoxMode.Location = new System.Drawing.Point(414, 453);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(78, 98);
            this.groupBoxMode.TabIndex = 21;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // ChemDoodleWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnMirror);
            this.Controls.Add(this.btnFlip);
            this.Controls.Add(this.groupBoxBondLength);
            this.Controls.Add(this.groupBoxExplicit);
            this.Controls.Add(this.groupBoxImplicit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.browser);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(716, 580);
            this.Name = "ChemDoodleWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChemDoodle Structure Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChemDoodleEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormChemDoodleEditor_Load);
            this.groupBoxExplicit.ResumeLayout(false);
            this.groupBoxExplicit.PerformLayout();
            this.groupBoxImplicit.ResumeLayout(false);
            this.groupBoxImplicit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBondLength)).EndInit();
            this.groupBoxBondLength.ResumeLayout(false);
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBoxExplicit;
        private System.Windows.Forms.Button btnRemoveExplicitHydrogens;
        private System.Windows.Forms.Button btnAddExplicitHydrogens;
        private System.Windows.Forms.GroupBox groupBoxImplicit;
        private System.Windows.Forms.CheckBox chkToggleShowHydrogens;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown nudBondLength;
        private System.Windows.Forms.GroupBox groupBoxBondLength;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkColouredAtoms;
        private System.Windows.Forms.CheckBox chkToggleShowCarbons;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton SwitchToMulti;
        private System.Windows.Forms.RadioButton SwitchToSingle;
    }
}