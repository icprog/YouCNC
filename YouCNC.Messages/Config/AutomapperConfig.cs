using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using YouCNC.Words;

namespace YouCNC.Messages.Config
{
    public class AutomapperConfig : Profile
    {
        public void CreateMappings()
        {
            CreateMap<IPositionData, PositionData>().ReverseMap();
        }
    }
}
