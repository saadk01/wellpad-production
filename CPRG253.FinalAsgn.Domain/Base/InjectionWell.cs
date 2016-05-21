using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    [Serializable]
    public class InjectionWell : IInjectionWell
    {
        public int Id { get; set; }

        public DateTime SpudDate { get; set; }

        public WaterType WaterType { get; set; }

        public IWell GenerateRandomInjectionWell(int id)
        {
            // Get random water type: http://stackoverflow.com/a/3132151
            Array values = Enum.GetValues(typeof(WaterType));
            Random random = new Random();
            WaterType randomType = (WaterType)values.GetValue(random.Next(values.Length));

            // Get random datetime: http://stackoverflow.com/a/194870
            DateTime start = new DateTime(2005, 1, 1);
            int range = (DateTime.Today - start).Days;
            DateTime randomDate = start.AddDays(random.Next(range));

            return new InjectionWell { Id = id, SpudDate = randomDate, WaterType = randomType };
        }
    }
}
