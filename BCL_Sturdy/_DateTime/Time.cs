using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BCL_Sturdy._DateTime
{
    class Time
    {

        Stopwatch st = new Stopwatch();

        public void PrintNow() {
            DateTime dt = DateTime.Now; 
            Console.WriteLine(dt);
        }

        public void PrintNow1()
        {
            DateTime dt1 = new DateTime(5,5,5);
            Console.WriteLine(dt1);
        }

        public void PrintGap(DateTime t1,DateTime t2)
        {
            Console.WriteLine(t1+"::"+t2);
            long gap = t1.Ticks - t2.Ticks;
            Console.WriteLine("ticks:"+gap);
            Console.WriteLine("MilliSecond:"+(gap/10000));
            Console.WriteLine("Second:" + (gap / 10000/1000));
        }
        public void RunStopWatch(int num)
        {
            st.Start();
            for (int i=0; i<num;)
            {

                if ((int)(st.ElapsedTicks / 10000 / 1000)==i)
                {
                    ++i;
                    Console.WriteLine((st.ElapsedTicks / 10000 / 1000) + "초");
                }
            }
            EndStopWatch();
        }
            public void EndStopWatch()
        {
            Console.WriteLine("ticks:" + st.ElapsedTicks);
            Console.WriteLine("MilliSecond:" + (st.ElapsedTicks / 10000));
            Console.WriteLine("Second:" + (st.ElapsedTicks / 10000 / 1000));
        }

        public void PrintEndOfYear()
        {
            DateTime EndDay = new DateTime(DateTime.Now.Year,12,31);
            DateTime NowDay = DateTime.Now;

            Console.WriteLine("오늘날짜:"+NowDay);
            TimeSpan gap = EndDay - NowDay;
            Console.WriteLine("올해 남은날짜:"+gap.TotalDays);
        }
    }
}
