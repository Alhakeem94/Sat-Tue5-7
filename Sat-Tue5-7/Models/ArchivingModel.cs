using System.ComponentModel.DataAnnotations;

namespace Sat_Tue5_7.Models
{
    public class ArchivingModel
    {
        public int Id { get; set; }
        [Required]
        public string DocName { get; set; }
        [Required]
        public string DocNumber { get; set; }
        [Required]
        public DateTime DocDate { get; set; }
        [Required]
        public string To { get; set; }
        [Required]
        public string From { get; set; }
        public string? Notes { get; set; }
        public string ThumbnailPath { get; set; }
        public string SigniturePath { get; set; }
        public string FilePath { get; set; }

    }
}
