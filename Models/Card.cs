using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trellol.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public int ListId { get; set; }
        public List List { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
