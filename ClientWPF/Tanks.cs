using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWPF
{
  
    internal class Tanks
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int volume { get; set; }
        public int maxVolume { get; set; }
        public int unitid {get; set; }
        public Tanks(int id,string name,string despription,int volume,int maxvolume,int unitid)
        {
            this.id = id;
            this.name = name;
            this.description = despription;
            this.volume = volume;
            this.maxVolume = maxvolume;
            this.unitid = unitid;
        }
    }
}
