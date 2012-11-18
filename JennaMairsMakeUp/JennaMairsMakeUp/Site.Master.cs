using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JennaMairsMakeUp
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string curlink = Request.RawUrl;

            if (curlink.Contains("/Index.aspx"))
            {
                homeLink.InnerText = "[home]";
                homeLink.Attributes["class"] = "selected";
            }
            else if (curlink.Contains("/About.aspx"))
            {
                aboutLink.InnerText = "[about]";
                aboutLink.Attributes["class"] = "selected";
            }
            else if (curlink.Contains("/contact.aspx"))
            {
                contactLink.InnerText = "[contact]";
                contactLink.Attributes["class"] = "selected";
            }
            else if (curlink.Contains("/blog.aspx"))
            {
                blogLink.InnerText = "[blog]";
                blogLink.Attributes["class"] = "selected";
            }
            else if (curlink.Contains("/portfolio_one.aspx"))
            {
                galleryLink.InnerText = "[gallery]";
                galleryLink.Attributes["class"] = "selected";
            }
        }
    }
}
