
namespace FirstWinForm
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.triangleButton = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.baseBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.shapePicker = new System.Windows.Forms.GroupBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.shapePicker.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Checked = true;
            this.rectangleButton.Location = new System.Drawing.Point(56, 15);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(77, 19);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.TabStop = true;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            // 
            // triangleButton
            // 
            this.triangleButton.AutoSize = true;
            this.triangleButton.Location = new System.Drawing.Point(56, 40);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(66, 19);
            this.triangleButton.TabIndex = 1;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(235, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(341, 32);
            this.title.TabIndex = 2;
            this.title.Text = "Welcome to Area Calculator!";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(49, 35);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(34, 15);
            this.baseLabel.TabIndex = 3;
            this.baseLabel.Text = "Base:";
            this.baseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(37, 61);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(46, 15);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height:";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // baseBox
            // 
            this.baseBox.Location = new System.Drawing.Point(89, 31);
            this.baseBox.Name = "baseBox";
            this.baseBox.Size = new System.Drawing.Size(100, 23);
            this.baseBox.TabIndex = 5;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(89, 57);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 23);
            this.heightBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(89, 136);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 45);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Area";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.areaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.areaLabel.Location = new System.Drawing.Point(351, 293);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(55, 25);
            this.areaLabel.TabIndex = 8;
            this.areaLabel.Text = "Area:";
            this.areaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputLabel.Location = new System.Drawing.Point(412, 293);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(45, 25);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Text = "N/A";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapePicker
            // 
            this.shapePicker.Controls.Add(this.rectangleButton);
            this.shapePicker.Controls.Add(this.triangleButton);
            this.shapePicker.Location = new System.Drawing.Point(117, 77);
            this.shapePicker.Name = "shapePicker";
            this.shapePicker.Size = new System.Drawing.Size(200, 100);
            this.shapePicker.TabIndex = 10;
            this.shapePicker.TabStop = false;
            this.shapePicker.Text = "Shape";
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.heightBox);
            this.inputPanel.Controls.Add(this.baseLabel);
            this.inputPanel.Controls.Add(this.heightLabel);
            this.inputPanel.Controls.Add(this.baseBox);
            this.inputPanel.Controls.Add(this.calculateButton);
            this.inputPanel.Location = new System.Drawing.Point(323, 55);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(253, 226);
            this.inputPanel.TabIndex = 11;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.shapePicker);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Name = "mainForm";
            this.Text = "Area Calculator";
            this.shapePicker.ResumeLayout(false);
            this.shapePicker.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton triangleButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox baseBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox shapePicker;
        private System.Windows.Forms.Panel inputPanel;
    }
}

