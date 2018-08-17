using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class BitfinexFundings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid FundingId { get; set; }

        public long Id { get; set; }
        /// <summary>
        /// Millisecond time stamp
        /// </summary>
        public DateTime Mts { get; set; }

        /// <summary>
        /// How much was bought (positive) or sold (negative).
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Rate at which funding transaction occurred
        /// </summary>
        public double Rate { get; set; }

        /// <summary>
        /// Amount of time the funding transaction was for
        /// </summary>
        public double Period { get; set; }
        /// <summary>
        /// Target Symbol
        /// </summary>        
        public string Symbol { get; set; }

        public Guid? ReadingHighRatesId { get; set; }

        public virtual BitfinexReadingHighRates BitfinexReadingHighRates { get; set; }
    }
}
