using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftEngSiteBuild
{
    public partial class PDFDocumentation
    {
        public static AuditFormData auditFormData = new AuditFormData();
        public static Document CreateDocument()
        {
            //AuditFormData auditFormData = new AuditFormData();
            System.Console.WriteLine(auditFormData);
            AuditFormData afd = new AuditFormData();
            Type afdType = afd.GetType();
            PropertyInfo[] pInfo = afdType.GetProperties();
            Document document = new Document();
            Section page = document.AddSection();

            // Table------------
            Style style = document.Styles["Normal"];
            style = document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Size = 9;
            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);


            //formats table
            Table table = page.AddTable();
            table.Style = "Table";
            table.Borders.Color = Colors.Black;
            table.Borders.Width = 0.25;
            table.Borders.Left.Width = 0.5;
            table.Borders.Right.Width = 0.5;
            table.Rows.LeftIndent = 0;

            //creates columns
            Column namecolumn = new Column();
            namecolumn = table.AddColumn("8cm");
            namecolumn.Format.Alignment = ParagraphAlignment.Left;
            Column valuecolumn = new Column();
            valuecolumn = table.AddColumn("4cm");
            valuecolumn.Format.Alignment = ParagraphAlignment.Left;

            //creates rows
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Cells[0].AddParagraph("Variable Names");
            row.Cells[0].Format.Font.Bold = false;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[1].AddParagraph("Values");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            Row row1 = table.AddRow();
            row.Borders.Visible = true;
            //---------------

            foreach (PropertyInfo pi in pInfo)
            {
                Paragraph line = page.AddParagraph();
                line.Format.Font.Color = Color.FromCmyk(0, 66, 56, 36);
                try
                {
                    row1 = table.AddRow();
                    //line.AddFormattedText("Iterated", TextFormat.Bold);
                    //line.AddFormattedText(pi.Name, TextFormat.Bold);
                    //line.AddFormattedText(": ", TextFormat.Bold);
                    //line.AddFormattedText((string)pi.GetValue(auditFormData), TextFormat.Bold);
                    row1.Cells[0].AddParagraph(pi.Name);
                    //line.Format.Font.Color = Color.FromCmyk(0, 66, 56, 36);
                    //line.AddFormattedText(pi.Name, TextFormat.Bold);
                    row1.Cells[1].AddParagraph((string)pi.GetValue(auditFormData));
                    //row1 = table.AddRow();
                }
                catch(ArgumentNullException e)
                {
                    //Line used to test if data was broken
                    //line.AddFormattedText("N/A or Left Blank", TextFormat.Bold);
                }
            }
            return document;
        }




        // Console.WriteLine(pi.GetValue(auditFormData));
        //File.AppendAllText("Save.txt", pi.GetValue(auditFormData) + Environment.NewLine);
            

}
}
