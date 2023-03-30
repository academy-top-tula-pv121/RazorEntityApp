using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEntityApp.Models;

namespace RazorEntityApp.Pages
{
    public class EditEmployeeModel : PageModel
    {
        AppRazorContext context;

        [BindProperty]
        public Employee? Employee { get; set; }

        public EditEmployeeModel(AppRazorContext context)
        {
            this.context = context;
        }
        public IActionResult OnGet(int id)
        {
            Employee = context.Employees.Find(id);
            if (Employee == null)
                return NotFound();
            return Page();
        }

        public IActionResult OnPost()
        {
            context.Employees.Update(Employee!);
            context.SaveChanges();
            return RedirectToPage("Index");
        }

        //public async Task<IActionResult> OnGetAsync(int id)
        //{
        //    Employee = await context.Employees.FindAsync(id);
        //    if (Employee == null)
        //        return NotFound();
        //    return Page();
        //}

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    context.Employees.Update(Employee!);
        //    await context.SaveChangesAsync();
        //    return RedirectToPage("Index");
        //}
    }
}
