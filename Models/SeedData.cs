using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScriptureJournal.Data;
using System;
using System.Linq;

namespace ScriptureJournal.Models
{
    public class SeedData
    {


            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new ScriptureJournalContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<ScriptureJournalContext>>()))
                {
                    // Look for any movies.
                    if (context.Book.Any())
                    {
                        return;   // DB has been seeded
                    }

                    context.Book.AddRange(
                        new Book { Name = "Genesis" },
                        new Book { Name = "Exodus" },
                        new Book { Name = "Leviticus" },
                        new Book { Name = "Numbers" },
                        new Book { Name = "Deuteronomy" },
                        new Book { Name = "Joshua" },
                        new Book { Name = "Judges" },
                        new Book { Name = "Ruth" },
                        new Book { Name = "1 Samuel" },
                        new Book { Name = "2 Samuel" },
                        new Book { Name = "1 Kings" },
                        new Book { Name = "2 Kings" },
                        new Book { Name = "1 Chronicles" },
                        new Book { Name = "2 Chronicles" },
                        new Book { Name = "Ezra" },
                        new Book { Name = "Nehemiah" },
                        new Book { Name = "Esther" },
                        new Book { Name = "Job" },
                        new Book { Name = "Psalms" },
                        new Book { Name = "Proverbs" },
                        new Book { Name = "Ecclesiastes" },
                        new Book { Name = "Song of Solomon" },
                        new Book { Name = "Isaiah" },
                        new Book { Name = "Jeremiah" },
                        new Book { Name = "Lamentations" },
                        new Book { Name = "Ezekiel" },
                        new Book { Name = "Daniel" },
                        new Book { Name = "Hosea" },
                        new Book { Name = "Joel" },
                        new Book { Name = "Amos" },
                        new Book { Name = "Obadiah" },
                        new Book { Name = "Jonah" },
                        new Book { Name = "Micah" },
                        new Book { Name = "Nahum" },
                        new Book { Name = "Habbakuk" },
                        new Book { Name = "Zephaniah" },
                        new Book { Name = "Haggai" },
                        new Book { Name = "Zechariah" },
                        new Book { Name = "Malachi" },

                        new Book { Name = "Matthew" },
                        new Book { Name = "Mark" },
                        new Book { Name = "Luke" },
                        new Book { Name = "John" },
                        new Book { Name = "Romans" },
                        new Book { Name = "1 Corinthians" },
                        new Book { Name = "2 Corinthians" },
                        new Book { Name = "Galatians" },
                        new Book { Name = "Ephesians" },
                        new Book { Name = "Philippians" },
                        new Book { Name = "Colossians" },
                        new Book { Name = "1 Thessalonians" },
                        new Book { Name = "2 Thessalonians" },
                        new Book { Name = "1 Timothy" },
                        new Book { Name = "2 Timothy" },
                        new Book { Name = "Titus" },
                        new Book { Name = "Philemon" },
                        new Book { Name = "Hebrews" },
                        new Book { Name = "James" },
                        new Book { Name = "1 Peter" },
                        new Book { Name = "2 Peter" },
                        new Book { Name = "1 John" },
                        new Book { Name = "2 John" },
                        new Book { Name = "3 John" },
                        new Book { Name = "Jude" },
                        new Book { Name = "Revelation" },

                        new Book { Name = "1 Nephi" },
                        new Book { Name = "2 Nephi" },
                        new Book { Name = "Jacob" },
                        new Book { Name = "Enos" },
                        new Book { Name = "Jarom" },
                        new Book { Name = "Omni" },
                        new Book { Name = "Words of Mormon" },
                        new Book { Name = "Mosiah" },
                        new Book { Name = "Alma" },
                        new Book { Name = "Helaman" },
                        new Book { Name = "3 Nephi" },
                        new Book { Name = "4 Nephi" },
                        new Book { Name = "Mormon" },
                        new Book { Name = "Ether" },
                        new Book { Name = "Moroni" },
                        
                        new Book { Name = "D&C" },

                        new Book { Name = "Abraham" },
                        new Book { Name = "Moses" },
                        new Book { Name = "Articles of Faith" },
                        new Book { Name = "Joseph Smith History" },
                        new Book { Name = "Joseph Smith Matthew" }





                    );
                    context.SaveChanges();
                }
            }
        }
    }



