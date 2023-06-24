namespace Sat_Tue5_7.Models
{
    public class ArchivingModel
    {
        public int Id { get; set; }
        public string DocName { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocDate { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Notes { get; set; }
        public string ThumbnailPath { get; set; }
        public string SigniturePath { get; set; }
        public string FilePath { get; set; }

    }
}
