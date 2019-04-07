using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Massively
{
    public partial class Generic : System.Web.UI.MasterPage
    {
        List<PageAddress> pages = new List<PageAddress>();
        protected void Page_Load(object sender, EventArgs e)
        {

            pages.Add(new PageAddress("This is Massively", "default.aspx"));
            pages.Add(new PageAddress("Generic Page", "generic.aspx"));
            pages.Add(new PageAddress("Elements Reference", "elements.aspx"));
            litLinks.Text = GetLinks();

        }
        private string GetLinks()
        {
            string links = string.Empty;
            string s = this.Page.Request.FilePath;
            foreach (var page in pages)
                if (s.Trim().Contains(page.location.Replace(".aspx", "")))
                    links += $"<li class=\"active\"><a href=\"{page.location}\">{page.pagename}</a></li>";
                else
                    links += $"<li><a href=\"{page.location}\">{page.pagename}</a></li>";
            return links;
        }
    }
}