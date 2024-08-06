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
        public decimal Subtotal { get; set; }

        /// <summary>
        /// This value is obtained from the user input
        /// </summary>
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// This value is calculated by multiplying the subtotal by the discount percent
        /// </summary>
        public decimal DiscountAmount => Subtotal * (DiscountPercent / 100);

        /// <summary>
        /// This value is calculated by subtracting the discount amount from the subtotal
        /// </summary>
        public decimal Total => Subtotal - DiscountAmount;

    }
}
