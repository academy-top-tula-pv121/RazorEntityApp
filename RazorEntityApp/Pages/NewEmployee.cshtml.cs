using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEntityApp.Models;

namespace RazorEntityApp.Pages
{
    public class NewEmployeeModel : PageModel
    {
        AppRazorContext context;
        
        [BindProperty]
        public Employee Employee { get; set; } = new();
        
        public NewEmployeeModel(AppRazorContext context)
        {
            this.context = context;
        }
        public IActionResult OnPost()
        {
            context.Employees.Add(Employee);
            context.SaveChanges();
            return RedirectToPage("Index");
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    context.Employees.Add(Employee);
        //    await context.SaveChangesAsync();
        //    return RedirectToPage("Index");
        //}
    }
}
