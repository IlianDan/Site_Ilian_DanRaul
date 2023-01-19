using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Site_Ilian_DanRaul.Data;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Pages.Statusuri
{
    public class EditModel : PageModel
    {
        private readonly Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext _context;

        public EditModel(Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Statut Status { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Status == null)
            {
                return NotFound();
            }

            var status =  await _context.Status.FirstOrDefaultAsync(m => m.ID == id);
            if (status == null)
            {
                return NotFound();
            }
            Status = status;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Status).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusExists(Status.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StatusExists(int id)
        {
          return _context.Status.Any(e => e.ID == id);
        }
    }
}
