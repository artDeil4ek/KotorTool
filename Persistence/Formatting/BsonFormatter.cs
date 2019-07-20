using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Persistence.Abstractions;
using Persistence.Types;

namespace Persistence.Formatting
{
    class BsonFormatter : IFormatter
    {
        public FileTypes Type { get; set; }

        public IFormatter SetType(FileTypes fileType)
        {
            Type = fileType;
            return this;
        }

        public IFormatter Format(object content)
        {
            MemoryStream ms = new MemoryStream();
            using (BsonWriter writer = new BsonWriter(ms))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, content);
            }
            return this;
        }

        public IFormatter SetType(int fileType)
        {


            return this;
        }

        public IFormatter Format(String content)
        {

            

            return this;
        }

    }
}
