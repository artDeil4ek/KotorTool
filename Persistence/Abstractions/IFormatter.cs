using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Types;

namespace Persistence.Abstractions
{
    public interface IFormatter
    {
        FileTypes Type { get; set; }
        IFormatter SetType(FileTypes fileType);
        IFormatter Format(Object content);
    }
}
