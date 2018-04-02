using System.Drawing.Printing;
using System.Collections.Generic;

namespace LoteriaPrint.Domain.Model
{
    public abstract class Bilhete
    {
        public Bilhete(PaperSize psize, byte cols, byte lines, float space, float[] margins)
        {
            PaperSize = psize;
            Columns = cols;
            Lines = lines;
            Space = space;
            Margins = margins;
            InitializeNumbers();
        }

        public byte Columns { get; set; }
        
        public byte Lines { get; set; }

        public float Space { get; set; }

        public float[] Margins { get; set; }

        public PaperSize PaperSize { get; set; }

        public byte[,] Numbers { get; set; }

        public IList<byte> SortedNumbers { get; set; }

        public abstract void InitializeNumbers();
    }
}
