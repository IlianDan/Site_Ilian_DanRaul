using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site_Ilian_DanRaul.Data;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Pages.Titluri
{
    public class DetailsModel : PageModel
    {
        private readonly Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext _context;

        public DetailsModel(Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext context)
        {
            _context = context;
        }

      public Titlu Titlu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Titlu == null)
            {
                return NotFound();
            }

            var titlu = await _context.Titlu.FirstOrDefaultAsync(m => m.ID == id);
            if (titlu == null)
            {
                return NotFound();
            }
            else 
            {
                Titlu = titlu;
            }
            return Page();
        }
    }
}
