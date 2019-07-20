using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Abstractions
{
    public interface IFileWriter
    {
        void WriteToFile(Object content);
    }
}
