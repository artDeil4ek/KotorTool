using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace KotorTool_2._0.AppConfiguration
{
    public class Injection
    {

        public static UnityContainer Container; 

        

        

        //var driver = container.Resolve<Driver>();
        //driver.RunCar();

        public Injection()
        {
            Container = new UnityContainer();

            //Container.RegisterType<ICar, Audi>();
            //Container.RegisterType<ICarKey, AudiKey>();


        }
    }

}
