using System;
using Microsoft.EntityFrameworkCore;

namespace IntroductionEnt
{
	public class AppliicationDbContext: DbContext
	{
		public AppliicationDbContext(DbContextOptions options): base (options)
		{ }
	}
}

