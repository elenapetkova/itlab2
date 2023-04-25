using System.ComponentModel.DataAnnotations;

namespace LABTEST.Models
{
    public class EventModel
    {
        public int id { get; set; }
        public string ime { get; set; }
        [StringLength(30,MinimumLength =5)]
        public string lokacijon { get; set; }
    }
}