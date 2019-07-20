using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Persistence.Abstractions;

namespace Persistence
{
    public class PathsWriter : IFileWriter
    {


        public PathsWriter()
        {
           
        }


        public void WriteToFile(Object content)
        {

            MemoryStream ms = new MemoryStream();

            using (BsonWriter writer = new BsonWriter(ms))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, content);
            }

        }
    }
}
