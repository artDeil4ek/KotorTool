using System;
using System.IO;
using System.Windows.Forms;
using KotorTool_2._0.MainForm;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Utils
{
    public class DirectoryUtils
    {
         public static void CleanDirectory(string dirname)
        {
            DirectoryInfo directoryInfo1 = new DirectoryInfo(dirname);
            int num = 0;
            try
            {
                FileSystemInfo[] directories = directoryInfo1.GetDirectories();
                Console.WriteLine("Number of directories: {0}", directories.Length);
                FileSystemInfo[] fileSystemInfoArray = directories;
                int index1 = 0;
                while (index1 < fileSystemInfoArray.Length)
                {
                    DirectoryInfo directoryInfo2 = (DirectoryInfo) fileSystemInfoArray[index1];
                    FileSystemInfo[] fileSystemInfos = directoryInfo2.GetFileSystemInfos();
                    int index2 = 0;
                    while (index2 < fileSystemInfos.Length)
                    {
                        FileSystemInfo fileSystemInfo = fileSystemInfos[index2];
                        switch (num)
                        {
                            case 0:
                                Cursor.Current = Cursors.PanNorth;
                                break;
                            case 1:
                                Cursor.Current = Cursors.PanNE;
                                break;
                            case 2:
                                Cursor.Current = Cursors.PanEast;
                                break;
                            case 3:
                                Cursor.Current = Cursors.PanSE;
                                break;
                            case 4:
                                Cursor.Current = Cursors.PanSouth;
                                break;
                            case 5:
                                Cursor.Current = Cursors.PanSW;
                                break;
                            case 6:
                                Cursor.Current = Cursors.PanWest;
                                break;
                            case 7:
                                Cursor.Current = Cursors.PanNW;
                                num = -1;
                                break;
                        }

                        ++num;
                        File.Delete(fileSystemInfo.FullName);
                        ++index2;
                    }

                    Directory.Delete(directoryInfo2.FullName);
                    ++index1;
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Console.WriteLine("The process failed: {0}", ex);
                ProjectData.ClearProjectError();
            }

            try
            {
                FileInfo[] files = directoryInfo1.GetFiles();
                int index = 0;
                while (index < files.Length)
                {
                    FileInfo fileInfo = files[index];
                    switch (num)
                    {
                        case 0:
                            Cursor.Current = Cursors.PanNorth;
                            break;
                        case 1:
                            Cursor.Current = Cursors.PanNE;
                            break;
                        case 2:
                            Cursor.Current = Cursors.PanEast;
                            break;
                        case 3:
                            Cursor.Current = Cursors.PanSE;
                            break;
                        case 4:
                            Cursor.Current = Cursors.PanSouth;
                            break;
                        case 5:
                            Cursor.Current = Cursors.PanSW;
                            break;
                        case 6:
                            Cursor.Current = Cursors.PanWest;
                            break;
                        case 7:
                            Cursor.Current = Cursors.PanNW;
                            num = -1;
                            break;
                    }

                    ++num;
                    File.Delete(fileInfo.FullName);
                    ++index;
                    
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Console.WriteLine("The process failed: {0}", ex);
                ProjectData.ClearProjectError();
            }
        }
        
         public static void EnsureWorkingDirectoryExists()
        {
            if (Directory.Exists(MainFormState.GRootPath + "working"))
                return;
            Directory.CreateDirectory(MainFormState.GRootPath + "working");
        }
        
    }
}