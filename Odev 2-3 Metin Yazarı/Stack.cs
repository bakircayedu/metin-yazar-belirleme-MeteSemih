using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_2_3_Metin_Yazarı
{

    public class Stack<D> : IEnumerable
    {
        private D[] dt;
        public int size;

        public Stack(int size)
        {
            dt = new D[size];
        }

        public Stack() : this(9999)
        {
        }
        public D Pop()
        {
            if (size == 0)
            {
                MessageBox.Show("Stack boş");
            }

            return dt[--size];
        }
        public D Peak()
        {
            if (size == 0)
            {
                MessageBox.Show("Stack boş");
            }

            return dt[size - 1];
        }
       
        
        public void Push(D item)
        {
            if (size == dt.Length)
            {
                MessageBox.Show("Stack boş");
            }

            dt[size++] = item;
        }
      

        public IEnumerator<D> GetEnumerator()
        {
               throw new NotImplementedException();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}



   