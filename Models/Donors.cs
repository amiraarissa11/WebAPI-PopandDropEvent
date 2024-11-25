using System;
using System.ComponentModel.DataAnnotations;

namespace BookDonorsAPI.Models
{
    public class Donor
    {
        [Key]
        public int DonorID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(255)]
        public string BookTittle { get; set; }
    }
}