using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forty
{
    public partial class Landing : System.Web.UI.MasterPage
    {
        List<PageAddress> pages = new List<PageAddress>();
        protected void Page_Load(object sender, EventArgs e)
        {

            pages.Add(new PageAddress("Home", "default.aspx"));
            pages.Add(new PageAddress("Landing", "landing.aspx"));
            pages.Add(new PageAddress("Generic", "generic.aspx"));
            pages.Add(new PageAddress("Elements", "elements.aspx"));
            litLinks.Text = GetLinks();

        }
        private string GetLinks()
        {
            string links = string.Empty;
            foreach (var page in pages)
                links += $"<li><a href=\"{page.location}\">{page.pagename}</a></li>";
            return links;
        }
    }
}