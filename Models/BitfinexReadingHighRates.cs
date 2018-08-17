using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class BitfinexReadingHighRates
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ReadingHighRatesId { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public string Symbol { get; set; }


    }
}
