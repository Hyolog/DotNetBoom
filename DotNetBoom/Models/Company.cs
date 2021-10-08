using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetBoom.Models
{
    public class Company
    {
        public int ID { get; set; }

        [Display(Name = "회사명")]
        public string Name { get; set; }

        [Display(Name = "설립일")]
        [DataType(DataType.Date)]
        public DateTime FoundationDate { get; set; }

        [Display(Name = "위치")]
        public string Location { get; set; }

        [Display(Name = "산업군")]
        public string BusinessGroup { get; set; }

        [Display(Name = "기업형태")]
        public string Type { get; set; }

        [Display(Name = "사원수")]
        public int NumberOfEmployees { get; set; }
    }
}
