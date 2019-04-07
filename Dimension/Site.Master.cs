using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dimension
{
    public partial class SiteMaster : MasterPage
    {
        List<PageAddress> pages = new List<PageAddress>();
        protected void Page_Load(object sender, EventArgs e)
        {

            pages.Add(new PageAddress("Intro", "#intro"));
            pages.Add(new PageAddress("Work", "#work"));
            pages.Add(new PageAddress("About", "#about"));
            pages.Add(new PageAddress("Contact", "#contact"));
            pages.Add(new PageAddress("Elements", "#elements"));
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