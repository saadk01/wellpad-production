using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CPRG253.FinalAsgn.Domain
{
    public class FileHandler
    {
        public static List<string> GetProvinces()
        {
            var provinces = new List<String>();

            var provArray = File.ReadAllLines("ca_provinces.csv");

            foreach (string prov in provArray)
            {
                provinces.Add(prov);
            }

            return provinces;
        }
    }
}
