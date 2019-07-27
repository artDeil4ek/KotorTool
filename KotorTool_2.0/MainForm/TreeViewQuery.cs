using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Options;
using KotorTool_2._0.Properties;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.MainForm
{
    public class TreeViewQuery
    {
        private const string ERF = "ERF";
        private readonly MainFormState _mainState;
        private readonly TreeView _treeView;



        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainState"></param>
        /// <param name="treeView"></param>
        public TreeViewQuery(MainFormState mainState, TreeView treeView)
        {
            _mainState = mainState;
            _treeView = treeView;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVersionIndex"></param>
        /// <param name="searchText"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="fileTypes"></param>
        /// <param name="resultsForm"></param>
        /// <param name="biffToSearchId"></param>
        public void SearchBifsForText(int kotorVersionIndex, string searchText, bool caseSensitive, Hashtable fileTypes, frmRefSearchResults resultsForm, int biffToSearchId)
        {
            Hashtable hashTableFileTypeIDs = new Hashtable();
            foreach (object fileType in fileTypes)
            {
                DictionaryEntry dictionaryEntry = (DictionaryEntry)(fileType ?? Activator.CreateInstance(typeof(DictionaryEntry)));
                hashTableFileTypeIDs.Add(ResourceIdentification.GetIdForRsrcType(StringType.FromObject(dictionaryEntry.Key)), RuntimeHelpers.GetObjectValue(dictionaryEntry.Value));
            }

            Regex oRegex = !caseSensitive ? new Regex(searchText, RegexOptions.IgnoreCase) : new Regex(searchText);
            ScanBifForText(kotorVersionIndex, biffToSearchId, hashTableFileTypeIDs, oRegex, resultsForm.lbMatches.Items);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVersionIndex"></param>
        /// <param name="searchText"></param>
        /// <param name="caseSensitive"></param>
        /// <param name="fileTypes"></param>
        /// <param name="resultsForm"></param>
        public void SearchAllModuleRimsForText(int kotorVersionIndex, string searchText, bool caseSensitive, Hashtable fileTypes, frmRefSearchResults resultsForm)
        {
            Cursor current = Cursor.Current;
            FileInfo[] files = new DirectoryInfo(ConfigOptions.Paths.KotorLocation(kotorVersionIndex) + "\\Modules").GetFiles("*.rim");
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
                        inData = binaryReader.ReadBytes((int)fileStream.Length);
                    }
                }

                RimParser rimParser = new RimParser(inData);
                int num2 = 0;
                int num3 = rimParser.EntryCount - 1;
                int index2 = num2;
                while (index2 <= num3)
                {
                    if (fileTypes.ContainsKey(((RimKeyEntry)rimParser.KeyEntryList[index2]).ResTypeStr))
                    {
                        string input = new ASCIIEncoding().GetString(rimParser.GetRimResource(index2));
                        if (regex.Match(input).Success) resultsForm.lbMatches.Items.Add(new KotorTreeNode((RimKeyEntry)rimParser.KeyEntryList[index2]) { FilePath = fileInfo.FullName, RimOrErfIndex = index2, KotorVerIndex = kotorVersionIndex });
                    }

                    ++index2;
                }

                ++index1;
            }

            Cursor.Current = current;
        }
        
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVersionIndex"></param>
        /// <param name="biffListIndex"></param>
        /// <param name="hashTableFileTypeIds"></param>
        /// <param name="oRegex"></param>
        /// <param name="objectCollection"></param>
        public void ScanBifForText(int kotorVersionIndex, int biffListIndex, Hashtable hashTableFileTypeIds, Regex oRegex, ListBox.ObjectCollection objectCollection)
        {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            string path = ConfigOptions.Paths.KotorLocation(kotorVersionIndex) + Resources.DoubleBackSlash + ((BiffEntry)_mainState.BiffEntries[kotorVersionIndex][biffListIndex]).FileName;
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            BiffArchive biffArchive = new BiffArchive(fileStream);

            foreach (KeyEntry ke in _mainState.BiffEntryListArray[kotorVersionIndex, biffListIndex])
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
                if (hashTableFileTypeIds.ContainsKey(ke.ResourceType))
                {
                    string input = asciiEncoding.GetString(biffArchive.GetBiffResource(ke.ResId - ke.ResId >> 20 << 20).Data);
                    if (oRegex.Match(input).Success)
                    {
                        KotorTreeNode kotorTreeNode = new KotorTreeNode(ke)
                        {
                            NodeVm = {FilePath = path}, Tag = Resources.BIFF_Res
                        };
                        kotorTreeNode.NodeVm.KotorVersionIndex = kotorVersionIndex;
                        objectCollection.Add(kotorTreeNode);
                    }
                }
            }

            fileStream.Close();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="erfFilePath"></param>
        /// <param name="ktn"></param>
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
                KotorTreeNode kotorTreeNode = new KotorTreeNode(keyEntry, erfFilePath)
                {
                    NodeVm = {ContainingFileType = ERF, RimOrErfIndex = num}
                };
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
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ktn"></param>
        /// <param name="directory"></param>
        public async void ScanForErFsAndBuildTree(KotorTreeNode ktn, string directory)
        {
            FileInfo[] files = await Task.Factory.StartNew(() => 
                new DirectoryInfo(ConfigOptions.Paths.KotorLocation(KotorTreeNode.NodeTreeRootIndex(_treeView, ktn)) + Resources.DoubleBackSlash + directory).GetFiles());

            int index = 0;
            while (index < files.Length)
            {
                FileInfo fileInfo = files[index];
                if (StringType.StrCmp(Strings.LCase(fileInfo.Extension), Resources._erf, false) == 0 | StringType.StrCmp(Strings.LCase(fileInfo.Extension), Resources._mod, false) == 0)
                {
                    KotorTreeNode kotorTreeNode1 = new KotorTreeNode(fileInfo.Name)
                    {
                        Tag = "ERF", NodeVm = {FilePath = fileInfo.DirectoryName}, Filename = fileInfo.Name
                    };
                    kotorTreeNode1.NodeVm.ContainingFileType = "ERF";
                    KotorTreeNode kotorTreeNode2 = new KotorTreeNode("") {Tag = "dummy"};
                    kotorTreeNode1.Nodes.Add(kotorTreeNode2);
                    ktn.Nodes.Add(kotorTreeNode1);
                }

                ++index;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="node"></param>
        public async void ScanForSavesAndBuildTree(string path, KotorTreeNode node)
        {


            DirectoryInfo[] directories = await Task.Factory.StartNew(() => new DirectoryInfo(path).GetDirectories());
            int index = 0;
            while (index < directories.Length)
            {
                DirectoryInfo directoryInfo = directories[index];

                KotorTreeNode kotorTreeNode1 = new KotorTreeNode(directoryInfo.Name)
                {
                    FilePath = directoryInfo.FullName
                };

                KotorTreeNode kotorTreeNode2 = new KotorTreeNode(Resources.GLOBALVARS_res)
                {
                    Tag = Resources.globalvar,
                    FullPath = kotorTreeNode1.NodeVm.FilePath,
                    Filename = Resources.GLOBALVARS_res
                };
                kotorTreeNode1.Nodes.Add(kotorTreeNode2);
                node.Nodes.Add(kotorTreeNode1);
                ++index;
            }


        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="rimFilePath"></param>
        /// <param name="ktn"></param>
        public void ReadRimEntries(TreeViewPresenter presenter, string rimFilePath, KotorTreeNode ktn)
        {
            int num = 0;
            FileStream fileStream = FStream.Generate(rimFilePath);
            BinaryReader binaryReader = FStream.GenerateBinReaderWithAscii(fileStream);

            RimParser rimParser = new RimParser(binaryReader.ReadBytes((int)fileStream.Length));
            binaryReader.Close();

            KotorTreeNode kotorTreeNode = new KotorTreeNode();

            foreach (RimKeyEntry keyEntry in rimParser.KeyEntryList)
            {
                KotorTreeNode node = new KotorTreeNode(keyEntry, rimFilePath)
                {
                    ContainingFileType = Resources.RIM,
                    RimOrErfIndex = num
                };

                ++num;
                presenter.OrganizeNodesByResType(kotorTreeNode, node);
                if (StringType.StrCmp(keyEntry.ResTypeStr, Resources._pth, false) == 0)
                {
                    Console.WriteLine(ktn.Filename + Resources.DoubleBackSlash + keyEntry.ResourceName + " " + keyEntry.Length);
                }
            }

            presenter.AttachNodeParentsSortedByDesc(ktn, kotorTreeNode);
        }
    }
}