using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            LoadConfigMap();
        }
        public void LoadConfigMap()
        {
            CreateMap<MenuViewModel, T_Menu>();
            CreateMap<T_Menu, MenuViewModel>();
        }
    }

    public static class MapperConfiguration
    {
        public static void LoadConfigMap()
        {
            Mapper.Initialize(x => x.AddProfile<MapperProfile>());
        }
    }

}
