using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PaymentId { get; set; }
        public string CardOwnerNmae { get; set; } = "";
        public string CardNumber { get; set; } = "";
        public string ExpirationDate { get; set; } = "";
        public string SecurityCode { get; set; } = "";

    }
}
