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
        public string marka { get; set; }
        public string modell { get; set; }
        public string kivitel { get; set; }
        public int evjarat { get; set; }
        public int teljesitmeny { get; set; }
        public string uzemanyag { get; set; }
        public int hengerurtartalom { get; set; }
        public string sebessegvalto { get; set; }
        public string hajtas { get; set; }
        public Data(MySqlDataReader dataReader) 
        {
            id = Convert.ToInt32(dataReader["id"]);
            marka = Convert.ToString(dataReader["marka"]);
            modell = Convert.ToString(dataReader["modell"]);
            kivitel = Convert.ToString(dataReader["kivitel"]);
            evjarat = Convert.ToInt32(dataReader["evjarat"]);
            teljesitmeny = Convert.ToInt32(dataReader["teljesitmeny"]);
            uzemanyag = Convert.ToString(dataReader["uzemanyag"]);
            hengerurtartalom = Convert.ToInt32(dataReader["hengerurtartalom"]);
            sebessegvalto = Convert.ToString(dataReader["sebessegvalto"]);
            hajtas = Convert.ToString(dataReader["hajtas"]);
        }
    }
}
