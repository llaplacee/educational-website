using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pelika.DataLayer.Entities.Wallet
{
    public class Wallet
    {
        public Wallet()
        {
            
        }
        [Key]
        public int WaletId { get; set; }

        [Display(Name = "نو تراکنش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int TypeId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserId { get; set; }

        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Amount { get; set; }

        [Display(Name = "شرح")]
        [MaxLength(500, ErrorMessage = "{0}نمیتواند بیشتر از {1} کازکتر باشد ")]
        public string Description { get; set; }

        [Display(Name = "تایید شده")]
        public bool IsPay { get; set; }
        [Display(Name = "تاریخ و ساعت")]
        public DateTime CreateDate { get; set; }

        public virtual User.User User { get; set; }
        public virtual WalletType WalletType { get; set; }

    }
}
