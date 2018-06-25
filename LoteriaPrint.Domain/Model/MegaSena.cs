using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;

namespace LoteriaPrint.Domain.Model
{
    public class MegaSena : Bilhete
    {
        public MegaSena() : base(new PaperSize("MS", 200 ,300), 
                                 10, 
                                 6,
                                 14.25f,
                                 9.5f,
                                 4.75f,
                                 14.25f,
                                 542.73f,
                                 new float[] { 20.0f, 11.0f, 2.0f })
        {
        }

        public override void InitializeNumbers()
        {
            byte last = 1;
            Numbers = new byte[Lines, Columns] ;
            for (int i = 0; i < Lines; i ++)
            {
                for (int j = 0; j < Columns; j ++)
                {
                    Numbers[i, j] = last;
                    last += 1;
                }
            }
        }
    }
}