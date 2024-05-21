using System.ComponentModel.DataAnnotations;

namespace Test2WebAPI.Models
{
    public class Report
    {
        [Display(Name = "��Ʀ~��")]
        public string? Month { get; set; }

        [Display(Name = "���q�N��")]
        public string? CompanyID { get; set; }

        [Display(Name = "�X����")]
        public string? CreateDate { get; set; }

        [Display(Name = "���q�W��")]
        public string? Name { get; set; }

        [Display(Name = "����禬")]
        public int? Revenue { get; set; }
    }
}