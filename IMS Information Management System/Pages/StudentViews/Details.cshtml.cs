using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IMS.Data;
using IMS.Models;

namespace IMS.Pages.StudentViews
{
    public class DetailsModel : PageModel
    {
        private readonly IMS.Data.IMSContext _context;

        public DetailsModel(IMS.Data.IMSContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
