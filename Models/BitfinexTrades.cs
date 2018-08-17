using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Models
{
    public class BitfinexTrades
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TradeId { get; set; }

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
        /// Price at which the trade was executed
        /// </summary>
        public double Price { get; set; }

        public string Pair { get; set; }

        public Guid? ReadingHighRatesId { get; set; }

        public virtual BitfinexReadingHighRates BitfinexReadingHighRates { get; set; }

    }
}
