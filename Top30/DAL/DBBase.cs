using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBBase
    {
        private static TOPDBEntities _TOPDBEntities;
        private DBBase() { }
        public static TOPDBEntities SingDBContext
        {
            get
            {
                if (_TOPDBEntities == null)
                {
                    _TOPDBEntities = new TOPDBEntities();
                }
                return _TOPDBEntities;
            }
        }
    }
}
