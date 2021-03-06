using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Orchard.Queries.ViewModels
{
    public class EditQueryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }

        [BindNever]
        public Query Query { get; set; }
    }
}
