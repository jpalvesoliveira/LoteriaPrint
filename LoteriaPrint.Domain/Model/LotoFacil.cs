using System;
using System.Drawing.Printing;
using System.Configuration;
using System.Collections.Generic;

namespace LoteriaPrint.Domain.Model
{
    public class LotoFacil : Bilhete
    {
        public LotoFacil() : base(new PaperSize("LF",
                                                Convert.ToInt32(ConfigurationManager.AppSettings["LFWidth"]),
                                                Convert.ToInt32(ConfigurationManager.AppSettings["LFHeigth"])), 6, 10, 0.5f, new float[] { 3.0f, 3.0f, 2.0f })
        {
        }

        public override void InitializeNumbers()
        {
            /*byte last = 1;
            Numbers = new List<byte>();
            for (int i = 1; i <= Lines; i++)
            {
                for (int j = 1; j <= Columns; j++)
                {
                    Numbers.Add(last);
                    last += 1;
                }
            }*/
        }
    }
}
