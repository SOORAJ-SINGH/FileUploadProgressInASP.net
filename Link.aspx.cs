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
using System.IO;
using System.Linq;
using System.Threading;
using System.Text;
using System.Web.UI.HtmlControls;
using System.Drawing;

public partial class Link : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

     string s = Request.QueryString["name"];
     
        if (s != null)
           {

            link.Text = s;
            link.NavigateUrl = "DownLoadLink.aspx?name=" + s;
          
            //Page.Controls.Add(link);
            //Page.Controls.Add(new LiteralControl("<br/>"));

        }
        else
        {
          
                DirectoryInfo directory = new DirectoryInfo(Server.MapPath("UploadFiles//"));

               
                foreach (FileInfo file in directory.GetFiles())
                {
            
                link.Text = file.Name;
                link.NavigateUrl = "DownLoadLink.aspx?name=" + file.Name;
         
                //Page.Controls.Add(link);
                //Page.Controls.Add(new LiteralControl("<br/>"));
            }

        }
        }






    protected void lnkbback_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
