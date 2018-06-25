using LoteriaPrint.Domain.Model;
using LoteriaPrint.Domain.Services;
using System.Drawing.Printing;
using System.Drawing;

namespace LoteriaPrint.Core.Services
{
    public class GDIPrintService : IPrintService
    {
        private PrintDocument doc;
        private Bilhete bilhete;

        public void Print(Bilhete obj)
        {
            bilhete = obj;
            doc = new PrintDocument();
            //DefaultPageSettings
            //doc.QueryPageSettings += Doc_QueryPageSettings;
            doc.PrintPage += Doc_PrintPage;
            doc.DefaultPageSettings.PaperSize = bilhete.PaperSize; //= new PaperSize("210 x 297 mm", 800, 800);
            doc.Print();
        }

        private void Doc_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            e.PageSettings.PaperSize = bilhete.PaperSize;
            //e.PageSettings.PaperSize = new PaperSize("210 x 297 mm", 800, 800);
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float mR = 0;
            float mU = 0;

            mU = bilhete.Margins[1];
            for (int i = 0; i < bilhete.Lines; i ++)
            {
                mR = bilhete.Margins[0];

                for (int j = 0; j < bilhete.Columns; j ++)
                {
                    if (bilhete.SortedNumbers.Contains(bilhete.Numbers[i, j]))
                        e.Graphics.FillRectangle(Brushes.Black, new RectangleF((int) mR, (int)mU, bilhete.Width, bilhete.Height));
                    mR += bilhete.SpaceH + bilhete.Width;
                }
                mU += bilhete.Height + bilhete.SpaceV;
            }

            mU = bilhete.Count;
            mR = 0;
            e.Graphics.FillRectangle(Brushes.Black, new RectangleF((int)mR, (int)mU, bilhete.Width, bilhete.Height));
        }
    }
}