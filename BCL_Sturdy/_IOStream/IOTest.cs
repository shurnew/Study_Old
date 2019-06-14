using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCL_Sturdy._IOStream
{
    class IOTest
    {
        public void Convert() {
            byte[] Boolbuf = BitConverter.GetBytes(false);
            Console.WriteLine(BitConverter.ToString(Boolbuf));
            byte[] intbuf = BitConverter.GetBytes(10);
            Console.WriteLine(BitConverter.ToString(intbuf));

            MemoryStream ms = new MemoryStream();
            ms.Write(Boolbuf,0,Boolbuf.Length);
            ms.Write(intbuf,0,intbuf.Length);

            ms.Position=0;

            byte[] outbyte = new byte[2];
            ms.Read(outbyte,0,outbyte.Length);
            bool boolResult = BitConverter.ToBoolean(outbyte,0);
            Console.WriteLine(boolResult);

            byte[] outbytes = new byte[4];
            ms.Read(outbytes, 0, outbytes.Length);
            int intResult = BitConverter.ToInt32(outbytes, 0);
            Console.WriteLine(intResult);

            byte[] strbuf = Encoding.UTF8.GetBytes("안녕하세요");

            ms.Write(strbuf,0,strbuf.Length);

            byte[] outbytes1 = new byte[1024];
            ms.Read(outbytes1, 0, outbytes1.Length);
            string strResult = BitConverter.ToString(outbytes1,0);
            Console.WriteLine(strResult);

            StreamWriter sw = new StreamWriter(ms,Encoding.UTF8);
            sw.WriteLine("\n하이");
            sw.Write(12345);
            sw.Flush();

            ms.Position = 0;
            StreamReader sr = new StreamReader(ms,Encoding.UTF8);
            Console.WriteLine(sr.ReadToEnd());

            MemoryStream ms1 = new MemoryStream();

            BinaryWriter bw = new BinaryWriter(ms1);
            bw.Write("안녕하세요"+Environment.NewLine);
            bw.Write("asd" + Environment.NewLine);
            bw.Write(1235);
            bw.Flush();

            ms1.Position = 0;

            BinaryReader reader = new BinaryReader(ms1);
            Console.WriteLine(reader.ReadString());
            Console.WriteLine(reader.ReadString());
            Console.WriteLine(reader.ReadInt32());

        }
        public void PrintWhat()
        {

        }
    }
    [Serializable]
    class Animal
    {
        private String name;
        private int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}",this.name,this.age);
        }
    }

    public class Animal1
    {
        public String name;
        public int age;

        public Animal1()
        {
        }

        public Animal1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}", this.name, this.age);
        }
    }
}
