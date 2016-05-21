using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    public delegate void BarrelsOverFiftyDelegate(object sender, BarrelEventArgs args);

    public class BarrelEventArgs : EventArgs
    {
        public int BarrelsQuantity { get; set; }
        public DateTime ProducedOn { get; set; }
    }
}
