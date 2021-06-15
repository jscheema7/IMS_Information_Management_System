using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IMS.Data;
using IMS.Models;

namespace IMS.Pages.ContactUsViews
{
    public class CreateModel : PageModel
    {
        private readonly IMS.Data.IMSContext _context;

        public CreateModel(IMS.Data.IMSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactUs ContactUs { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactUs.Add(ContactUs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
