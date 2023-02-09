using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace TheBugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Display(Name = "Company")]
        public int? CompanyId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Project Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTimeOffset StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTimeOffset EndDate { get; set; }

        [Display(Name = "Priority")]
        public int? ProjectPriorityId { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile ImageFormFile { get; set; }

        [Display(Name = "File Name")]
        public string ImageFileName { get; set; }

        public byte[] ImageFileData { get; set; }

        [Display(Name = "File Extension")]
        public string ImageContentType { get; set; }

        [Display(Name ="Archived")]
        public bool Archived { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual ProjectPriority ProjectPriority { get; set; }
        public virtual ICollection<BTUser> Members { get; set; } = new HashSet<BTUser>();
        public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();
    }
}
