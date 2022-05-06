namespace BigForms
{
    partial class GeneratorForm
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
            this.back = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.isFormat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 41);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(373, 397);
            this.OutputTextBox.TabIndex = 1;
            this.OutputTextBox.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(93, 12);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(217, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Сгенерировать объект";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // isFormat
            // 
            this.isFormat.AutoSize = true;
            this.isFormat.Location = new System.Drawing.Point(316, 15);
            this.isFormat.Name = "isFormat";
            this.isFormat.Size = new System.Drawing.Size(69, 19);
            this.isFormat.TabIndex = 3;
            this.isFormat.Text = "Формат";
            this.isFormat.UseVisualStyleBackColor = true;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.isFormat);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.back);
            this.Name = "GeneratorForm";
            this.Text = "GeneratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back;
        private RichTextBox OutputTextBox;
        private Button GenerateButton;
        private CheckBox isFormat;
    }
}