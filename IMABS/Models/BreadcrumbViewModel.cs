namespace IMABS.Models
{
    public class BreadcrumbViewModel
    {
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }
        public bool IsCurrentPage { get; set; }


        public BreadcrumbViewModel() { }
    }
}
