using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_Immutable_Observable_Concurrent
{
    internal class Item
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public Item(int id, string name) { 
            Id = id;
            Name = name;
        }
    }
}
