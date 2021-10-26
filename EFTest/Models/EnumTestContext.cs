using System.ComponentModel.DataAnnotations.Schema;

namespace EFTest.Models
{
    public enum DepartmentNames
    {
        English,
        Math,
        Economics
    }

    [Table("EnumTestContext")]
    class EnumTestContext
    {
        public int DepartmentID { get; set; }
        public DepartmentNames Name { get; set; }
        public decimal Budget { get; set; }
    }
}
