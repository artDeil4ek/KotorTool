﻿using System;
using System.IO;

using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models.BIFF
{
    static class BiffFunctions
    {
        public static void ExportBiffResource(string biffPath, string outputPath, int resourceId)
        {
            FileStream fsin = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            BiffVarRsrcEntry biffResource = new BiffArchive(fsin).GetBiffResource(resourceId);
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create));
            binaryWriter.Write(biffResource.Data);
            binaryWriter.Close();
            fsin.Close();
        }

        public static void ExportBiffResource(int kotorVerIndex, string fileNameToExport, int fileResType, string outputPath)
        {
            int resIdForResRef = ChitinKey.KxChitinKey(kotorVerIndex).FindResIdForResRef(fileNameToExport, fileResType);
            if (resIdForResRef == -1) throw new NotSupportedException();
            ExportBiffResource(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\" + ChitinKey.KxChitinKey(kotorVerIndex).BiffList[resIdForResRef >> 20].Filename, outputPath, resIdForResRef - resIdForResRef >> 20 << 20);
        }

        public static BiffVarRsrcEntry GetBiffResource(string biffPath, int resourceId)
        {
            FileStream fsin = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            BiffVarRsrcEntry biffResource = new BiffArchive(fsin).GetBiffResource(resourceId);
            fsin.Close();
            return biffResource;
        }

        public static byte[] GetBiffResourceData(int kotorVerIndex, string fileName, int fileResType)
        {
            Options.ConfigOptions settings = UserSettings.GetSettings();
            ClsChitinKey clsChitinKey = ChitinKey.KxChitinKey(kotorVerIndex);
            int resIdForResRef = clsChitinKey.FindResIdForResRef(fileName, fileResType);

            if (resIdForResRef == -1) return null;

            FileStream fsin = new FileStream(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\" + clsChitinKey.BiffList[resIdForResRef >> 20].Filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            byte[] data = new BiffArchive(fsin).GetBiffResource(checked(resIdForResRef - resIdForResRef >> 20 << 20)).Data;
            fsin.Close();

            return data;
        }

        public static byte[] GetTemplateBifResourceData(int kotorVerIndex, string fileName, int fileResType)
        {
            int resIdForResRef = ChitinKey.KxChitinKey(kotorVerIndex).FindResIdForResRef(fileName, fileResType);
            if (resIdForResRef == -1) return null;
            return KxTemplatesBif(kotorVerIndex).GetBiffResource(checked(resIdForResRef - resIdForResRef >> 20 << 20)).Data;
        }

        public static BiffVarRsrcEntryInfo[] GetBiffResourceInfoList(string biffPath)
        {
            using (FileStream fileStream = new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    binaryReader.ReadChars(8);
                    int num = binaryReader.ReadInt32();
                    binaryReader.ReadInt32();
                    int num2 = binaryReader.ReadInt32();
                    BiffVarRsrcEntryInfo[] array = new BiffVarRsrcEntryInfo[num];
                    int arg540 = 0;
                    checked
                    {
                        int num3 = num - 1;
                        for (int i = arg540; i <= num3; i++)
                        {
                            fileStream.Seek(checked(num2 + 16 * i), 0);
                            array[i] = new BiffVarRsrcEntryInfo(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
                        }

                        return array;
                    }
                }
            }
        }

        public static BiffArchive K1TemplatesBif()
        {
           // @"E:\Steam\steamapps\common\swkotor\"
           // return Constants.Gk1TemplatesBif ?? (Constants.Gk1TemplatesBif = new BiffArchive(new FileStream(UserSettings.GetSettings().KotorLocation(0) + "\\data\\templates.bif", FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)));
            return Constants.Gk1TemplatesBif ?? (Constants.Gk1TemplatesBif = new BiffArchive(new FileStream(@"E:\Steam\steamapps\common\swkotor\" + "\\data\\templates.bif", FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)));
        }

        public static BiffArchive K2TemplatesBif()
        {
            //@"E:\Steam\steamapps\common\Knights of the Old Republic II\"
           // return Constants.Gk2TemplatesBif ?? (Constants.Gk2TemplatesBif = new BiffArchive(new FileStream(UserSettings.GetSettings().KotorLocation(1) + "\\data\\Templates.bif", FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)));
            return Constants.Gk2TemplatesBif ?? (Constants.Gk2TemplatesBif = new BiffArchive(new FileStream(@"E:\Steam\steamapps\common\Knights of the Old Republic II\" + "\\data\\Templates.bif", FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000)));
        }

        private static BiffArchive KxTemplatesBif(int kotorVerIndex)
        {
            return kotorVerIndex == 0 ? K1TemplatesBif() : K2TemplatesBif();
        }
    }
}