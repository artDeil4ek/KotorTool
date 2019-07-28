using System;
using System.Diagnostics;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models
{
    public class Tga
    {
        private static void OpenTgaInExternalViewer(string filename, byte[] data)
        {
            string imageViewerLocation = ConfigOptions.Paths.ImageViewerLocation;
            if (!System.IO.File.Exists(imageViewerLocation))
            {
                Interaction.MsgBox("The image viewer you have configured was not found in the location you specified", MsgBoxStyle.Critical, "Helper app missing");
            }
            else
            {
                //EnsureWorkingDirectoryExists();
                ByteFunctions.WriteByteArray(MainAppState.GameRootPath + "working\\" + filename, data);
                try
                {
                    Process.Start(imageViewerLocation, "\"" + MainAppState.GameRootPath + "working\\" + filename + "\"");
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    if (StringType.StrCmp(ex.Message, "", false) != 0)
                    {
                        Interaction.MsgBox("Error launching image viewer\r\rIs it installed where you specified it to be?", MsgBoxStyle.OkOnly, null);
                    }

                    ProjectData.ClearProjectError();
                }
            }
        }
    }
}