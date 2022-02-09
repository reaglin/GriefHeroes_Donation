using System.ComponentModel.DataAnnotations;

namespace GriefHeroes_Donation.Models
{
    public class DonationMaterials
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; } = String.Empty;
        public string InfoURL { get; set; } = String.Empty;
        public string Availability { get; set; } = String.Empty;

    }
}
