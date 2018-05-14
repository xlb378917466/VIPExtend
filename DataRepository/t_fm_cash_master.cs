namespace DataRepository
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fm_cash_master
    {
        [Key]
        [StringLength(18)]
        public string sheet_no { get; set; }

        [Required]
        [StringLength(10)]
        public string account_no { get; set; }

        [StringLength(10)]
        public string d_account_no { get; set; }

        [Required]
        [StringLength(2)]
        public string trans_no { get; set; }

        [StringLength(6)]
        public string branch_no { get; set; }

        [StringLength(18)]
        public string voucher_no { get; set; }

        [StringLength(6)]
        public string order_man { get; set; }

        [StringLength(3)]
        public string pay_way { get; set; }

        [StringLength(3)]
        public string coin_no { get; set; }

        [StringLength(1)]
        public string approve_flag { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sheet_amount { get; set; }

        [StringLength(6)]
        public string oper_id { get; set; }

        public DateTime? oper_date { get; set; }

        [StringLength(6)]
        public string confirm_man { get; set; }

        public DateTime? work_date { get; set; }

        [StringLength(100)]
        public string memo { get; set; }

        [StringLength(100)]
        public string memo2 { get; set; }

        [StringLength(1)]
        public string com_flag { get; set; }

        [StringLength(6)]
        public string oper_branch { get; set; }

        public int? print_num { get; set; }
    }
}