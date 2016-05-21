using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG253.FinalAsgn.Domain
{
    public class FacilityManager
    {
        private static FacilityManager _instance;

        private FacilityManager()
        {
            if (System.IO.File.Exists("wellpads.dat"))
            {
                WellPads = FileSerializer.Deserialize("wellpads.dat");
            }
            else
            {
                LoadTestData();
            }
        }
        
        public static FacilityManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FacilityManager();
            }

            return _instance;
        }

        private IList<IWellPad> WellPads { get; set; }

        public IList<IWellPad> WellPadsCollection
        {
            get
            {
                return WellPads.ToList();
            }
        }

        public void Add(WellPad wp)
        {
            WellPads.Add(wp);
        }

        public void Save()
        {
            FileSerializer.Serialize(WellPads, "wellpads.dat");
        }

        private void LoadTestData()
        {
            WellPads = new List<IWellPad>();

            var wPad = new WellPad();
            wPad.Id = 1;
            wPad.Province = "Alberta (AB)";
            wPad.Location = "Grande Prairie";

            var iWell = (InjectionWell)WellFactory.Instance.InitializeWell(SubWellTypes.InjectionWell);
            var pWell = (ProductionWell)WellFactory.Instance.InitializeWell(SubWellTypes.ProductionWell);

            wPad.Wells = new List<IWell>();
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(1));
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(2));
            wPad.Wells.Add(pWell.GenerateRandomProductionWell(1));

            WellPads.Add(wPad);

            wPad = new WellPad();
            wPad.Id = 2;
            wPad.Province = "British Columbia (BC)";
            wPad.Location = "Kelowna";

            wPad.Wells = new List<IWell>();
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(1));
            wPad.Wells.Add(pWell.GenerateRandomProductionWell(1));
            wPad.Wells.Add(pWell.GenerateRandomProductionWell(2));

            WellPads.Add(wPad);

            wPad = new WellPad();
            wPad.Id = 3;
            wPad.Province = "Saskatchewan (SK)";
            wPad.Location = "Saskatoon";

            wPad.Wells = new List<IWell>();
            wPad.Wells.Add(pWell.GenerateRandomProductionWell(1));
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(1));
            wPad.Wells.Add(pWell.GenerateRandomProductionWell(2));

            WellPads.Add(wPad);

            wPad = new WellPad();
            wPad.Id = 4;
            wPad.Province = "Alberta (AB)";
            wPad.Location = "Fort McMurray";

            wPad.Wells = new List<IWell>();
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(1));
            wPad.Wells.Add(pWell.GenerateRandomProductionWell(1));
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(2));

            WellPads.Add(wPad);

            wPad = new WellPad();
            wPad.Id = 5;
            wPad.Province = "British Columbia (BC)";
            wPad.Location = "Okanagan";

            wPad.Wells = new List<IWell>();
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(1));
            wPad.Wells.Add(iWell.GenerateRandomInjectionWell(2));
            wPad.Wells.Add(pWell.GenerateRandomProductionWell(1));

            WellPads.Add(wPad);
        }

    }
}
