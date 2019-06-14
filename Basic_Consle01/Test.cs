using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Consle01
{
    class Test
    {
        ArrayList list = new ArrayList();

        public void Num() {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            IEnumerator enumerator = intArray.GetEnumerator();
            while (enumerator.MoveNext()) {
                Console.Write(enumerator.Current+",");
            }
        }

        public void ItemAdd(string str) {
            int i;
            list.Add(str);
            for( i =0; i < list.Count ; i++) {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
