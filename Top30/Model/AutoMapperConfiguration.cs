using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            
        }
        public  void LoadConfigMap()
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<MenuViewModel>();
            });
        }
    }
}
