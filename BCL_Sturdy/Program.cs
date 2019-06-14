using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Collections;

namespace BCL_Sturdy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region dateTime
            /*
            _DateTime.Time t = new _DateTime.Time();
            t.PrintNow();
            t.PrintNow1();
            DateTime t1=DateTime.Now;
            DateTime t2 = new DateTime(18, 9, 13);
            t.PrintGap(t1,t2);
           
            t.PrintEndOfYear();

            t.RunStopWatch(10);
            */
            #endregion

            #region String
            /*
            _String.StringSturdy s1 = new _String.StringSturdy();
            s1.PrintString("abcd;      ADV");
            s1.EmailCheck("vmon07@naver.com");
            s1.EmailCheck2("vmon07@naver.com");
            */
            #endregion

            #region ConvertBit/IOStream

          
            _IOStream.IOTest iOTest = new _IOStream.IOTest();
            iOTest.Convert();

            _IOStream.Animal animal = new _IOStream.Animal("사자", 5);
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, animal);

            ms.Position = 0;


            _IOStream.Animal clone = bf.Deserialize(ms) as _IOStream.Animal;
            Console.WriteLine(clone);

            _IOStream.Animal1 animal2 = new _IOStream.Animal1("고양이", 5);
            MemoryStream ms1 = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(_IOStream.Animal1));
            xs.Serialize(ms1, animal2);

            ms1.Position = 0;

            //_IOStream.Animal1 clone1 = xs.Deserialize(ms1) as _IOStream.Animal1;
            //Console.WriteLine(clone1);

            byte[] buf = ms1.ToArray();

            Console.WriteLine(Encoding.UTF8.GetString(buf));

            using (FileStream fs= new FileStream("test.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
                sw.WriteLine("안녕재디얌");
                sw.WriteLine("하이재디");
                sw.Flush();
            }

           


            #endregion

            #region Collection

            //ArrayList list = new ArrayList();
            //list.Add("11");
            //list.Add("22");
            //list.Add("23");
            //list.Add(1);
            //list.Add("21");
            //list.Remove(1);
            //list.Sort();
            //foreach (Object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}
            //Hashtable ht = new Hashtable();
            //ht.Add("key", "값");
            //ht.Add("1", "no.1");
            //Console.WriteLine(ht["1"]);
            //ht.Remove("key");
            //ht["1"] = "num1";
            //Console.WriteLine(ht["1"]);

            //SortedList s1 = new SortedList();
            //s1.Add(8, 12);
            //s1.Add(1, 88);
            //s1.Add(2, 88);

            //foreach (int key in s1.GetKeyList())
            //{
            //    Console.WriteLine(string.Format("{0},{1}", key, s1[key]));
            //}

            //Stack st = new Stack();
            //st.Push(1);
            //st.Push(2);
            //st.Push(3);

            //Console.WriteLine(st.Pop());

            //Queue qq = new Queue();

            //qq.Enqueue(1);
            //qq.Enqueue(2);
            //qq.Enqueue(3);
            //Console.WriteLine(qq.Dequeue());

            #endregion

            Console.ReadLine();
        }
    }
}
