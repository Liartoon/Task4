using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Sale
    {
        public int Sale_Id { get; set; }
        public int Client_Id { get; set; }
        public int Manager_Id { get; set; }
        public int Product_Id { get; set; }

        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
