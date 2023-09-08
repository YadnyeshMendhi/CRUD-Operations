using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace Crud_Operations.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [MaxLength(12)]
        [Display(Name ="Account Number")]
        [Column(TypeName="nvarchar(12)")]
        public string AccountNumber { get; set; }

     
        [Display(Name = "Benificiary Name")]
        [Column(TypeName ="nvarchar(100)")]
        public string BenificiaryName { get; set; }

        [Display(Name = "Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [MaxLength(11)]
        [Display(Name = "SWIFT Code")]
        [Column(TypeName ="nvarchar(11)")]
        public string SWIFTCode { get; set; }

       
        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
