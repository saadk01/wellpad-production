using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    [Serializable]
    public class WellPad : IWellPad
    {
        public int Id { get; set; }

        public string Location { get; set; }

        public string Province { get; set; }

        public List<IWell> Wells { get; set; }
    }
}
