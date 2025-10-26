namespace Youtube_Downloader_GUI
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
            this.tbEnterUrl = new System.Windows.Forms.TextBox();
            this.lbEnterUrl = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lbDownloadStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEnterUrl
            // 
            this.tbEnterUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterUrl.Location = new System.Drawing.Point(175, 319);
            this.tbEnterUrl.Name = "tbEnterUrl";
            this.tbEnterUrl.Size = new System.Drawing.Size(579, 38);
            this.tbEnterUrl.TabIndex = 0;
            // 
            // lbEnterUrl
            // 
            this.lbEnterUrl.AutoSize = true;
            this.lbEnterUrl.Location = new System.Drawing.Point(170, 276);
            this.lbEnterUrl.Name = "lbEnterUrl";
            this.lbEnterUrl.Size = new System.Drawing.Size(327, 25);
            this.lbEnterUrl.TabIndex = 1;
            this.lbEnterUrl.Text = "Enter a YouTube url to download";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDownload.Location = new System.Drawing.Point(816, 276);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(240, 81);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lbDownloadStatus
            // 
            this.lbDownloadStatus.AutoSize = true;
            this.lbDownloadStatus.Location = new System.Drawing.Point(170, 402);
            this.lbDownloadStatus.Name = "lbDownloadStatus";
            this.lbDownloadStatus.Size = new System.Drawing.Size(0, 25);
            this.lbDownloadStatus.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 682);
            this.Controls.Add(this.lbDownloadStatus);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lbEnterUrl);
            this.Controls.Add(this.tbEnterUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEnterUrl;
        private System.Windows.Forms.Label lbEnterUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lbDownloadStatus;
    }
}

