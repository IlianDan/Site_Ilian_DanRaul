using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Site_Ilian_DanRaul.Data;
using Site_Ilian_DanRaul.Models;

namespace Site_Ilian_DanRaul.Pages.ListaAnimeuri
{
    public class CreateModel : PageModel
    {
        private readonly Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext _context;

        public CreateModel(Site_Ilian_DanRaul.Data.Site_Ilian_DanRaulContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["StatutID"] = new SelectList(_context.Set<Statut>(), "ID", "Stare");
            ViewData["TitluID"] = new SelectList(_context.Set<Titlu>(), "ID", "TitluAnime");
            ViewData["NotaID"] = new SelectList(_context.Set<Nota>(), "ID", "NotaAnime");
            return Page();
        }

        [BindProperty]
        public ListaAnimecs ListaAnimecs { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ListaAnimecs.Add(ListaAnimecs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
