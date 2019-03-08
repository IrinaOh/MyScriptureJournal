using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public PaginatedList<Scripture> Scripture { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureNote { get; set; }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "Book";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            IQueryable<Scripture> scriptures = from s in _context.Scripture
                                              select s;
            IQueryable<string> bookQuery = from sc in _context.Scripture
                                           orderby sc.Book
                                           select sc.Book;

            switch (sortOrder)
            {

                case "Book":
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;

                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Date);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
            }



            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ScriptureNote))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureNote);
            }

            int pageSize = 5;
            Scripture = await PaginatedList<Scripture>.CreateAsync(
                scriptures.AsNoTracking(), pageIndex ?? 1, pageSize);

            Book = new SelectList(await bookQuery.Distinct().ToListAsync());
           /* Scripture = await scriptures.ToListAsync(); */
        } 
    }    
}
