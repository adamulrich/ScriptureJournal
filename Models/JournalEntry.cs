
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ScriptureJournal.Models
{
    public class JournalEntry
    {

        public int Id { get; set; }

        [StringLength(2000, MinimumLength = 1)]
        [Required]
        [Display(Name = "Notes", Prompt ="Journal Entry here...")]
        public string Text { get; set; }

        [Required]
        [Display(Name = "Book")]
        public int BookId {get; set; }

        public Book? Book { get; set; }

        [Display(Name="Chapter(s)/Verse(s)", Prompt ="ex: 12:3-4")]
        public string? Chapter { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public string DateforDisplay {
            get {
                return this.DateCreated.ToString("dd MMM yy HH:mm");
            }
        }

    }
}
