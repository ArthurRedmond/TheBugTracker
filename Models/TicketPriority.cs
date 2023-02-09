using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TheBugTracker.Models
{
    public class TicketPriority
    {
        public int Id { get; set; }

        [Display(Name = "Priority Name")]
        public string Name { get; set; }
    }
}
