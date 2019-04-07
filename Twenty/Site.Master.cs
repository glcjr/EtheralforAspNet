using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Twenty
{
    public partial class SiteMaster : MasterPage
    {
        List<PageAddress> pages = new List<PageAddress>();
        List<PageAddress> subpages = new List<PageAddress>();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            pages.Add(new PageAddress("Left Sidebar", "left-sidebar.aspx"));
            pages.Add(new PageAddress("Right Sidebar", "right-sidebar.aspx"));
            pages.Add(new PageAddress("No Sidebar", "no-sidebar.aspx"));
            pages.Add(new PageAddress("Contact", "contact.aspx"));
            subpages.Add(new PageAddress("Dore Sed", "#"));
            subpages.Add(new PageAddress("Consequat", "#"));
            subpages.Add(new PageAddress("Lorem Magna", "#"));
            subpages.Add(new PageAddress("Sed Magna", "#"));
            subpages.Add(new PageAddress("Ipsum Nisl", "#"));
            litLinks.Text = GetLinks(pages);
            litSubLinks.Text = GetLinks(subpages);

        }
        private string GetLinks(List<PageAddress> htmlpages)
        {
            string links = string.Empty;
            foreach (var page in htmlpages)
                links += $"<li><a href=\"{page.location}\">{page.pagename}</a></li>";
            return links;
        }
    }
}