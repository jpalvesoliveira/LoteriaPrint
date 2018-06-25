using System;
using System.Configuration;
using System.Drawing.Printing;

namespace LoteriaPrint.Domain.Model
{
    public class Quina : Bilhete
    {
        //public Quina() : base(new PaperSize("QU",
        //                                    Convert.ToInt32(sections["QUWidth"].ToString()),
        //                                    //Convert.ToInt32(ConfigurationManager.AppSettings["QUWidth"]),
        //                                    Convert.ToInt32(ConfigurationManager.AppSettings["QUHeigth"])),
        //                                    Convert.ToByte(ConfigurationManager.AppSettings["QUCols"]),
        //                                    Convert.ToByte(ConfigurationManager.AppSettings["QULines"]), 1.5f, new float[] { 10f, 269.34f, 2.0f })
        //{
        //}
        public Quina() : base(new PaperSize("QU",210,297),
                                            10,
                                            8,
                                            14.25f,
                                            9.5f,
                                            4.7f,
                                            13.7f,
                                            559f,
                                            new float[] { 0f, 269.34f })
        {
        }

        public override void InitializeNumbers()
        {
            byte last = 1;
            Numbers = new byte[Lines, Columns];
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Numbers[i, j] = last;
                    last += 1;
                }
            }
        }
    }
}