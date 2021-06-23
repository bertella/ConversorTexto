using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Patagames.Ocr;
using System.Drawing;

namespace ImagenTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcTarget.ImageLocation = @"C:\Users\fnilsson.SeaburyMRO\source\repos\ImagenTexto\ImagenTexto\Imagen\Texto_I_de_Gil_(1799).png";
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);

                string plaiText = objOcr.GetTextFromImage(pcTarget.ImageLocation);

                txtMuestra.Text = plaiText;


            }

        }
    }
}
