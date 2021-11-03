using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;

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

            string physicalpath = Server.MapPath("~/");

            if (!Directory.Exists(physicalpath))
            {
                Directory.CreateDirectory(physicalpath);
            }
            fileupload1.SaveAs(physicalpath + Path.GetFileName(fileupload1.FileName));

            Response.Write("File Uploaded Successfully!");
            

        }
    }
}