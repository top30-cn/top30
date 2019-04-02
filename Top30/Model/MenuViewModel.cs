using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuViewModel : Model.IDbModelBase<T_Menu>
    {
        public MenuViewModel(T_Menu t)
        {
            Name = t.Name;
            Code = t.Code;
            IsEnabled = t.IsEnabled;
            AddTime = t.AddTime;
            UpdateTime = t.UpdateTime;
            ParentCode = t.ParentCode;
            MenuLevel = t.MenuLevel;
            BussType = t.BussType;
            Controller = t.Controller;
            Action = t.Action;
        }
        public MenuViewModel() { }

        public T_Menu getDBModel()
        {
            T_Menu outModel = new T_Menu();
            outModel.ID = ID;
            outModel.Name = Name;
            outModel.Code = Code;
            outModel.IsEnabled = IsEnabled;
            outModel.AddTime = AddTime;
            outModel.UpdateTime = UpdateTime;
            outModel.ParentCode = ParentCode;
            outModel.MenuLevel = MenuLevel;
            outModel.BussType = BussType;
            outModel.Controller = Controller;
            outModel.Action = Action;
            return outModel;
        }
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
