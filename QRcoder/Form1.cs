using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace QRcoder
{
    public partial class Form1 : Form
    {
        private string nameCompany;
        private string notice;
        private string data_now;
        private string data_time_now;
        private System.Drawing.Image qrImage;
        public Form1()
        {
            InitializeComponent();
            printButton.Enabled = false;
        }

        private void GeneratorButton_Click(object sender, EventArgs e)
        {
            data_now = DateTime.Now.DayOfYear.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString();
            data_time_now = DateTime.Now.ToString();
            nameCompany = compNameText.Text.ToString();
            notice = noticeText.Text.ToString();
            GeneratorQR(nameCompany, notice, data_time_now);
            printButton.Enabled = true;
        }

        private void GeneratorQR(string nameCompany, string notice, string data_time_now)
        {
            string qr_string = nameCompany + "_" + notice + "_" + data_time_now;
            QRCodeWriter qrEncoder = new QRCodeWriter();
            Dictionary<EncodeHintType, object> hints = new Dictionary<EncodeHintType, object>
            {
                { EncodeHintType.CHARACTER_SET, "utf-8" }
            };
            BitMatrix qrMatrix = qrEncoder.encode(qr_string,
                BarcodeFormat.QR_CODE, 100, 100, hints);
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            qrImage = barcodeWriter.Write(qrMatrix);
            viewQR.Image = qrImage;
           
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            string file_name = "./" + nameCompany + "_"+ data_now+".pdf";
            PrintQRcode(qrImage);
            SaveQRcode(qrImage, file_name);
            printButton.Enabled = false;
        }

        private void SaveQRcode(System.Drawing.Image qrImage, string file_name)
        {
            Document doc = new Document(PageSize.POSTCARD);
            try
            {
                PdfWriter.GetInstance(doc, new FileStream(file_name, FileMode.Create));
                doc.Open();
                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(qrImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                doc.Add(pic);
                doc.NewPage();
            }
            catch (DocumentException de)
            {

                Console.Error.WriteLine(de.Message);
            }
            catch(IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }
            
            doc.Close();

        }

        private void PrintQRcode(System.Drawing.Image qrImage)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            doc.Print();
            doc.Dispose();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int h= e.PageSettings.Bounds.Height;
            int w = e.PageSettings.Bounds.Width;
            int hImage = qrImage.Height;
            int wImage = qrImage.Width;
            int hM = e.PageSettings.Margins.Bottom;
            int wM = e.PageSettings.Margins.Right;
            e.Graphics.DrawImage(qrImage, w-wImage-wM, h - hImage-hM);
            
        }

        
    }
}
