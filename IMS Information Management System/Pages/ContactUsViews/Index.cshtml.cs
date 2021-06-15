using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IMS.Data;
using IMS.Models;

namespace IMS.Pages.ContactUsViews
{
    public class IndexModel : PageModel
    {
        private readonly IMS.Data.IMSContext _context;

        public IndexModel(IMS.Data.IMSContext context)
        {
            _context = context;
        }

        public IList<ContactUs> ContactUs { get;set; }

        public async Task OnGetAsync()
        {
            ContactUs = await _context.ContactUs.ToListAsync();
        }
    }
}
