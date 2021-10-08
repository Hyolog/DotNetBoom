using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotNetBoom.Data;
using DotNetBoom.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList BusinessGroups { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CompanyBusinessGroup { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> businessGroupQuery = from c in _context.Company
                                           orderby c.BusinessGroup
                                           select c.BusinessGroup;

            var companies = from c in _context.Company
                            select c;

            if (!string.IsNullOrEmpty(SearchString))
                companies = companies.Where(d => d.Name.Contains(SearchString));

            if (!string.IsNullOrEmpty(CompanyBusinessGroup))
                companies = companies.Where(d => d.BusinessGroup.Contains(CompanyBusinessGroup));

            BusinessGroups = new SelectList(await businessGroupQuery.Distinct().ToListAsync());
            Company = await companies.ToListAsync(); 

            //var companies = from c in _context.Company
            //                select c;

            //if (!string.IsNullOrEmpty(SearchString))
            //    companies = companies.Where(d => d.Name.Contains(SearchString));

            //Company = await companies.ToListAsync();
        }
    }
}
