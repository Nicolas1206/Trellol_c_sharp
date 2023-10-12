using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trellol.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();

    }
}

