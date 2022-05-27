using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_3_Metin_Yazarı
{
   public class HeapNode
    {
        public Sozcuk  Sozcuk;
        public HeapNode sol;
        public HeapNode sag;
        public HeapNode()
        {
            this.Sozcuk = Sozcuk;
            sag = null;
            sol = null;
        }


    }
}
