﻿namespace WinFormsTestHarness
{
    partial class FlexForm
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
            this.LoadStructure = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EditStructure = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.display1 = new Chem4Word.ACME.Display();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ChangeBackground = new System.Windows.Forms.Button();
            this.ShowCarbons = new System.Windows.Forms.CheckBox();
            this.RemoveAtom = new System.Windows.Forms.Button();
            this.RandomElement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadStructure
            // 
            this.LoadStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadStructure.Location = new System.Drawing.Point(12, 520);
            this.LoadStructure.Name = "LoadStructure";
            this.LoadStructure.Size = new System.Drawing.Size(75, 23);
            this.LoadStructure.TabIndex = 0;
            this.LoadStructure.Text = "Load";
            this.LoadStructure.UseVisualStyleBackColor = true;
            this.LoadStructure.Click += new System.EventHandler(this.LoadStructure_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditStructure
            // 
            this.EditStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditStructure.Enabled = false;
            this.EditStructure.Location = new System.Drawing.Point(539, 520);
            this.EditStructure.Name = "EditStructure";
            this.EditStructure.Size = new System.Drawing.Size(75, 23);
            this.EditStructure.TabIndex = 2;
            this.EditStructure.Text = "Edit";
            this.EditStructure.UseVisualStyleBackColor = true;
            this.EditStructure.Click += new System.EventHandler(this.EditStructure_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.elementHost1.Location = new System.Drawing.Point(12, 12);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(602, 502);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.display1;
            // 
            // ChangeBackground
            // 
            this.ChangeBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeBackground.Location = new System.Drawing.Point(93, 520);
            this.ChangeBackground.Name = "ChangeBackground";
            this.ChangeBackground.Size = new System.Drawing.Size(75, 23);
            this.ChangeBackground.TabIndex = 3;
            this.ChangeBackground.Text = "Background";
            this.ChangeBackground.UseVisualStyleBackColor = true;
            this.ChangeBackground.Click += new System.EventHandler(this.ChangeBackground_Click);
            // 
            // ShowCarbons
            // 
            this.ShowCarbons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowCarbons.AutoSize = true;
            this.ShowCarbons.Enabled = false;
            this.ShowCarbons.Location = new System.Drawing.Point(174, 524);
            this.ShowCarbons.Name = "ShowCarbons";
            this.ShowCarbons.Size = new System.Drawing.Size(95, 17);
            this.ShowCarbons.TabIndex = 4;
            this.ShowCarbons.Text = "Show Carbons";
            this.ShowCarbons.UseVisualStyleBackColor = true;
            this.ShowCarbons.CheckedChanged += new System.EventHandler(this.ShowCarbons_CheckedChanged);
            // 
            // RemoveAtom
            // 
            this.RemoveAtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAtom.Enabled = false;
            this.RemoveAtom.Location = new System.Drawing.Point(436, 520);
            this.RemoveAtom.Name = "RemoveAtom";
            this.RemoveAtom.Size = new System.Drawing.Size(97, 23);
            this.RemoveAtom.TabIndex = 5;
            this.RemoveAtom.Text = "Remove Atom";
            this.RemoveAtom.UseVisualStyleBackColor = true;
            this.RemoveAtom.Click += new System.EventHandler(this.RemoveAtom_Click);
            // 
            // RandomElement
            // 
            this.RandomElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomElement.Enabled = false;
            this.RandomElement.Location = new System.Drawing.Point(333, 520);
            this.RandomElement.Name = "RandomElement";
            this.RandomElement.Size = new System.Drawing.Size(97, 23);
            this.RandomElement.TabIndex = 6;
            this.RandomElement.Text = "Random Element";
            this.RandomElement.UseVisualStyleBackColor = true;
            this.RandomElement.Click += new System.EventHandler(this.RandomElement_Click);
            // 
            // FlexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 555);
            this.Controls.Add(this.RandomElement);
            this.Controls.Add(this.RemoveAtom);
            this.Controls.Add(this.ShowCarbons);
            this.Controls.Add(this.ChangeBackground);
            this.Controls.Add(this.EditStructure);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.LoadStructure);
            this.Name = "FlexForm";
            this.Text = "Flexible Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadStructure;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Button EditStructure;
        private Chem4Word.ACME.Display display1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ChangeBackground;
        private System.Windows.Forms.CheckBox ShowCarbons;
        private System.Windows.Forms.Button RemoveAtom;
        private System.Windows.Forms.Button RandomElement;
    }
}

