using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site_Ilian_DanRaul.Data;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Pages.Statusuri
{
    public class DeleteModel : PageModel
    {
        private readonly Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext _context;

        public DeleteModel(Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Statut Status { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Status == null)
            {
                return NotFound();
            }

            var status = await _context.Status.FirstOrDefaultAsync(m => m.ID == id);

            if (status == null)
            {
                return NotFound();
            }
            else 
            {
                Status = status;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Status == null)
            {
                return NotFound();
            }
            var status = await _context.Status.FindAsync(id);

            if (status != null)
            {
                Status = status;
                _context.Status.Remove(Status);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
