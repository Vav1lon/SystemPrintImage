using System;
using System.Drawing.Printing;
using System.Drawing;

namespace SPimg
{
    public class FormatDetector
    {
        public PaperSize DetectFormat(string filePath)
        {
            var image = new Bitmap(filePath, true);
            
            //Высота 
            double Hmm = (image.Size.Height / image.VerticalResolution) * 25.4;
            //Ширина
            double Wmm = (image.Size.Width / image.HorizontalResolution) * 25.4;

            var pageSize = DetectPageSize(Wmm, Hmm);
            if (pageSize == null)
                throw new UknownDrawingFormatException(string.Format("Не удается определить формат чертежа {0}.", filePath));

            return pageSize;
        }

        private PaperSize DetectPageSize(double wmm, double hmm)
        {

            wmm = Math.Round(wmm, 0);
            hmm = Math.Round(hmm, 0);

            var a4Albom = new PaperSize("A4 (Альбом)", 297, 210);
            var a4Kniga = new PaperSize("A4 (Книга)", 210, 297);

            if (wmm < a4Albom.Width + 10 && hmm < a4Albom.Height + 10) { return a4Albom; }
            if (wmm < a4Kniga.Width + 10 && hmm < a4Kniga.Height + 10) { return a4Kniga; }

            var a3Albom = new PaperSize("A3 (Альбом)", 420, 297);
            var a3Kniga = new PaperSize("A3 (Книга)", 297, 420);

            if (wmm < a3Albom.Width + 44 && hmm < a3Albom.Height + 44) { return a3Albom; }
            if (wmm < a3Kniga.Width + 44 && hmm < a3Kniga.Height + 44) { return a3Kniga; }

            var a2Albom = new PaperSize("A2 (Альбом)", 594, 420);
            var a2Kniga = new PaperSize("A2 (Книга)", 420, 549);

            if (wmm < a2Albom.Width + 88 && hmm < a2Albom.Height + 88) { return a2Albom; }
            if (wmm < a2Kniga.Width + 88 && hmm < a2Kniga.Height + 88) { return a2Kniga; }

            var a1Albom = new PaperSize("A1 (Альбом)", 549, 841);
            var a1Kniga = new PaperSize("A1 (Книга)", 841, 549);

            if (wmm < a1Albom.Width + 176 && hmm < a1Albom.Height + 176) { return a1Albom; }
            if (wmm < a1Kniga.Width + 176 && hmm < a1Kniga.Height + 176) { return a1Kniga; }

            return null;
        }
    }

    [global::System.Serializable]
    public class UknownDrawingFormatException : Exception
    {
        public UknownDrawingFormatException() { }
        public UknownDrawingFormatException(string message) : base(message) { }
        public UknownDrawingFormatException(string message, Exception inner) : base(message, inner) { }
        protected UknownDrawingFormatException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
