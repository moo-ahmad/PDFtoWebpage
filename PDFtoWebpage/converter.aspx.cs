using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;

namespace PDFtoWebpage
{
    public partial class converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnupload_Click(object sender, EventArgs e)
        {
            Debug.Write("We are in...........");

            string physicalpath = Server.MapPath("~/Uploads/");

            if (!Directory.Exists(physicalpath))
            {
                Directory.CreateDirectory(physicalpath);
            }
            fileupload1.SaveAs(physicalpath + System.IO.Path.GetFileName(fileupload1.FileName));

            Response.Write("File Uploaded Successfully!");
            

        }

        protected void btnconvert_Click(object sender, EventArgs e)
        {
            Debug.Write("We are in...........");
            string file = @"~/myfile.pdf";
            StringBuilder sb = new StringBuilder();
            using(PdfReader reader = new PdfReader(file))
            {
                for(int pageNo = 1; pageNo<=reader.NumberOfPages; pageNo++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text = PdfTextExtractor.GetTextFromPage(reader, pageNo, strategy);
                    text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                    sb.Append(text);
                }
            }
            Response.Write("text is "+sb.ToString());
        }
    }
}