using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    public class WellFactory : IWellFactory
    {
        private readonly static WellFactory _instance = new WellFactory();

        private WellFactory() { }

        public static WellFactory Instance
        {
            get
            {
                return _instance;
            }
        }

        public IWell InitializeWell(SubWellTypes wellType)
        {
            IWell well = null;
            switch (wellType)
            {
                case SubWellTypes.InjectionWell:
                    well = new InjectionWell();
                    break;
                case SubWellTypes.ProductionWell:
                    well = new ProductionWell();
                    break;
            }

            return well;
        }

        public IOilProduction InitializeDailyProductionLog()
        {
            return new OilProduction();
        }
    }
}
