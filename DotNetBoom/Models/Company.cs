using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetBoom.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime FoundationDate { get; set; }
        public string Location { get; set; }
        public string BusinessGroup { get; set; }
        public string Type { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}
