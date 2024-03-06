using System;
using Microsoft.EntityFrameworkCore;
namespace studentPrj.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{
		}
	}
}

