using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientWPF
{
    class Collection<T> : IEnumerable<T>
    {
        public ObservableCollection<T> obj { get; set; }
        public void GetData(string json)
        {
            obj = JsonConvert.DeserializeObject<ObservableCollection<T>>(json);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)obj).GetEnumerator();
        }

        public string SaveData()
        {
            string json="";
            json= JsonConvert.SerializeObject(obj,Formatting.Indented);
            return json;
        }
        void DelData(T obj)
        {
            this.obj.Remove(obj);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)obj).GetEnumerator();
        }
    }
}
