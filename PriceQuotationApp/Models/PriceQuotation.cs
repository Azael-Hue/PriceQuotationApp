using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    /// <summary>
    /// This class represents a price quotation.
    /// </summary>
    public class PriceQuotation
    {
        /// <summary>
        /// This number uses the value the user inputs
        /// </summary>
        [Required(ErrorMessage = "Please enter a subtotal value.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive number.")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(0, 100, ErrorMessage = "Please enter a discount percent in between 0 and 100.")]
        /// <summary>
        /// This value is obtained from the user input
        /// </summary>
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// This value is calculated by multiplying the subtotal by the discount percent
        /// </summary>
        public decimal DiscountAmount
        {
            get
            {
                return Subtotal * (DiscountPercent / 100);
            }
        }

        /// <summary>
        /// This value is calculated by subtracting the discount amount from the subtotal
        /// </summary>
        public decimal Total
        {
            get
            {
                return Subtotal - DiscountAmount;
            }
        }

    }
}
