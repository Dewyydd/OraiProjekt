using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiProjekt
{
    internal class Data
    {
        public int id { get; set; }
        public string eloado { get; set; }
        public string cim { get; set; }
        public string megjelenes { get; set; }
        public string platform { get; set; }
        public int hossz { get; set; }
        public string thumbnailkep { get; set; }
        public string zenelink { get; set; }
        public Data(MySqlDataReader dataReader) 
        {
            id = Convert.ToInt32(dataReader["id"]);
            eloado = Convert.ToString(dataReader["marka"]);
            cim = Convert.ToString(dataReader["modell"]);
            megjelenes = Convert.ToString(dataReader["kivitel"]);
            platform = Convert.ToString(dataReader["evjarat"]);
            hossz = Convert.ToInt32(dataReader["teljesitmeny"]);
            thumbnailkep = Convert.ToString(dataReader["uzemanyag"]);
            zenelink = Convert.ToString(dataReader["hengerurtartalom"]);
        }
    }
}
