using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Migration.Models
{
	public class AppDB : DbContext
	{
		public DbSet<Phone> Phones { get; set; }
	}
}