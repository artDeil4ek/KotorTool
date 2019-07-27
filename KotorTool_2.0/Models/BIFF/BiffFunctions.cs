using System;
using System.IO;
using CoreData.Biff;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models.BIFF
{
    static class BiffFunctions
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="biffPath"></param>
        /// <param name="outputPath"></param>
        /// <param name="resourceId"></param>
        public static void ExportBiffResource(string biffPath, string outputPath, int resourceId)
        {
            BiffVariableResourceEntry biffResource = new BiffArchive(FStream.Generate(biffPath)).GetBiffResource(resourceId);
            BinaryWriter binaryWriter = new BinaryWriter(FStream.Generate(outputPath));
            binaryWriter.Write(biffResource.Data);
            binaryWriter.Close();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVerIndex"></param>
        /// <param name="fileNameToExport"></param>
        /// <param name="fileResType"></param>
        /// <param name="outputPath"></param>
        public static void ExportBiffResource(int kotorVerIndex, string fileNameToExport, int fileResType, string outputPath)
        {
            int resIdForResRef = ChitinKey.KxChitinKey(kotorVerIndex).FindResourceIdForResourceRef(fileNameToExport, fileResType);
            if (resIdForResRef == -1) throw new NotSupportedException();
            ExportBiffResource(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\" + ChitinKey.KxChitinKey(kotorVerIndex).BiffList[resIdForResRef >> 20].Filename, outputPath, resIdForResRef - resIdForResRef >> 20 << 20);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="biffPath"></param>
        /// <param name="resourceId"></param>
        /// <returns></returns>
        public static BiffVariableResourceEntry GetBiffResource(string biffPath, int resourceId)
        {
            /*
             *check for memory leaks
             * 
             */
            BiffVariableResourceEntry biffResource = new BiffArchive(FStream.Generate(biffPath)).GetBiffResource(resourceId);
            return biffResource;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVerIndex"></param>
        /// <param name="fileName"></param>
        /// <param name="fileResType"></param>
        /// <returns></returns>
        public static byte[] GetBiffResourceData(int kotorVerIndex, string fileName, int fileResType)
        {
            ClsChitinKeyProvider clsChitinKey = ChitinKey.KxChitinKey(kotorVerIndex);
            int resIdForResRef = clsChitinKey.FindResourceIdForResourceRef(fileName, fileResType);
            if (resIdForResRef == -1) return null;
            FileStream fsin = new FileStream(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\" + clsChitinKey.BiffList[resIdForResRef >> 20].Filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            byte[] data = new BiffArchive(fsin).GetBiffResource(checked(resIdForResRef - resIdForResRef >> 20 << 20)).Data;
            fsin.Close();

            return data;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVerIndex"></param>
        /// <param name="fileName"></param>
        /// <param name="fileResType"></param>
        /// <returns></returns>
        public static byte[] GetTemplateBifResourceData(int kotorVerIndex, string fileName, int fileResType)
        {
            int resIdForResRef = ChitinKey.KxChitinKey(kotorVerIndex).FindResourceIdForResourceRef(fileName, fileResType);
            if (resIdForResRef == -1) return null;
            return KxTemplatesBif(kotorVerIndex).GetBiffResource(checked(resIdForResRef - resIdForResRef >> 20 << 20)).Data;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="biffPath"></param>
        /// <returns></returns>
        public static BiffVariableResourceEntryInfo[] GetBiffResourceInfoList(string biffPath)
        {
            using (FileStream fileStream = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    binaryReader.ReadChars(8);
                    int num = binaryReader.ReadInt32();
                    binaryReader.ReadInt32();
                    int entryIndex = binaryReader.ReadInt32();
                    BiffVariableResourceEntryInfo[] array = new BiffVariableResourceEntryInfo[num];
                    int arg540 = 0;
                    int entryOffset = num - 1;
                    for (int i = arg540; i <= entryOffset; i++)
                    {

                        fileStream.Seek(entryIndex + 16 * i, 0);

                        array[i] = new BiffVariableResourceEntryInfo
                        {
                            ResourceId = binaryReader.ReadInt32(),
                            Offset = binaryReader.ReadInt32(),
                            FileSize = binaryReader.ReadInt32(),
                            ResourceType = binaryReader.ReadInt32()
                        };
                    }

                    return array;
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BiffArchive K1TemplatesBif()
        {
            // @"E:\Steam\steamapps\common\swkotor\"
            return Constants.Gk1TemplatesBif ?? (Constants.Gk1TemplatesBif = new BiffArchive(FStream.Generate(@"E:\Steam\steamapps\common\swkotor\" + "\\data\\templates.bif")));
        }



       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BiffArchive K2TemplatesBif()
        {
            //@"E:\Steam\steamapps\common\Knights of the Old Republic II\"
            return Constants.Gk2TemplatesBif ?? (Constants.Gk2TemplatesBif = new BiffArchive(FStream.Generate(@"E:\Steam\steamapps\common\Knights of the Old Republic II\" + "\\data\\Templates.bif")));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVerIndex"></param>
        /// <returns></returns>
        private static BiffArchive KxTemplatesBif(int kotorVerIndex)
        {
            return kotorVerIndex == 0 ? K1TemplatesBif() : K2TemplatesBif();
        }
    }
}