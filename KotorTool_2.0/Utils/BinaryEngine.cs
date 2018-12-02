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
        public FileStream Fs;
        public BinaryReader Br;
        public IBinaryEngine _binaryEngine;

        public BinaryEngine(string filePath)
        {
             Fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
             Br = new BinaryReader(Fs);
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
            _binaryEngine?.execute();
        }

        public void Dispose()
        {
            Fs?.Dispose();
            Br?.Dispose();
        }

        public static byte[] GetBytes(string filePath)
        {
            using (BinaryEngine binaryEngine = new BinaryEngine(filePath))
            {
               return binaryEngine.Br.ReadBytes((int) binaryEngine.Fs.Length);
            }
        }

        public static void ReadWithAction(string filePath, Action<FileStream, BinaryReader> action)
        {
            using (BinaryEngine binaryEngine = new BinaryEngine(filePath))
            {
                action.Invoke(binaryEngine.Fs, binaryEngine.Br);
            }
        }
    }
}