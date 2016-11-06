namespace EnhancedPainter
{
    partial class NewPaintForm
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
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.BlackButton = new System.Windows.Forms.RadioButton();
            this.GreenButton = new System.Windows.Forms.RadioButton();
            this.BlueButton = new System.Windows.Forms.RadioButton();
            this.RedButton = new System.Windows.Forms.RadioButton();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.LargeButton = new System.Windows.Forms.RadioButton();
            this.MediumButton = new System.Windows.Forms.RadioButton();
            this.SmallButton = new System.Windows.Forms.RadioButton();
            this.EraserButton = new System.Windows.Forms.RadioButton();
            this.ColorGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.White;
            this.DrawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingPanel.Location = new System.Drawing.Point(163, 12);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(567, 379);
            this.DrawingPanel.TabIndex = 0;
            this.DrawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
            this.DrawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.DrawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.EraserButton);
            this.ColorGroupBox.Controls.Add(this.BlackButton);
            this.ColorGroupBox.Controls.Add(this.GreenButton);
            this.ColorGroupBox.Controls.Add(this.BlueButton);
            this.ColorGroupBox.Controls.Add(this.RedButton);
            this.ColorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(132, 207);
            this.ColorGroupBox.TabIndex = 1;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Color";
            // 
            // BlackButton
            // 
            this.BlackButton.AutoSize = true;
            this.BlackButton.Location = new System.Drawing.Point(11, 137);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(63, 21);
            this.BlackButton.TabIndex = 3;
            this.BlackButton.TabStop = true;
            this.BlackButton.Text = "Black";
            this.BlackButton.UseVisualStyleBackColor = true;
            this.BlackButton.CheckedChanged += new System.EventHandler(this.BlackButton_CheckedChanged);
            // 
            // GreenButton
            // 
            this.GreenButton.AutoSize = true;
            this.GreenButton.Location = new System.Drawing.Point(11, 100);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(69, 21);
            this.GreenButton.TabIndex = 2;
            this.GreenButton.TabStop = true;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.CheckedChanged += new System.EventHandler(this.GreenButton_CheckedChanged);
            // 
            // BlueButton
            // 
            this.BlueButton.AutoSize = true;
            this.BlueButton.Location = new System.Drawing.Point(11, 65);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(57, 21);
            this.BlueButton.TabIndex = 1;
            this.BlueButton.TabStop = true;
            this.BlueButton.Text = "Blue";
            this.BlueButton.UseVisualStyleBackColor = true;
            this.BlueButton.CheckedChanged += new System.EventHandler(this.BlueButton_CheckedChanged);
            // 
            // RedButton
            // 
            this.RedButton.AutoSize = true;
            this.RedButton.Location = new System.Drawing.Point(11, 28);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(55, 21);
            this.RedButton.TabIndex = 0;
            this.RedButton.TabStop = true;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.CheckedChanged += new System.EventHandler(this.RedButton_CheckedChanged);
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.LargeButton);
            this.SizeGroupBox.Controls.Add(this.MediumButton);
            this.SizeGroupBox.Controls.Add(this.SmallButton);
            this.SizeGroupBox.Location = new System.Drawing.Point(12, 240);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(132, 140);
            this.SizeGroupBox.TabIndex = 4;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Size";
            // 
            // LargeButton
            // 
            this.LargeButton.AutoSize = true;
            this.LargeButton.Location = new System.Drawing.Point(13, 108);
            this.LargeButton.Name = "LargeButton";
            this.LargeButton.Size = new System.Drawing.Size(66, 21);
            this.LargeButton.TabIndex = 2;
            this.LargeButton.TabStop = true;
            this.LargeButton.Text = "Large";
            this.LargeButton.UseVisualStyleBackColor = true;
            this.LargeButton.CheckedChanged += new System.EventHandler(this.LargeButton_CheckedChanged);
            // 
            // MediumButton
            // 
            this.MediumButton.AutoSize = true;
            this.MediumButton.Location = new System.Drawing.Point(13, 68);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(78, 21);
            this.MediumButton.TabIndex = 1;
            this.MediumButton.TabStop = true;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.CheckedChanged += new System.EventHandler(this.MediumButton_CheckedChanged);
            // 
            // SmallButton
            // 
            this.SmallButton.AutoSize = true;
            this.SmallButton.Location = new System.Drawing.Point(13, 31);
            this.SmallButton.Name = "SmallButton";
            this.SmallButton.Size = new System.Drawing.Size(63, 21);
            this.SmallButton.TabIndex = 0;
            this.SmallButton.TabStop = true;
            this.SmallButton.Text = "Small";
            this.SmallButton.UseVisualStyleBackColor = true;
            this.SmallButton.CheckedChanged += new System.EventHandler(this.SmallButton_CheckedChanged);
            // 
            // EraserButton
            // 
            this.EraserButton.AutoSize = true;
            this.EraserButton.Location = new System.Drawing.Point(11, 173);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(71, 21);
            this.EraserButton.TabIndex = 4;
            this.EraserButton.TabStop = true;
            this.EraserButton.Text = "Eraser";
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.CheckedChanged += new System.EventHandler(this.EraserButton_CheckedChanged);
            // 
            // NewPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 403);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.ColorGroupBox);
            this.Controls.Add(this.DrawingPanel);
            this.Name = "NewPaintForm";
            this.Text = "New Drawing";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.RadioButton RedButton;
        private System.Windows.Forms.RadioButton BlackButton;
        private System.Windows.Forms.RadioButton GreenButton;
        private System.Windows.Forms.RadioButton BlueButton;
        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.RadioButton LargeButton;
        private System.Windows.Forms.RadioButton MediumButton;
        private System.Windows.Forms.RadioButton SmallButton;
        private System.Windows.Forms.RadioButton EraserButton;
    }
}