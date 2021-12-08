using MigraDoc.DocumentObjectModel;
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
            foreach (PropertyInfo pi in pInfo)
            {
                Paragraph line = page.AddParagraph();
                line.Format.Font.Color = Color.FromCmyk(100, 30, 20, 50);
                try
                {
                    //line.AddFormattedText("Iterated", TextFormat.Bold);
                    line.AddFormattedText((string)pi.GetValue(auditFormData), TextFormat.Bold);
                }
                catch(ArgumentNullException e)
                {
                    line.AddFormattedText("Broken", TextFormat.Bold);
                }
                
            }
            

            return document;
        }




        // Console.WriteLine(pi.GetValue(auditFormData));
        //File.AppendAllText("Save.txt", pi.GetValue(auditFormData) + Environment.NewLine);
            

}
}
