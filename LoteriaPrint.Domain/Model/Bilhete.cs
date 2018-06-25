using System.Drawing.Printing;
using System.Collections.Generic;

namespace LoteriaPrint.Domain.Model
{
    public abstract class Bilhete
    {
        public Bilhete(PaperSize psize, byte cols, byte lines, float width, float height, float spaceV, float spaceH, float count, float[] margins)
        {
            PaperSize = psize;
            Columns = cols;
            Lines = lines;
            SpaceV = spaceV;
            SpaceH = spaceH;
            Margins = margins;
            Width = width;
            Height = height;
            Count = count;
            InitializeNumbers();
        }

        public byte Columns { get; set; }
        
        public byte Lines { get; set; }

        public float SpaceV { get; set; }

        public float SpaceH { get; set; }

        public float[] Margins { get; set; }

        public PaperSize PaperSize { get; set; }

        public float Width { get; set; }

        public float Height { get; set; }

        public float Count { get; set; }

        public byte[,] Numbers { get; set; }

        public IList<byte> SortedNumbers { get; set; }

        public abstract void InitializeNumbers();
    }
}
