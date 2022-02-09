#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GriefHeroes_Donation.Models;

namespace GriefHeroes_Donation.Data
{
    public class GriefHeroes_DonationContext : DbContext
    {
        public GriefHeroes_DonationContext (DbContextOptions<GriefHeroes_DonationContext> options)
            : base(options)
        {
        }

        public DbSet<GriefHeroes_Donation.Models.DonationMaterials> DonationMaterials { get; set; }
    }
}
