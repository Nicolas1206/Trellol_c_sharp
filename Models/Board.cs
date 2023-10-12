using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Trellol.Data;

namespace Trellol.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<List> Lists { get; set; } = new List<List>();
    }
}
