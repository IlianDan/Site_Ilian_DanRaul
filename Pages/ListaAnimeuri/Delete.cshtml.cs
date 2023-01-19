using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site_Ilian_DanRaul.Data;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Pages.ListaAnimeuri
{
    public class DeleteModel : PageModel
    {
        private readonly Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext _context;

        public DeleteModel(Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ListaAnimecs ListaAnimecs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ListaAnimecs == null)
            {
                return NotFound();
            }

            var listaanimecs = await _context.ListaAnimecs.FirstOrDefaultAsync(m => m.Id == id);

            if (listaanimecs == null)
            {
                return NotFound();
            }
            else 
            {
                ListaAnimecs = listaanimecs;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ListaAnimecs == null)
            {
                return NotFound();
            }
            var listaanimecs = await _context.ListaAnimecs.FindAsync(id);

            if (listaanimecs != null)
            {
                ListaAnimecs = listaanimecs;
                _context.ListaAnimecs.Remove(ListaAnimecs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
