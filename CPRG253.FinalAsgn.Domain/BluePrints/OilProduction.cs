using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    [Serializable]
    public class OilProduction : IOilProduction
    {
        private int _barrelsQuantity;

        public int BarrelsProduced
        {
            get
            {
                return _barrelsQuantity;
            }
            set
            {
                _barrelsQuantity = value;

                if (_barrelsQuantity > 50)
                {
                    if (BarrelsOverFifty == null) return;

                    BarrelsOverFifty.Invoke(this, new BarrelEventArgs { BarrelsQuantity = BarrelsProduced, ProducedOn = ProductionDate });
                }
            }
        }

        public DateTime ProductionDate { get; set; }

        public static List<IOilProduction> TestDataForProductionWellTestData()
        {
            List<IOilProduction> dummyProdData = new List<IOilProduction>();

            dummyProdData.Add(new OilProduction { BarrelsProduced = 12, ProductionDate = new DateTime(2012, 12, 1, 23, 2, 23) });
            dummyProdData.Add(new OilProduction { BarrelsProduced = 44, ProductionDate = new DateTime(2013, 9, 12, 13, 21, 36) });
            dummyProdData.Add(new OilProduction { BarrelsProduced = 26, ProductionDate = new DateTime(2011, 2, 27, 17, 47, 55) });
            dummyProdData.Add(new OilProduction { BarrelsProduced = 48, ProductionDate = new DateTime(2010, 7, 14, 3, 44, 22) });
            dummyProdData.Add(new OilProduction { BarrelsProduced = 51, ProductionDate = new DateTime(2009, 11, 12, 13, 17, 42) });

            return dummyProdData;
        }

        [field: NonSerialized]
        public event BarrelsOverFiftyDelegate BarrelsOverFifty;
    }
}
