using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Abstractions;
using Persistence.Types;

namespace Persistence.Builders
{
    public class FileBuilder : IFileBuilder
    {

        public string FileContent { get; set; }

        private FileTypes type { get; set; }

        private IFormatter Formatter { get; set; }
        private IFileWriter FileWriter { get; set; }

        public IFileBuilder Build()
        {
            return this;
        }

        public IFileBuilder SetFormatter(IFormatter iFormatter)
        {
            Formatter = iFormatter;
            return this;
        }

        public IFileBuilder SetFileWriter(IFileWriter iFileWriter)
        {
            FileWriter = iFileWriter;
            return this;
        }

        public IFileBuilder Write(Action onComplete)
        {
            Formatter
                .SetType(FileTypes.CSV)
                .Format(FileContent);

            FileWriter.WriteToFile();

            onComplete.Invoke();

            return this;
        }

    }
}
