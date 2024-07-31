using Employee_managment.Models;
using Employee_managment.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employee_managment.Pages
{
    public class PeopleModel : PageModel
    {
        private readonly MyDbContext _context;

        public List<Person> People { get; set; } = new List<Person>();
        [BindProperty]
        public Person newPerson { get; set; }

        public PeopleModel(MyDbContext context) {
            _context = context;
        }
        public void OnGet()
        {
            People = _context.People.ToList();
        }

        public IActionResult OnPost()
        {
            _context.People.Add(newPerson);
            _context.SaveChanges();
            return RedirectToPage();
        }
    }
}
