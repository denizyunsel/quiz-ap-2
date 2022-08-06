﻿using Microsoft.EntityFrameworkCore;

namespace QuizAPI.models
{
    public class QuizDbContext:DbContext
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options):base(options)
        { }

        public DbSet<Question>Questions{ get; set; }
        public DbSet<Participant> Participant { get; set; }

       
    }
}
