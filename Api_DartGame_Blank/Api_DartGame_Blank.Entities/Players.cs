using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi_DartGame.Entities
{
    public class Players
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }

        [StringLength(50)]
        public string PlayerMail { get; set; }

        [StringLength(20)]
        public string PlayerPassword { get; set; }

        [StringLength(3)]
        public string? PlayerGame1 { get; set; }

        [StringLength(3)]
        public string? PlayerGame2 { get; set; }

        [StringLength(3)]
        public string? PlayerGame3 { get; set; }

        [StringLength(3)]
        public string? PlayerGame4 { get; set; }

        [StringLength(3)]
        public string? PlayerGame5 { get; set; }
    }
}
