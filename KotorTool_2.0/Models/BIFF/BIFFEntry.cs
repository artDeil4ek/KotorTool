using System;
using System.IO;

namespace KotorTool_2._0.Models.BIFF
{
    public class BiffEntry
    {


        /// <summary>
        /// Needs to be readdressed as BiffEntry Properties
        /// </summary>
        public int Index;
        public int FileLength;
        public int Location;
        public string FileName;
        public string BiffName;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="fs"></param>
        /// <param name="offset"></param>
        public BiffEntry(int index, FileStream fs, int offset)
        {

            BinaryReader binaryReader = new BinaryReader(fs);

            Index = index;
            fs.Seek(offset, 0);
            FileLength = binaryReader.ReadInt32();

            var stringOffSet = binaryReader.ReadInt32();
            int stringLength = binaryReader.ReadInt16();


            Location = binaryReader.ReadInt16();
            fs.Seek(stringOffSet, 0);

            FileName = new string(binaryReader.ReadChars(stringLength - 1));

            if (FileName.StartsWith("\\\\"))
            {
                FileName = FileName.Substring(1);
            }

            FileName = ScrubFileName(FileName);
            BiffName = ScrubBiffName(BiffName);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="ms"></param>
        /// <param name="offset"></param>
        public BiffEntry(int index, MemoryStream ms, int offset)
        {

            BinaryReader binaryReader = new BinaryReader(ms);

            Index = index;
            ms.Seek(offset, 0);
            FileLength = binaryReader.ReadInt32();

            var stringoffset = binaryReader.ReadInt32();
            int stringlength = binaryReader.ReadInt16();

            Location = binaryReader.ReadInt16();
            ms.Seek(stringoffset, 0);

            FileName = new string(binaryReader.ReadChars(checked(stringlength - 1)));

            if (FileName.StartsWith("\\\\"))
            {
                FileName = FileName.Substring(1);
            }

            FileName = ScrubFileName(FileName);
            BiffName = ScrubBiffName(BiffName);
        }


        /// <summary>
        /// ------ Special set of file path characters for the file name -----
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public String ScrubFileName(String fileName)
        {
              return fileName.Replace("\\\\", "\\").Replace(":", "\\");
        }

        /// <summary>
        /// -----  Special set of file path characters for the biff name ------
        /// </summary>
        /// <param name="biffName"></param>
        /// <returns></returns>
        public String ScrubBiffName(String biffName)
        {
            return biffName.Replace("data\\", "").Replace(".bif", "");
        }
    }
}