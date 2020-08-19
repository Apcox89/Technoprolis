using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Inventory
    {
        //+needs type of Product or in this case Artifact-type data:
        public Artifact Details { get; set; }
        public int Quantity { get; set; }

        public Inventory(Artifact details, int qty)
        {
            Details = details;
            Quantity = qty;
        }
    }
}
