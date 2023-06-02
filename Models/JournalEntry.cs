
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
        public string Text { get; set; }

        [Required]
        public int BookId {get; set; }

        public Book? Book { get; set; }

        public string? Chapter { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

    }
}
