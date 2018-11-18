using System;
using System.IO;

namespace KotorTool_2._0.Utils
{

    public interface IBinaryEngine
    {
        void execute();
    }
    
    public class BinaryEngine : IDisposable
    {
        private FileStream fs;
        private BinaryReader br;
        private IBinaryEngine _binaryEngine;

        public BinaryEngine(string filePath)
        {
             fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
             br = new BinaryReader(fs);
        }

        public BinaryEngine SetExecution(IBinaryEngine binaryEngine)
        {
            _binaryEngine = binaryEngine;
            return this;
        }

        public void Execute(IBinaryEngine binaryEngine)
        {
            _binaryEngine = binaryEngine;
            _binaryEngine.execute();
        }
        
        public void Execute()
        {
            _binaryEngine.execute();
        }

        public void Dispose()
        {
            fs?.Dispose();
            br?.Dispose();
        }
    }
}