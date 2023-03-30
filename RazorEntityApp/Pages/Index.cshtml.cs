using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEntityApp.Models;

namespace RazorEntityApp.Pages
{
    public class IndexModel : PageModel
    {
        AppRazorContext context;
        public List<Employee> Employees { get; set; } = new();
        public IndexModel(AppRazorContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            Employees = context.Employees.ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            Employee employee = context.Employees.Find(id);

            if(employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }

            return RedirectToPage();
        }

        //public async Task<IActionResult> OnPostDeleteAsync(int id)
        //{
        //    Employee employee = await context.Employees.FindAsync(id);

        //    if (employee != null)
        //    {
        //        context.Employees.Remove(employee);
        //        await context.SaveChangesAsync();
        //    }

        //    return RedirectToPage();
        //}
    }
}