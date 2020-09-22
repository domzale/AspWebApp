using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Domazet.Models
{
    public class Video
    {
        //[DisplayName("Ime filma")]
        [Key]
        //[Column(TypeName = "nvarchar(250)")]
        public int VideoSifra { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Obavezno polje")]
        [DisplayName ("Naziv Filma")]
        public string VideoNaziv{ get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Broj Kopija")]
        public int Ukupno { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Broj Zauzetih")]
        public int Zauzeto { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Broj Slobodnih")]
        public int Slobodno { get; set; }
    }
}
