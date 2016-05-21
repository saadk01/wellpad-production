using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    public interface IProductionWell : IWell
    {
        List<IOilProduction> DailyProduction { get; set; }
    }
}
