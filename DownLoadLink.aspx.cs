using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;
using System.IO;
public partial class DownLoadLink : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{

                string fileName = Request.QueryString["name"].ToString();

                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment;filename=" + fileName);
                Response.TransmitFile(Server.MapPath("UploadFiles//" + fileName));
                Response.End();
            //}
            //catch(Exception e1)
            //{
            //    //file not found redirect to the error page.
            //    Response.Redirect("Error.aspx");
            //}
    }
    }