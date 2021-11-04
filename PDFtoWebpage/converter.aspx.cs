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
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using Aspose.Pdf;
using Document = Aspose.Pdf.Document;

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
            //string file = @"C:\Users\mahmad\source\repos\PDFtoWebpage\PDFtoWebpage\Uploads\myfile.pdf";
            //StringBuilder sb = new StringBuilder();
            //using(PdfReader reader = new PdfReader(file))
            //{
            //    for(int pageNo = 1; pageNo<=reader.NumberOfPages; pageNo++)
            //    {
            //        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            //        string text = PdfTextExtractor.GetTextFromPage(reader, pageNo, strategy);
            //        text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
            //        sb.Append(text);
            //    }
            //}
            ////  Response.Write("text is "+sb.ToString());

            //converted.Controls.Add(new LiteralControl(sb.ToString()));

            


        }

        //protected void Upload(object sender, EventArgs e)
        //{
        //    Debug.Write("We are in...........");
        //    object documentFormat = 8;
        //    string randomName = DateTime.Now.Ticks.ToString();
        //    object htmlFilePath = Server.MapPath("~/Temp1/") + randomName + ".htm";
        //    string directoryPath = Server.MapPath("~/Temp1/") + randomName + "_files";
        //    object fileSavePath = Server.MapPath("~/Temp1/") + System.IO.Path.GetFileName(fileupload1.PostedFile.FileName);

        //    //If Directory not present, create it.
        //    if (!Directory.Exists(Server.MapPath("~/Temp1/")))
        //    {
        //        Directory.CreateDirectory(Server.MapPath("~/Temp1/"));
        //    }


        //    //Upload the word document and save to Temp folder.
        //    fileupload1.PostedFile.SaveAs(fileSavePath.ToString());

        //    //Open the word document in background.
        //    Microsoft.Office.Interop.Word._Application applicationclass = new Application();
        //    applicationclass.Documents.Open(ref fileSavePath);
        //    applicationclass.Visible = false;
        //    Document document = applicationclass.ActiveDocument;

        //    //Save the word document as HTML file.
        //    document.SaveAs(ref htmlFilePath, ref documentFormat);

        //    //Close the word document.
        //    document.Close();

        //    //Read the saved Html File.
        //    string wordHTML = System.IO.File.ReadAllText(htmlFilePath.ToString());

        //    //Loop and replace the Image Path.
        //    foreach (Match match in Regex.Matches(wordHTML, "<v:imagedata.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase))
        //    {
        //        wordHTML = Regex.Replace(wordHTML, match.Groups[1].Value, "Temp/" + match.Groups[1].Value);
        //    }

        //    //Delete the Uploaded Word File.
        //    System.IO.File.Delete(fileSavePath.ToString());

        //    converted.InnerHtml = wordHTML;
        //}

        protected void Upload(object sender, EventArgs e)
        {

            Aspose.Pdf.License pdflicense = new Aspose.Pdf.License();

            pdflicense.SetLicense("C:\\Users\\mahmad\\source\\repos\\PDFtoWebpage\\PDFtoWebpage");

            // Load source PDF file
            Document doc = new Document("C:\\Users\\mahmad\\source\\repos\\PDFtoWebpage\\PDFtoWebpage\\myfile.pdf");
            // Instantiate HTML Save options object
            HtmlSaveOptions newOptions = new HtmlSaveOptions();

            // Enable option to embed all resources inside the HTML
            newOptions.PartsEmbeddingMode = HtmlSaveOptions.PartsEmbeddingModes.EmbedAllIntoHtml;

            // This is just optimization for IE and can be omitted 
            newOptions.LettersPositioningMethod = HtmlSaveOptions.LettersPositioningMethods.UseEmUnitsAndCompensationOfRoundingErrorsInCss;
            newOptions.RasterImagesSavingMode = HtmlSaveOptions.RasterImagesSavingModes.AsEmbeddedPartsOfPngPageBackground;
            newOptions.FontSavingMode = HtmlSaveOptions.FontSavingModes.SaveInAllFormats;
            // Output file path 
            string outHtmlFile = "C:\\Users\\mahmad\\source\\repos\\PDFtoWebpage\\PDFtoWebpage\\SingleHTML_out.html";
            doc.Save(outHtmlFile, newOptions);

        }

    }
}