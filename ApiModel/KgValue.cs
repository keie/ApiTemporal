using System.ComponentModel.DataAnnotations;

namespace ApiModel
{
    public class KgValue
    {
        [Key]
        public int id { get; set; }
        public float firstValue { get; set; }
        public float secondValue { get; set; }
        
        public byte boolDelete { get; set; }
    }
}