namespace BigForms
{
    partial class ValidatorForm
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
            this.ValidatorButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
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
            // ValidatorButton
            // 
            this.ValidatorButton.Location = new System.Drawing.Point(93, 12);
            this.ValidatorButton.Name = "ValidatorButton";
            this.ValidatorButton.Size = new System.Drawing.Size(697, 23);
            this.ValidatorButton.TabIndex = 1;
            this.ValidatorButton.Text = "Валидация документа";
            this.ValidatorButton.UseVisualStyleBackColor = true;
            this.ValidatorButton.Click += new System.EventHandler(this.ValidatorButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 41);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(386, 397);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.Text = "";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(404, 41);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(386, 397);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "";
            // 
            // ValidatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.ValidatorButton);
            this.Controls.Add(this.back);
            this.Name = "ValidatorForm";
            this.Text = "ValidatorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button back;
        private Button ValidatorButton;
        private RichTextBox inputTextBox;
        private RichTextBox outputTextBox;
    }
}