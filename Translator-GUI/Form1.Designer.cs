namespace Translator_GUI
{
    partial class Form1
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
            this.outputLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.text_Textbox = new System.Windows.Forms.TextBox();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.translate_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLanguageComboBox
            // 
            this.outputLanguageComboBox.FormattingEnabled = true;
            this.outputLanguageComboBox.Location = new System.Drawing.Point(371, 51);
            this.outputLanguageComboBox.Name = "outputLanguageComboBox";
            this.outputLanguageComboBox.Size = new System.Drawing.Size(121, 21);
            this.outputLanguageComboBox.TabIndex = 0;
            // 
            // text_Textbox
            // 
            this.text_Textbox.Location = new System.Drawing.Point(211, 101);
            this.text_Textbox.Multiline = true;
            this.text_Textbox.Name = "text_Textbox";
            this.text_Textbox.Size = new System.Drawing.Size(281, 97);
            this.text_Textbox.TabIndex = 1;
            // 
            // clear_Btn
            // 
            this.clear_Btn.Location = new System.Drawing.Point(371, 223);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(75, 23);
            this.clear_Btn.TabIndex = 2;
            this.clear_Btn.Text = "Clear";
            this.clear_Btn.UseVisualStyleBackColor = true;
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // translate_Btn
            // 
            this.translate_Btn.Location = new System.Drawing.Point(252, 223);
            this.translate_Btn.Name = "translate_Btn";
            this.translate_Btn.Size = new System.Drawing.Size(75, 23);
            this.translate_Btn.TabIndex = 3;
            this.translate_Btn.Text = "Translate";
            this.translate_Btn.UseVisualStyleBackColor = true;
            this.translate_Btn.Click += new System.EventHandler(this.translate_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Output Language";
            // 
            // inputLanguageComboBox
            // 
            this.inputLanguageComboBox.FormattingEnabled = true;
            this.inputLanguageComboBox.Location = new System.Drawing.Point(211, 51);
            this.inputLanguageComboBox.Name = "inputLanguageComboBox";
            this.inputLanguageComboBox.Size = new System.Drawing.Size(121, 21);
            this.inputLanguageComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLanguageComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translate_Btn);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.text_Textbox);
            this.Controls.Add(this.outputLanguageComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox outputLanguageComboBox;
        private System.Windows.Forms.TextBox text_Textbox;
        private System.Windows.Forms.Button clear_Btn;
        private System.Windows.Forms.Button translate_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputLanguageComboBox;
        private System.Windows.Forms.Label label2;
    }
}

