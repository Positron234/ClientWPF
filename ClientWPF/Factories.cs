using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ClientWPF
{
   
    internal class Factories { 
   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Factories(int id, string name, string discription)
        {
            Id = id;
            Name = name;
            Description = discription;
        }
        public Factories() { }

    }
}
