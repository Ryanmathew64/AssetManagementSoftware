using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AssetSystem.Models
{
    public class Info
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Device Type")]
        public string DeviceType { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [DisplayName("Asset Tag")]
        public string AssetTag { get; set; }
        [Required]
        [DisplayName("Assigned to")]
        public string AssignedTo { get; set; }
        [Required]
        [DisplayName("Assigned Date")]
        public DateTime AssignedDate { get; set; }
        [Required]
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public string Condition { get; set; }
    }
}
