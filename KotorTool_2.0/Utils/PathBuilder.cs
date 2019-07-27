using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotorTool_2._0.Utils
{
    public class PathBuilder
    {

        private String _path;

        public PathBuilder()
        {

        }

        public static PathBuilder Build()
        {
            return new PathBuilder();
        }

        public PathBuilder Append(String line)
        {
            _path += line;
            return this;
        }

        public String Make()
        {
            return _path;
        }


}
}
