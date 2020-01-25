namespace SolidState
{
    class PageAddress
    {
        public string pagename { get; set; }
        public string location { get; set; }
        public PageAddress(string pn, string loc)
        {
            pagename = pn;
            location = loc;
        }
    }
}