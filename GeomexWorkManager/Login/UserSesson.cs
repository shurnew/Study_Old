using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomexWorkManager.Login
{
    class UserSesson
    {
        private string id;
        private string pw;
        private string name;
        private DateTime loginDate;
        private string autm;

        public UserSesson(string id, string pw, string name, DateTime loginDate, string autm)
        {
            this.id = id;
            this.pw = pw;
            this.name = name;
            this.loginDate = loginDate;
            this.autm = autm;
        }

        public string Id { get => id;}
        public string Pw { get => pw; }
        public string Name { get => name; }
        public string Autm { get => autm; }
        public DateTime LoginDate { get => loginDate; }
    }
}
