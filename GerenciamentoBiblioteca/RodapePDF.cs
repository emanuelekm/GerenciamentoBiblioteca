using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    public class RodapePDF : PdfPageEventHelper
    {
        private PdfContentByte cb;
        private BaseFont baseFont;
        private PdfTemplate template;

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            cb = writer.DirectContent;
            template = cb.CreateTemplate(50, 50);
            baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            string textoRodape = $"Gerado em {DateTime.Now:dd/MM/yyyy HH:mm}";

            float larguraPagina = document.PageSize.Width;
            float rodapeY = document.Bottom - 20;

            cb.BeginText();
            cb.SetFontAndSize(baseFont, 9);
            cb.ShowTextAligned(Element.ALIGN_LEFT, textoRodape, document.Left, rodapeY, 0);
            cb.ShowTextAligned(Element.ALIGN_RIGHT, $"Página {writer.PageNumber}", larguraPagina - document.Right, rodapeY, 0);
            cb.EndText();
        }
    }
}
