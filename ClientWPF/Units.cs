using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ClientWPF
{
    internal class Units
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int FactoryID { get; set; }
        public Units(int id, string name, string description, int factoryID)
        {
            Id = id;
            Name = name;
            Description = description;
            FactoryID = factoryID;
        }
    }
}
