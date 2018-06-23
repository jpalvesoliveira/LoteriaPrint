using System.Drawing.Printing;

namespace LoteriaPrint.Domain.Model
{
    public class Quina : Bilhete
    {
        public Quina() : base(new PaperSize("MS", 200, 300), 10, 8, 1.5f, new float[] { 10f, 269.34f, 2.0f })
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
