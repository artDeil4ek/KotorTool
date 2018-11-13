using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KotorTool_2._0.Forms;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MoreLinq;

namespace KotorTool_2._0.MainForm
{
    public class TreeViewQuery
    {
        private MainFormState _mainState;
        private TreeView _treeView;

        public TreeViewQuery(MainFormState mainState, TreeView treeView)
        {
            _mainState = mainState;
            _treeView = treeView;
        }
        
          public void SearchBifsForText(int kotorVerIndex, string searchText, bool caseSensitive, Hashtable fileTypes, frmRefSearchResults resultsForm, int bifToSearchId)
        {
            Hashtable htFileTypeIDs = new Hashtable();
            foreach (object fileType in fileTypes)
            {
                DictionaryEntry dictionaryEntry = (DictionaryEntry) (fileType ?? Activator.CreateInstance(typeof(DictionaryEntry)));
                htFileTypeIDs.Add(ResourceIdentification.GetIdForRsrcType(StringType.FromObject(dictionaryEntry.Key)), RuntimeHelpers.GetObjectValue(dictionaryEntry.Value));
            }

            Regex oRegex = !caseSensitive ? new Regex(searchText, RegexOptions.IgnoreCase) : new Regex(searchText);
            ScanBifForText(kotorVerIndex, bifToSearchId, htFileTypeIDs, oRegex, resultsForm.lbMatches.Items);
        }
        
        public void SearchAllModuleRimsForText(int kotorVerIndex, string searchText, bool caseSensitive, Hashtable fileTypes, frmRefSearchResults resultsForm)
        {
            Cursor current = Cursor.Current;
            FileInfo[] files = new DirectoryInfo(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\Modules").GetFiles("*.rim");
            Regex regex = !caseSensitive ? new Regex(searchText, RegexOptions.IgnoreCase) : new Regex(searchText.Trim());
            FileInfo[] fileInfoArray = files;
            int index1 = 0;
            while (index1 < fileInfoArray.Length)
            {
                FileInfo fileInfo = fileInfoArray[index1];
                int num1 = 0;
                switch (num1)
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
                        num1 = -1;
                        break;
                }

                ++num1;
                byte[] inData;
                using (FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII))
                    {
                        inData = binaryReader.ReadBytes((int) fileStream.Length);
                    }
                }

                ClsRim clsRim = new ClsRim(inData);
                int num2 = 0;
                int num3 = clsRim.EntryCount - 1;
                int index2 = num2;
                while (index2 <= num3)
                {
                    if (fileTypes.ContainsKey(((RimKeyEntry) clsRim.KeyEntryList[index2]).ResTypeStr))
                    {
                        string input = new ASCIIEncoding().GetString(clsRim.GetRimResource(index2));
                        if (regex.Match(input).Success) resultsForm.lbMatches.Items.Add(new KotorTreeNode((RimKeyEntry) clsRim.KeyEntryList[index2]) {FilePath = fileInfo.FullName, RiMorErFindex = index2, KotorVerIndex = kotorVerIndex});
                    }

                    ++index2;
                }

                ++index1;
            }

            Cursor.Current = current;
        }
        
        public void ScanBifForText(int kotorVerIndex, int biffListIndex, Hashtable htFileTypeIDs, Regex oRegex, ListBox.ObjectCollection lboc)
        {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            string path = ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\" + ((BiffEntry) _mainState._biffEntries[kotorVerIndex][biffListIndex]).Filename;
            FileStream fsin = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            BiffArchive biffArchive = new BiffArchive(fsin);

            foreach (KeyEntry ke in _mainState._biffEntryListArray[kotorVerIndex, biffListIndex])
            {
                int num = 0;
                switch (num)
                {
                    case 0:
                        Cursor.Current = Cursors.PanNorth;
                        break;
                    case 1:
                        Cursor.Current = Cursors.PanNW;
                        break;
                    case 2:
                        Cursor.Current = Cursors.PanWest;
                        break;
                    case 3:
                        Cursor.Current = Cursors.PanSW;
                        break;
                    case 4:
                        Cursor.Current = Cursors.PanSouth;
                        break;
                    case 5:
                        Cursor.Current = Cursors.PanSE;
                        break;
                    case 6:
                        Cursor.Current = Cursors.PanEast;
                        break;
                    case 7:
                        Cursor.Current = Cursors.PanNE;
                        num = -1;
                        break;
                }

                ++num;
                if (htFileTypeIDs.ContainsKey(ke.ResourceType))
                {
                    string input = asciiEncoding.GetString(biffArchive.GetBiffResource(ke.ResId - ke.ResId >> 20 << 20).Data);
                    if (oRegex.Match(input).Success)
                    {
                        KotorTreeNode kotorTreeNode = new KotorTreeNode(ke);
                        kotorTreeNode.FilePath = path;
                        kotorTreeNode.Tag = "BIFF_Res";
                        kotorTreeNode.KotorVerIndex = kotorVerIndex;
                        lboc.Add(kotorTreeNode);
                    }
                }
            }

            fsin.Close();
        }
       
        public void ReadErfEntries(string erfFilePath, KotorTreeNode ktn)
        {
            int charCode1 = 48;
            do
            {
                ktn.Nodes.Add(new KotorTreeNode(StringType.FromChar(Strings.Chr(charCode1))));
                ++charCode1;
            } while (charCode1 <= 57);

            int charCode2 = 65;
            do
            {
                ktn.Nodes.Add(new KotorTreeNode(StringType.FromChar(Strings.Chr(charCode2))));
                ++charCode2;
            } while (charCode2 <= 90);

            ClsErf clsErf = new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read));
            int num = 0;
            foreach (ErfKeyEntry keyEntry in clsErf.KeyEntryList)
            {
                KotorTreeNode kotorTreeNode = new KotorTreeNode(keyEntry, erfFilePath);
                kotorTreeNode.ContainingFileType = "ERF";
                kotorTreeNode.RiMorErFindex = num;
                foreach (KotorTreeNode node in ktn.Nodes)
                {
                    if (StringType.StrCmp(node.Text, StringType.FromChar(Strings.UCase(kotorTreeNode.Text[0])),
                            false) == 0)
                    {
                        node.Nodes.Add(kotorTreeNode);
                        break;
                    }
                }

                ++num;
            }

            int index = ktn.Nodes.Count - 1;
            while (index >= 1)
            {
                if (ktn.Nodes[index].Nodes.Count == 0)
                {
                    ktn.Nodes.RemoveAt(index);
                }

                index += -1;
            }
        }

        public void ScanForErFsAndBuildTree(KotorTreeNode ktn, string directory)
        {
            FileInfo[] files = new DirectoryInfo(ConfigOptions.Paths.KotorLocation(KotorTreeNode.NodeTreeRootIndex(_treeView,ktn)) + "\\" + directory).GetFiles();
            int index = 0;
            while (index < files.Length)
            {
                FileInfo fileInfo = files[index];
                if (StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".erf", false) == 0 | StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".mod", false) == 0)
                {
                    KotorTreeNode kotorTreeNode1 = new KotorTreeNode(fileInfo.Name);
                    kotorTreeNode1.Tag = "ERF";
                    kotorTreeNode1.FilePath = fileInfo.DirectoryName;
                    kotorTreeNode1.Filename = fileInfo.Name;
                    kotorTreeNode1.ContainingFileType = "ERF";
                    KotorTreeNode kotorTreeNode2 = new KotorTreeNode("");
                    kotorTreeNode2.Tag = "dummy";
                    kotorTreeNode1.Nodes.Add(kotorTreeNode2);
                    ktn.Nodes.Add(kotorTreeNode1);
                }

                ++index;
            }
        }

        public void ScanForSavesAndBuildTree(string path, KotorTreeNode node)
        {
            DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
            int index = 0;
            while (index < directories.Length)
            {
                DirectoryInfo directoryInfo = directories[index];
                KotorTreeNode kotorTreeNode1 = new KotorTreeNode(directoryInfo.Name);
                kotorTreeNode1.FilePath = directoryInfo.FullName;
                KotorTreeNode kotorTreeNode2 = new KotorTreeNode("GLOBALVARS.res");
                kotorTreeNode2.Tag = "globalvar";
                kotorTreeNode2.FilePath = kotorTreeNode1.FilePath;
                kotorTreeNode2.Filename = "GLOBALVARS.res";
                kotorTreeNode1.Nodes.Add(kotorTreeNode2);
                node.Nodes.Add(kotorTreeNode1);
                ++index;
            }
        }

        public void ReadRIMentries(TreeViewPresenter presenter, string rimFilePath, KotorTreeNode ktn)
        {
            int num = 0;
            FileStream fileStream = new FileStream(rimFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII);
            ClsRim clsRim = new ClsRim(binaryReader.ReadBytes((int) fileStream.Length));
            binaryReader.Close();
            KotorTreeNode kotorTreeNode = new KotorTreeNode();
           
            foreach (RimKeyEntry keyEntry in clsRim.KeyEntryList)
            {
                KotorTreeNode node = new KotorTreeNode(keyEntry, rimFilePath) {ContainingFileType = "RIM", RiMorErFindex = num};
                ++num;
                presenter.OrganizeNodesByResType(kotorTreeNode, node);
                if (StringType.StrCmp(keyEntry.ResTypeStr, "pth", false) == 0)
                {
                    Console.WriteLine(ktn.Filename + "\\" + keyEntry.ResourceName + " " + StringType.FromInteger(keyEntry.Length));
                }
            }

            presenter.AttachNodeParentsSortedByDesc(ktn, kotorTreeNode);
        }
    }
}