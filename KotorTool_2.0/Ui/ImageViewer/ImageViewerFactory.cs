using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.ImageViewer
{



    public class ImageViewerFactory
    {


        /// <summary>
        /// ------ Populates Image Viewer with necessary data ------
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="data"></param>
        /// <param name="state"></param>
        public static void EditTpcResource(string filename, byte[] data, MainFormState state)
        {

            using (FrmImageViewer frmImageViewer = new FrmImageViewer())
            {
                if (File.Exists(state.GameRootPath + "tpc2tga.exe"))
                {
                    Interaction.MsgBox(
                        "tpc2tga is installed in the same directory as Kotor Tool, but is no longer needed",
                        MsgBoxStyle.Critical, "TPC2TGA not needed");
                }

                if (!File.Exists(ConfigOptions.Paths.ImageViewerLocation))
                {
                    Interaction.MsgBox(
                        "The image viewer you have configured was not found in the location you specified",
                        MsgBoxStyle.Critical, "Helper app missing");
                }
                else
                {
                    DirectoryUtils.EnsureWorkingDirectoryExists();
                    frmImageViewer.SetupTpcData(data, "foo");
                    frmImageViewer.DecodeImage();
                    frmImageViewer.WriteTgaFile(state.GameRootPath + "working\\" +
                                                Path.GetFileNameWithoutExtension(filename) + ".tga");
                    string imageViewerLocation = ConfigOptions.Paths.ImageViewerLocation;
                    try
                    {
                        Process.Start(imageViewerLocation,
                            "\"" + state.GameRootPath + "working\\" + Path.GetFileNameWithoutExtension(filename) + ".tga" +
                            "\"");
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        if (StringType.StrCmp(ex.Message, "", false) != 0)
                        {
                            Interaction.MsgBox(
                                "Error launching image viewer\r\rIs it installed where you specified it to be?");
                        }

                        ProjectData.ClearProjectError();
                    }
                }
            }

        }
    }




}
