using System.ComponentModel.DataAnnotations;

namespace Test2WebAPI.Models
{
    public class Report
    {
        [Display(Name = "資料年月")]
        public string? Month { get; set; }

        [Display(Name = "公司代號")]
        public string? CompanyID { get; set; }

        [Display(Name = "出表日期")]
        public string? CreateDate { get; set; }

        [Display(Name = "公司名稱")]
        public string? Name { get; set; }

        [Display(Name = "當月營收")]
        public int? Revenue { get; set; }
    }
}