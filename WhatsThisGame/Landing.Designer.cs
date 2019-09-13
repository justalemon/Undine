﻿namespace WhatsThisGame
{
    partial class Landing
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
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.BasicGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IdentifierLabel = new System.Windows.Forms.Label();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.FileGroupBox.SuspendLayout();
            this.BasicGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileGroupBox.Controls.Add(this.FileButton);
            this.FileGroupBox.Controls.Add(this.FileTextBox);
            this.FileGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(343, 51);
            this.FileGroupBox.TabIndex = 0;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "File";
            // 
            // FileTextBox
            // 
            this.FileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileTextBox.Location = new System.Drawing.Point(6, 19);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.ReadOnly = true;
            this.FileTextBox.Size = new System.Drawing.Size(250, 20);
            this.FileTextBox.TabIndex = 0;
            // 
            // FileButton
            // 
            this.FileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileButton.Location = new System.Drawing.Point(262, 18);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 1;
            this.FileButton.Text = "Open";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // BasicGroupBox
            // 
            this.BasicGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BasicGroupBox.Controls.Add(this.ConsoleLabel);
            this.BasicGroupBox.Controls.Add(this.IdentifierLabel);
            this.BasicGroupBox.Controls.Add(this.NameLabel);
            this.BasicGroupBox.Location = new System.Drawing.Point(12, 69);
            this.BasicGroupBox.Name = "BasicGroupBox";
            this.BasicGroupBox.Size = new System.Drawing.Size(343, 100);
            this.BasicGroupBox.TabIndex = 1;
            this.BasicGroupBox.TabStop = false;
            this.BasicGroupBox.Text = "Basic Information";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(60, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name/Title";
            // 
            // IdentifierLabel
            // 
            this.IdentifierLabel.AutoSize = true;
            this.IdentifierLabel.Location = new System.Drawing.Point(6, 48);
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Size = new System.Drawing.Size(47, 13);
            this.IdentifierLabel.TabIndex = 4;
            this.IdentifierLabel.Text = "Identifier";
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Location = new System.Drawing.Point(6, 74);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(45, 13);
            this.ConsoleLabel.TabIndex = 5;
            this.ConsoleLabel.Text = "Console";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 387);
            this.Controls.Add(this.BasicGroupBox);
            this.Controls.Add(this.FileGroupBox);
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsThisGame";
            this.FileGroupBox.ResumeLayout(false);
            this.FileGroupBox.PerformLayout();
            this.BasicGroupBox.ResumeLayout(false);
            this.BasicGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.GroupBox BasicGroupBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.Label IdentifierLabel;
    }
}

