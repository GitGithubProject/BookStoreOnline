using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context =
            services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "The Everyday Life of an Algorithm",

                    Description = "Through investigating the everyday life " +
                    "of the algorithm, the book opens a conversation with existing social" +
                    " science research that tends to focus on the power and opacity of algorithms.",
                    Category = "Algorithms",

                    Price = 275
                },
                new Product
                {
                    Name = "Fundamental Data Structures",

                    Description = "Description This book covers most of commonly used data structures " +
                    "in computer science: abstract data types; Sequences; Dictionaries; Sets; " +
                    "Priority queues; Successors and neighbors; Integer and string searching, etc.",

                    Category = "Algorithms",

                    Price = 48.95m
                },
                new Product
                {
                    Name = "Algorithms",
                    Description = "An accessible introduction to algorithms, " +
                    "explaining not just what " +
                    "they are but how they work, with examples from a wide range" +
                    " of application areas.",
                    Category = "Algorithms",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Essential Algorithms",
                    Description = "This book written to provide clear and concise " +
                    "explanation of topics for programmers both starting to learn the Algorithms " +
                    "as well as those diving in more complex topics.",
                    Category = "Algorithms",
                    Price = 34.95m
                },
                new Product
                {
                    Name = "Data-Oriented Design:",
                    Description = "This book is a practical guide " +
                    "for serious game developers",
                    Category = "Database",
                    Price = 79
                },
                new Product
                {
                    Name = "Database Fundamentals",
                    Description = "his book discusses database" +
                    " logical and physical design, and introduces you to the SQL language.",
                    Category = "Database",
                    Price = 16
                },
                new Product
                {
                    Name = " Database Design, 2nd Edition",
                    Description = "This book covers database systems and database design concepts.",
                    Category = "Database",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "How to Design Programs",
                    Description = "Unlike other introductory books, " +
                    "it focuses on the program design process, " +
                    "presenting program design guidelines",
                    Category = "Programming",
                    Price = 75
                },
                new Product
                {
                    Name = "Elements of Programming",
                    Description = "The book shows that algorithms implemented in a " +
                    "real programming language, such as C++",
                    Category = "Programming",
                    Price = 120
                }
                ,
                new Product
                {
                    Name = "PureBasic - A Beginner's Guide To Computer Programming",
                    Description = "This book provides a quick introduction to the PureBasic" +
                    " programming language.",
                    Category = "Programming",
                    Price = 120
                }
                ,
                new Product
                {
                    Name = "How to Design Classes",
                    Description = "The authors put classes and the design of" +
                    " classes into the center of their approach. ",
                    Category = "Programming",
                    Price = 120
                }
                );
                context.SaveChanges();

            }
        }
    }
}
