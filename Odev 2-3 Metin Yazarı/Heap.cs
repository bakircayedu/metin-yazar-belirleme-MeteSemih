using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_3_Metin_Yazarı
{
    public class Heap
    {
      
        void stack(int[] dizi, int j, int i)
        {
            int uzunluk = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < j && dizi[l] > dizi[uzunluk])
                uzunluk = l;


            if (r < j && dizi[r] > dizi[uzunluk])
                uzunluk = r;


            if (uzunluk != i)
            {
                int degistir = dizi[i];
                dizi[i] = dizi[uzunluk];
                dizi[uzunluk] = degistir;


                stack(dizi, j, uzunluk);
            }
        }
        public void variety(int[] dizi)

        {
            int j = dizi.Length;


            for (int i = j / 2 - 1; i >= 0; i--)
                stack(dizi, j, i);


            for (int i = j - 1; i > 0; i--)
            {

                int temp = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = temp;

                stack(dizi, i, 0);
            }
        }


     
    }
}


