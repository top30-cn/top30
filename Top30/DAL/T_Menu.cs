//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Menu
    {
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
