using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotorTool_2._0.Utils.Builders
{
    public class PathBuilder
    {

        private String _path;

        public PathBuilder()
        {

        }

        public PathBuilder(String path)
        {
            _path = path;
        }


        public static PathBuilder Build(String path)
        {
            return new PathBuilder(path);
        }

        public static PathBuilder Build()
        {
            return new PathBuilder();
        }

        public PathBuilder Add(String appendation)
        {
            if (string.IsNullOrEmpty(appendation))
            {
                throw new ArgumentException("message", nameof(appendation));
            }

            _path += appendation;
             return this;
        }

        public String Set()
        {
            return _path;
        }
    }
}
