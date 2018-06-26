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
                                                Convert.ToInt32(ConfigurationManager.AppSettings["LFHeigth"])), 5, 5, 0.5f, new float[] { 3.0f, 3.0f, 2.0f })
        {
        }

        public override void InitializeNumbers()
        {
            byte last = 1;
            Numbers = new byte[Lines, Columns];
            for (int i = Columns - 1; i >= 0; i--)
            {
                for (int j = 0; j < Lines; j++)
                {
                    Numbers[j, i] = last;
                    last += 1;
                }
            }
        }
    }
}
