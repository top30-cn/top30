using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IDbModelBase<out outT>
    {
        outT getDBModel();
    }

    public class BaseModelExpand<ViewModel, DBEntiryT> : Profile
    {
        //public static List<Profile> Profiles = new List<Profile>();
        protected IMappingExpression<ViewModel, DBEntiryT> ViewModelToDateMap;
        protected IMappingExpression<DBEntiryT, ViewModel> DataToViewModelMap;
        public BaseModelExpand()
        {
            ViewModelToDateMap = CreateMap<ViewModel, DBEntiryT>();
            DataToViewModelMap = CreateMap<DBEntiryT, ViewModel>();
            Mapper.Initialize(m => m.AddProfile(this));
        }

        public virtual void ChangeMapping()
        {

        }


    }

}
}
