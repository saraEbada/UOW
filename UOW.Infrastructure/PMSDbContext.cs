using Microsoft.EntityFrameworkCore;
using UOW.Core.Entities;

namespace UOW.Infrastructure;

public class PMSDbContext : DbContext
{
	public PMSDbContext(DbContextOptions<PMSDbContext> options) : base(options)
	{

	}

	public virtual DbSet<Project> Projects { get; set; }
}