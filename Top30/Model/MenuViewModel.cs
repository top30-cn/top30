using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuViewModel
    {

        public MenuViewModel() { }
        public System.Guid ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string IsEnabled { get; set; }
        public System.DateTime AddTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string ParentCode { get; set; }
        public Nullable<int> MenuLevel { get; set; }
        public string BussType { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }



    }
}
