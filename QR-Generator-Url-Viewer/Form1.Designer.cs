namespace QR_Generator_Url_Viewer
{
    partial class form_QRCodeGenerator
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
            this.textBox_inputURL = new System.Windows.Forms.TextBox();
            this.label_inputURL = new System.Windows.Forms.Label();
            this.button_generateQRCode = new System.Windows.Forms.Button();
            this.button_renderURL = new System.Windows.Forms.Button();
            this.pictureBox_code = new System.Windows.Forms.PictureBox();
            this.webView_renderer = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label_disclaimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView_renderer)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_inputURL
            // 
            this.textBox_inputURL.Location = new System.Drawing.Point(199, 28);
            this.textBox_inputURL.Name = "textBox_inputURL";
            this.textBox_inputURL.Size = new System.Drawing.Size(442, 22);
            this.textBox_inputURL.TabIndex = 0;
            // 
            // label_inputURL
            // 
            this.label_inputURL.AutoSize = true;
            this.label_inputURL.Location = new System.Drawing.Point(142, 31);
            this.label_inputURL.Name = "label_inputURL";
            this.label_inputURL.Size = new System.Drawing.Size(40, 16);
            this.label_inputURL.TabIndex = 1;
            this.label_inputURL.Text = "URL: ";
            // 
            // button_generateQRCode
            // 
            this.button_generateQRCode.Location = new System.Drawing.Point(572, 347);
            this.button_generateQRCode.Name = "button_generateQRCode";
            this.button_generateQRCode.Size = new System.Drawing.Size(125, 42);
            this.button_generateQRCode.TabIndex = 2;
            this.button_generateQRCode.Text = "Generate QR Code";
            this.button_generateQRCode.UseVisualStyleBackColor = true;
            this.button_generateQRCode.Click += new System.EventHandler(this.button_generateQRCode_Click);
            // 
            // button_renderURL
            // 
            this.button_renderURL.Location = new System.Drawing.Point(161, 347);
            this.button_renderURL.Name = "button_renderURL";
            this.button_renderURL.Size = new System.Drawing.Size(125, 42);
            this.button_renderURL.TabIndex = 3;
            this.button_renderURL.Text = "Show URL";
            this.button_renderURL.UseVisualStyleBackColor = true;
            this.button_renderURL.Click += new System.EventHandler(this.button_renderURL_Click);
            // 
            // pictureBox_code
            // 
            this.pictureBox_code.Location = new System.Drawing.Point(516, 98);
            this.pictureBox_code.Name = "pictureBox_code";
            this.pictureBox_code.Size = new System.Drawing.Size(230, 230);
            this.pictureBox_code.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_code.TabIndex = 4;
            this.pictureBox_code.TabStop = false;
            // 
            // webView_renderer
            // 
            this.webView_renderer.AllowExternalDrop = true;
            this.webView_renderer.CreationProperties = null;
            this.webView_renderer.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_renderer.Location = new System.Drawing.Point(45, 98);
            this.webView_renderer.Name = "webView_renderer";
            this.webView_renderer.Size = new System.Drawing.Size(421, 230);
            this.webView_renderer.TabIndex = 5;
            this.webView_renderer.ZoomFactor = 0.5D;
            // 
            // label_disclaimer
            // 
            this.label_disclaimer.AutoSize = true;
            this.label_disclaimer.Location = new System.Drawing.Point(142, 61);
            this.label_disclaimer.Name = "label_disclaimer";
            this.label_disclaimer.Size = new System.Drawing.Size(240, 16);
            this.label_disclaimer.TabIndex = 6;
            this.label_disclaimer.Text = "Note: Invalid URLs will not be rendered.";
            // 
            // form_QRCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_disclaimer);
            this.Controls.Add(this.webView_renderer);
            this.Controls.Add(this.pictureBox_code);
            this.Controls.Add(this.button_renderURL);
            this.Controls.Add(this.button_generateQRCode);
            this.Controls.Add(this.label_inputURL);
            this.Controls.Add(this.textBox_inputURL);
            this.Name = "form_QRCodeGenerator";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView_renderer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_inputURL;
        private System.Windows.Forms.Label label_inputURL;
        private System.Windows.Forms.Button button_generateQRCode;
        private System.Windows.Forms.Button button_renderURL;
        private System.Windows.Forms.PictureBox pictureBox_code;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_renderer;
        private System.Windows.Forms.Label label_disclaimer;
    }
}

