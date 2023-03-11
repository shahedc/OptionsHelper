using System.ComponentModel.DataAnnotations;

namespace OptionsHelperApp.Models
{
    public class OptionContract
    {
        [Key]
        public int Id { get; set; }
        public string ContractInfo { get; set; }
        public string Symbol { get; set; }
        public int Quantity { get; set; }
        public string AccountOwner { get; set; }
        public string OptionType { get; set; }
        public double OpenAmount { get; set; }
        public DateOnly DateOpened { get; set; }
        public double ClosedAmount { get; set; }
        public DateOnly ExpirationDate { get; set; }
        public DateOnly ClosingDate { get; set; }
        public double ProfitLoss { get; set; }
        public double ProfitPercentage { get; set; }
        public int DaysToExpiration { get; set; }

        public bool Assigned { get; set; }
        public double StrikePrice { get; set; }
    }
}
