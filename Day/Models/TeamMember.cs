using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Profession { get; set; }
        [Required]
        [MaxLength(250)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(150)]
        public string TwitterUrl { get; set; }
        [Required]
        [MaxLength(150)]
        public string FacebookUrl { get; set; }
        [Required]
        [MaxLength(150)]
        public string InstagramUrl { get; set; }
        [Required]
        [MaxLength(150)]
        public string LinkedinUrl { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
