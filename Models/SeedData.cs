using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any scriptures.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "Nephi",
                        Chapter = 2,
                        Verse = 15,
                        Note = "Sunday school",
                        Date = DateTime.Parse("1998-3-5"),

                    },

                     new Scripture
                     {
                         Book = "Lehi",
                         Chapter = 7,
                         Verse = 10,
                         Note = "Good",
                         Date = DateTime.Parse("2019-2-12"),

                     },

                     new Scripture
                     {
                         Book = "Amon",
                         Chapter = 37,
                         Verse = 10,
                         Note = "Good",
                         Date = DateTime.Parse("2019-2-12"),

                     },

                     new Scripture
                     {
                         Book = "Lehi",
                         Chapter = 7,
                         Verse = 10,
                         Note = "Good",
                         Date = DateTime.Parse("2018-2-12"),

                     },

                     new Scripture
                     {
                         Book = "Lehi",
                         Chapter = 7,
                         Verse = 10,
                         Note = "Good",
                         Date = DateTime.Parse("1989-2-12"),

                     },

                     new Scripture
                     {
                         Book = "Lehi",
                         Chapter = 7,
                         Verse = 10,
                         Note = "Good",
                         Date = DateTime.Parse("2019-3-12"),

                     },

                     new Scripture
                     {
                         Book = "Jacob",
                         Chapter = 1,
                         Verse = 19,
                         Note = "Something",
                         Date = DateTime.Parse("2001-5-19"),

                     }
                );
                context.SaveChanges();
            }
        }
    }
}
