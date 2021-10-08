using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetBoom.Data;
using DotNetBoom.Models;

namespace DotNetBoom.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly DotNetBoom.Data.DotNetBoomContext _context;

        public IndexModel(DotNetBoom.Data.DotNetBoomContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}
