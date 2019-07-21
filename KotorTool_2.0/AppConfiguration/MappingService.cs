using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using KotorTool_2._0.Data;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.AppConfiguration
{
    public class MappingService
    {

        public static IMapper IMapper;


        public MappingService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<NodeVm, NodeData>();
            });

            IMapper = config.CreateMapper();
        }
        
    }
}
