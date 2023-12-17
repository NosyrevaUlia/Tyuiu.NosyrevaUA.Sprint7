using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FirstLib
{
    
    public class FirstLibrary
    {
        public struct Zakaz
        {
            public string name;
            public string sername;
            public string fathername;
            public int phone;
            public DateTime data;
            public int zakazNumber;

            public Zakaz(string _name, string _sername, string _fathername, int _phone, DateTime _data, int _zakazNumber)
            {
                this.name = _name;
                this.sername = _sername;
                this.fathername = _fathername;
                this.phone = _phone;
                this.data = _data;
                this.zakazNumber = _zakazNumber;
            }
        }

        static void SaveToSCV(string[] args)
        {
            List<Zakaz> zakazs = new List<Zakaz>();

        }
    }
}
