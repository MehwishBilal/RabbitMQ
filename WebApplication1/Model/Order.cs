
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderS.Model
{
    public class Order
    {
        public Guid OrderID { get; set; }
        public string Detail { get; set; }
        public int Price { get; set; }

    }
}
