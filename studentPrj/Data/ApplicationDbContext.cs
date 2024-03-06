using System;
using Microsoft.EntityFrameworkCore;
using studentPrj.Models.Entities;

namespace studentPrj.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{
		}

		public DbSet<Student> Students { get; set; }
	}
}

