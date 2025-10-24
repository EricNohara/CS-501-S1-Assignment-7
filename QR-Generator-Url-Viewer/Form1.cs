using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace QR_Generator_Url_Viewer
{
    public partial class form_QRCodeGenerator : Form
    {    
        public form_QRCodeGenerator()
        {
            InitializeComponent();
        }

        private void button_generateQRCode_Click(object sender, EventArgs e)
        {
            try
            {
                //only generate QR code for valud URL
                if (isValidUrl(textBox_inputURL.Text))
                {
                    //get the QR code image as a byte array
                    byte[] qrCodeImage = generateQRCode();
                    //convert the byte array to an Image object by converting it to a stream
                    using (MemoryStream memoryStream = new MemoryStream(qrCodeImage))
                    {
                        Image image = Image.FromStream(memoryStream);
                        pictureBox_code.Image = image;
                    }
                }
            }
            //if anything goes wrong, just show a blank image and empty the text box
            catch {
                pictureBox_code.Image = null;
                textBox_inputURL.Text = "";
            }
        }

        //generate qrcode data
        private byte[] generateQRCode()
        {
            //retrieve the payload
            var payload = new PayloadGenerator.Url(textBox_inputURL.Text);
            //get the code data
            var data = QRCodeGenerator.GenerateQrCode(payload);
            //create the code image
            return new PngByteQRCode(data).GetGraphic(20);
        }

        private void button_renderURL_Click(object sender, EventArgs e)
        {
            try
            {
                //only show page if URL is valid
                if (isValidUrl(textBox_inputURL.Text))
                {
                    showWebPage();
                }
            }
            //if the URL is not valid, empty the text box and do not render it
            catch
            {
                textBox_inputURL.Text = "";
            }
        }

        //apply the given url to the webView
        private async void showWebPage()
        {
            await webView_renderer.EnsureCoreWebView2Async();
            webView_renderer.CoreWebView2.Navigate(textBox_inputURL.Text);
        }

        //A method to check if a given URL is valid or not
        private bool isValidUrl(string url)
        {
            //check is URL is valid by attempting to parse a URI from it
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult))
            {
                //allow only http and https urls
                return uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps;
            }
            return false;
        }
    }
}
