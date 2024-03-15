using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication8.Models;

namespace WebApplication8.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        public int Count { get; private set; } = 1;
        public List<Component> Components;
        public void OnGet()
        {
            int count_parsed;
            if (int.TryParse(Request.Query["count"], out count_parsed))
            {
                Count = count_parsed;
            }
            else {
                Count = 3;
            }
        }
        public void OnPost(List<Component> components)
        {
            Components = components;
        }

    }
}
