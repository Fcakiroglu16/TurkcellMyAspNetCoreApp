namespace MyAspNetCoreApp.Web.ViewModels
{
    public class VisitorViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public string Date => Created.ToShortDateString();

    }
}
