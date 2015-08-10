using System;
using System.Drawing;
using System.IO;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
namespace QrCodeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var qr = new QRCodeWriter();

            string url = "http://www.developerbyte.com";

            

            var w = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions {Height = 200, Width = 200, Margin = 2 }
            };

            Bitmap img = w.Write(url);

            img.Save(@"C:\Temp\Data\myQR.png", System.Drawing.Imaging.ImageFormat.Png);
            
          

           

            Console.ReadLine();
        }
    }
}
