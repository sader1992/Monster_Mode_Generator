﻿namespace Monster_Mode_Generator
{
    partial class MMG_START
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMG_START));
            this.VERSION_START = new System.Windows.Forms.ComboBox();
            this.START = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VERSION_START
            // 
            this.VERSION_START.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VERSION_START.FormattingEnabled = true;
            this.VERSION_START.Items.AddRange(new object[] {
            "rAthena 2016-04-02 (Current Version)",
            "Hercules 2012-06-30 (Current Version)",
            "rAthena 2012-06-30"});
            this.VERSION_START.Location = new System.Drawing.Point(29, 63);
            this.VERSION_START.Name = "VERSION_START";
            this.VERSION_START.Size = new System.Drawing.Size(246, 24);
            this.VERSION_START.TabIndex = 0;
            // 
            // START
            // 
            this.START.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.Location = new System.Drawing.Point(296, 26);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(118, 61);
            this.START.TabIndex = 1;
            this.START.Text = "Start";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose your Emulator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MMG_START
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 114);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.START);
            this.Controls.Add(this.VERSION_START);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MMG_START";
            this.Text = "Monster Mode Generator v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MMG_START_FormClosing);
            this.Load += new System.EventHandler(this.MMG_START_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button START;
        public System.Windows.Forms.ComboBox VERSION_START;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}