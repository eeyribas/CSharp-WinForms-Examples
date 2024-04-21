using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCodecInfo_EncoderDecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= ImageCodecInfo.GetImageEncoders().Length - 1; i++)
            {
                listBox1.Items.Add("Codec Name: " + ImageCodecInfo.GetImageEncoders()[i].CodecName);
                listBox1.Items.Add("Directory Paths: " + ImageCodecInfo.GetImageEncoders()[i].FilenameExtension);
                listBox1.Items.Add("Codec Description: " + ImageCodecInfo.GetImageEncoders()[i].FormatDescription);
                listBox1.Items.Add("Codec Guid Number: " + ImageCodecInfo.GetImageEncoders()[i].Clsid.ToString());
                listBox1.Items.Add("Codec Mime Info: " + ImageCodecInfo.GetImageEncoders()[i].MimeType);
                listBox1.Items.Add("-------------------");
            }

            for (int i = 0; i <= ImageCodecInfo.GetImageDecoders().Length - 1; i++)
            {
                listBox2.Items.Add("Codec Name: " + ImageCodecInfo.GetImageDecoders()[i].CodecName);
                listBox2.Items.Add("Directory Paths: " + ImageCodecInfo.GetImageDecoders()[i].FilenameExtension);
                listBox2.Items.Add("Codec Description: " + ImageCodecInfo.GetImageDecoders()[i].FormatDescription);
                listBox2.Items.Add("Codec Guid Number: " + ImageCodecInfo.GetImageDecoders()[i].Clsid.ToString());
                listBox2.Items.Add("Codec Mime Info: " + ImageCodecInfo.GetImageDecoders()[i].MimeType);
                listBox2.Items.Add("-------------------");
            }
        }
    }
}
