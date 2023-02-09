using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class TicketStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status Name")]
        public string Name { get; set; }
    }
}
