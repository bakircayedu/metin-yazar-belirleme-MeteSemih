using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2_3_Metin_Yazarı
{
    public class HashTable 
    {
        public Hashll[] hashTable;
        public HashTable(int size)
        {
            this.hashTable = new Hashll[size];

        }
        public void HashTableEkle(int anahtar, Sozcuk Sozcuk)
        {
            Hashll ekle = new Hashll();
            ekle.dt = Sozcuk;
            ekle.anahtar = Anahtar(Sozcuk.Sozcukno, Sozcuk.cumleSıra);

            int hash = (anahtar % 10);
            if (hashTable[hash] == null)
            {

                ekle.Next = null;
                hashTable[hash] = ekle;
            }
            else
            {

                Hashll temp = hashTable[hash];
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = ekle;
                ekle.Next = null;
            }
        }
        public Sozcuk SozcukArama(int anahtar)
        {
            int hash = (anahtar % 10);
            if (hashTable[hash] == null)
            {
                return null;
            }
            else
            {
                if (anahtar == hashTable[hash].anahtar)
                {
                    return hashTable[hash].dt;
                }
                else
                {
                    while (anahtar != hashTable[hash].anahtar)
                    {
                        if (hashTable[hash].Next != null)
                            hashTable[hash] = hashTable[hash].Next;
                        else
                            return null;
                    }
                    return hashTable[hash].dt;
                }
            }
        }
        public int Anahtar(int sozcukno, int cumleno)
        {
            string x = sozcukno.ToString();
            string y = cumleno.ToString();
            string stranahtar = x + y;
            int anahtar = Convert.ToInt32(stranahtar);
            return anahtar;

        }
    }
}

