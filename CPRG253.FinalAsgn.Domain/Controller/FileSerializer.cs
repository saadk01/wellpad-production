using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CPRG253.FinalAsgn.Domain
{
    public class FileSerializer
    {
        public static void Serialize(IList<IWellPad> wellPads, string path)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(path, FileMode.OpenOrCreate);
            formatter.Serialize(stream, wellPads);
            stream.Close();
        }

        public static IList<IWellPad> Deserialize(string path)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(path, FileMode.OpenOrCreate);
            var wellPads = (List<IWellPad>)formatter.Deserialize(stream);
            stream.Close();
            return wellPads;
        }
    }
}
