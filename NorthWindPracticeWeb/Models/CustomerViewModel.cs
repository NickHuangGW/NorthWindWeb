using System.ComponentModel.DataAnnotations;

namespace NorthWindPracticeWeb.Models
{
    public class CustomerViewModel
    {
        [StringLength(5)]
        [Display(Name = "客戶ID")]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "客戶名稱")]
        public string CompanyName { get; set; }

        [StringLength(30)]
        [Display(Name = "聯絡人名稱")]
        public string ContactName { get; set; }

        [StringLength(30)]
        [Display(Name = "聯絡人職稱")]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        [Display(Name = "地址")]
        public string Address { get; set; }

        [StringLength(15)]
        [Display(Name = "所在城市")]
        public string City { get; set; }

        [StringLength(15)]
        [Display(Name = "所在區域")]
        public string Region { get; set; }

        [StringLength(10)]
        [Display(Name = "郵遞區號")]
        public string PostalCode { get; set; }

        [StringLength(15)]
        [Display(Name = "國家")]
        public string Country { get; set; }

        [StringLength(24)]
        [Display(Name = "電話")]
        public string Phone { get; set; }

        [StringLength(24)]
        [Display(Name = "傳真號碼")]
        public string Fax { get; set; }


    }
}