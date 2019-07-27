using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Abstractions;
using Persistence.Types;

namespace Persistence.Formatting
{
    public class JsonFormatter : IFormatter
    {

        public FileTypes Type { get; set; }



        public IFormatter SetType(FileTypes fileType)
        {
            throw new NotImplementedException();
        }



        public IFormatter Format(object content)
        {
            throw new NotImplementedException();
        }


      
    }
}
