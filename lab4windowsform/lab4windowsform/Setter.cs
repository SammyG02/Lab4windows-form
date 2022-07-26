using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4windowsform
{
    internal class Setter
    {
        static private List<Setter> list = new List<Setter>();
        public int Number { get; set; }
        public string Date { get; set; }
        public int Inv_Num { get; set; }
        public string Obj_name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public Boolean isAvailable { get; set; }
        public void save()
        {
            list.Add(this);
        }
        static public List<Setter> GetAllProducts()
        {
            return list;
        }
    }
}
