using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

namespace Projekt
{
    public partial class Form2 : Form
    {
        Main_Form main_form;
        public Form2(Main_Form form)
        {

            InitializeComponent();
            main_form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (main_form.wyn != null)
           // {
                
                string path = Directory.GetCurrentDirectory();
                path += "\\Wzory\\wzor.pdf";
                var template = PdfSharp.Pdf.IO.PdfReader.Open(path, PdfSharp.Pdf.IO.PdfDocumentOpenMode.Import);
                PdfDocument raport = new PdfDocument();

                for (int i = 0; i < template.PageCount; i++)
                {
                    raport.AddPage(template.Pages[i]);
                }

                string dane = imie.Text + " " + nazwisko.Text;
                XGraphics gfx = XGraphics.FromPdfPage(raport.Pages[0]);
                XFont font = new XFont("Verdana", 14, XFontStyle.BoldItalic);
                XFont font1 = new XFont("Verdana", 12, XFontStyle.Italic);
                string data = System.DateTime.Now.ToString().Substring(0, 10);

                gfx.DrawString(data, font1, XBrushes.Black, new XRect(480, 83, 0, 0), XStringFormats.Default);
                gfx.DrawString(imie.Text, font1, XBrushes.Black, new XRect(50, 170, 0, 0), XStringFormats.Default);
                gfx.DrawString(nazwisko.Text, font1, XBrushes.Black, new XRect(50, 210, 0, 0), XStringFormats.Default);


                gfx.DrawString(main_form.wyn.PENSJA_NETTO.ToString() + " zł", font1, XBrushes.Black, new XRect(50, 250, 0, 0), XStringFormats.Default);
                gfx.DrawString(main_form.wyn.PENSJA_BRUTTO.ToString() + " zł", font1, XBrushes.Black, new XRect(50, 290, 0, 0), XStringFormats.Default);
                gfx.DrawString(main_form.wyn.PENSJA_BRUTTO_BRUTTO.ToString() + " zł", font1, XBrushes.Black, new XRect(50, 330, 0, 0), XStringFormats.Default);
                gfx.DrawString("-Emerytalna 9,76%: " + main_form.wyn.SKŁADKA_EMERYTALNA + " zł", font1, XBrushes.Black, new XRect(50, 400, 0, 0), XStringFormats.Default);
                gfx.DrawString("-Rentowa 1,5%: " + main_form.wyn.SKŁADKA_RENTOWA + " zł", font1, XBrushes.Black, new XRect(50, 420, 0, 0), XStringFormats.Default);
                gfx.DrawString("-Chorobowa 2,45%: " + main_form.wyn.SKŁADKA_CHOROBOWA + " zł", font1, XBrushes.Black, new XRect(50, 440, 0, 0), XStringFormats.Default);
                gfx.DrawString("-Zdrowotna 9%: " + main_form.wyn.SKŁADKA_ZDROWOTNA + " zł", font1, XBrushes.Black, new XRect(50, 460, 0, 0), XStringFormats.Default);
                gfx.DrawString(main_form.wyn.SkładkiSuma.ToString() + " zł", font, XBrushes.Black, new XRect(150, 502, 0, 0), XStringFormats.Default);

                try
                {
                    string newpath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\Raporty\\Raport " + dane + " z dnia " + data + ".pdf";
                    raport.Save(newpath);
                    System.Diagnostics.Process.Start(newpath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Plik w użyciu!");
                }
            //}
          
        }
    }
}
