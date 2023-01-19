using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Site_Ilian_DanRaul.Data;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Pages.ListaAnimeuri
{
    public class EditModel : PageModel
    {
        private readonly Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext _context;

        public EditModel(Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ListaAnimecs ListaAnimecs { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ListaAnimecs == null)
            {
                return NotFound();
            }

            var listaanimecs =  await _context.ListaAnimecs.FirstOrDefaultAsync(m => m.Id == id);
            if (listaanimecs == null)
            {
                return NotFound();
            }
            ListaAnimecs = listaanimecs;
            ViewData["StatutID"] = new SelectList(_context.Set<Statut>(), "ID", "Stare");
            ViewData["TitluID"] = new SelectList(_context.Set<Titlu>(), "ID", "TitluAnime");
            ViewData["NotaID"] = new SelectList(_context.Set<Nota>(), "ID", "NotaAnime");
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

            _context.Attach(ListaAnimecs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListaAnimecsExists(ListaAnimecs.Id))
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

        private bool ListaAnimecsExists(int id)
        {
          return _context.ListaAnimecs.Any(e => e.Id == id);
        }
    }
}
