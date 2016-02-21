using System;
using System.Drawing;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

var xfSansHeader = new XFont("Cambria", 32.0, XFontStyle.Bold);
var xfSansBody = new XFont("Calibri", 12.0, XFontStyle.Regular);

var margin = 20.0F;
var ps = new SizeF((float)gfx.PageSize.Width, (float)gfx.PageSize.Height);

gfx.DrawString("Header text", xfSansHeader, XBrushes.Black,
    new PointF(margin, margin + xfSansHeader.Height / 2));

gfx.DrawString("Body text", xfSansBody, XBrushes.Black, new PointF(margin, 76));

gfx.DrawLine(XPens.Black, new PointF(margin, 50), new PointF(ps.Width - margin, 50));

gfx.DrawRectangle(XPens.Black, XBrushes.Transparent,
    new RectangleF(margin, 90, ps.Width - (margin * 2), 200));

gfx.DrawString("Text inside rectangle", xfSansBody, XBrushes.Black,
    new PointF(margin + 10, 100 + xfSansBody.Height / 2));

Footer("Footer left side text", "- 1 -", "Footer right side text");


void Footer(string textLeft, string textCenter, string textRight)
{
    gfx.DrawLine(XPens.Black, new PointF(margin, ps.Height - 50),
        new PointF(ps.Width - margin, ps.Height - 50));

    gfx.DrawString(textLeft, xfSansBody, XBrushes.Black,
        new PointF(margin, ps.Height - (xfSansBody.Height / 2) - margin));


    var fcts = gfx.MeasureString(textCenter, xfSansBody);
    gfx.DrawString(textCenter, xfSansBody, XBrushes.Black,
        new PointF(((ps.Width - (float)fcts.Width) / 2), ps.Height - (xfSansBody.Height / 2) - margin));

    var frts = gfx.MeasureString(textRight, xfSansBody);
    gfx.DrawString(textRight, xfSansBody, XBrushes.Black,
        new PointF(ps.Width - margin - (float)frts.Width, ps.Height - (xfSansBody.Height / 2) - margin));
}