using System;
using System.Collections.Generic;
using System.Linq;

namespace CPRG253.FinalAsgn.Domain
{
    public class IdValidator
    {
        public static void ValidateWellPadId(IList<IWellPad> wellPads, int id)
        {
            int wellPadExists = wellPads.Count(wp => wp.Id == id);

            if (0 < wellPadExists)
            {
                throw new Exception(id.ToString() + " is already used for an existing well pad record; please choose another ID.");
            }
        }

        public static void ValidateProductionWellId(IList<IWell> subWells, int id)
        {
            int prodWellExists = subWells.Count(pw => pw.Id == id && pw.GetType() == typeof(ProductionWell));

            if (0 < prodWellExists)
            {
                throw new Exception(id.ToString() + " is already used for an existing production well within this location; please choose another ID.");
            }
        }

        public static void ValidateInjectionWellId(IList<IWell> subWells, int id)
        {
            int injWellExists = subWells.Count(iw => iw.Id == id && iw.GetType() == typeof(InjectionWell));

            if (0 < injWellExists)
            {
                throw new Exception(id.ToString() + " is already used for an existing injection well within this location; please choose another ID.");
            }
        }
    }
}
