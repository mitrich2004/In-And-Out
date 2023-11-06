using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        public string Borrower { get; set; }

        public string Lander { get; set; }
    }
}
