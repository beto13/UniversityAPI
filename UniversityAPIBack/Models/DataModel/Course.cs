using System.ComponentModel.DataAnnotations;

namespace UniversityAPIBack.Models.DataModel
{
    public class Course : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        public string LongDescription { get; set; } = string.Empty;

        public string PublicObjetive { get; set; } = string.Empty;

        public string Objetives { get; set; } = string.Empty;

        public string Requirements { get; set; } = string.Empty;

        public Level Level { get; set; }

    }

    public enum Level
    {

        Basic = 1,
        Intermediate = 2,
        Advanced = 3
    }
}
