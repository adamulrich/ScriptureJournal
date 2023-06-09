using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScriptureJournal.Data;
using ScriptureJournal.Models;

namespace ScriptureJournal.Pages.Journal
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal.Data.ScriptureJournalContext _context;

        public IndexModel(ScriptureJournal.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList BooksList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string BookName { get; set; }
        public int BookId;

        [BindProperty(SupportsGet = true)]
        public string SortType { get; set; }

        public List<SelectListItem> SortTypeList = new List<SelectListItem>() {
            new SelectListItem
            {
                Text = "By Date", Value = "1"
            },
            new SelectListItem
            {
                Text = "By Book", Value = "2"
            }
         };
        

        public async Task OnGetAsync()
        {

            IQueryable<string> bookQuery = from b in _context.Book
                                                orderby b.Id
                                                select b.Name ;

            BooksList = new SelectList(await bookQuery.ToListAsync());

            var journalEntries = from je in _context.JournalEntry
                select je;

            if (!string.IsNullOrEmpty(SearchString))
            {
                journalEntries = journalEntries.Where(je => je.Text.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(BookName))
            {
                var book = from b in _context.Book where b.Name == BookName
                select b.Id;
                BookId = book.FirstOrDefault();
                journalEntries = journalEntries.Where(je => je.BookId == BookId);
                
            }
            if (SortType == "2")
            {
                journalEntries = journalEntries.OrderBy(je => je.Book.Name);
            } else
            {
                journalEntries = journalEntries.OrderBy(je => je.DateCreated);
            }
            
            
            if (_context.JournalEntry != null)
            {
                JournalEntry = await journalEntries
            .Include(j => j.Book).ToListAsync();
            }
            
            
        }
    }
}
