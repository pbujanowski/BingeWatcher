using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BingeWatcher.Core.Models
{
    public class Movie
    {
        [Key]
        [Required]
        [DisplayName("ID")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Reżyseria")]
        public string Director { get; set; }

        [Required]
        [DisplayName("Scenariusz")]
        public string Writer { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Data premiery")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DisplayName("Gatunek")]
        public MovieGenre Genre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Data dodania")]
        public DateTime AddedDate { get; set; }

        [Required]
        [DisplayName("Dostawca")]
        public string Provider { get; set; }

        [Required]
        [DisplayName("Czy aktywny?")]
        public bool IsActive { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public string PosterSource { get; set; }

        public Movie()
        {
            AddedDate = DateTime.Now;
            IsActive = true;
        }
    }
}
