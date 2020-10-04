using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace WebApp1.Models
{
    public class dataModel
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Class { get; set; }

        [Display(Name = "Class Scheduled")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Field{ get; set; }

        [Required]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Fee { get; set; }
        
        [Required]
        [StringLength(60)]
        public string Teacher { get; set; }

        [Required]
        [StringLength(60)]
        public string Venue { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        public string Rating { get; set; }


    }

    public class AppDbContext : DbContext
    {
        public DbSet<dataModel> dataModels { get; set; }
    }
}