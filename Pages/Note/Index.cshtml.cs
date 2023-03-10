using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site_Ilian_DanRaul.Data;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Pages.Note
{
    public class IndexModel : PageModel
    {
        private readonly Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext _context;

        public IndexModel(Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext context)
        {
            _context = context;
        }

        public IList<Nota> Nota { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Nota != null)
            {
                Nota = await _context.Nota.ToListAsync();
            }
        }
    }
}
