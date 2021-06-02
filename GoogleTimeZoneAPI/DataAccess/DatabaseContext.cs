using GoogleTimeZoneAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccessLibrary.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions Options) : base(Options) { }
        public DbSet<RequestHistoryModel> RequestHistory { get; set; }
       

    }
}
