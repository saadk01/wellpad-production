using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    [Serializable]
    public class ProductionWell : IProductionWell
    {
        public List<IOilProduction> DailyProduction { get; set; }
        public int Id { get; set; }
        public DateTime SpudDate { get; set; }

        public IWell GenerateRandomProductionWell(int id)
        {
            // Get random datetime: http://stackoverflow.com/a/194870
            Random random = new Random();
            DateTime start = new DateTime(2005, 1, 1);
            int range = (DateTime.Today - start).Days;
            DateTime randomDate = start.AddDays(random.Next(range));

            return new ProductionWell { Id = id, SpudDate = randomDate, DailyProduction = OilProduction.TestDataForProductionWellTestData() };
        }
    }
}
