using System;
using System.Collections;
using System.ComponentModel;
using KotorTool_2._0.MainForm.Abstractions;
using KotorTool_2._0.ViewModels;
using Microsoft.Win32;

namespace KotorTool_2._0.MainForm
{


    public class MainFormState : IState
    {
        public IContainer components;
        public string GameRootPath;
        public ArrayList[,] BiffEntryListArray;
        public ArrayList[] BiffEntries;
        public KotorTreeNode LastClickedTreeViewNode;
        public KotorTreeNode SecondToLastClickedTreeViewNode;
        public byte[] Buffer;
        public string[] CmdArgs;
        public bool HasKotor1;
        public bool HasKotor2;
    }



}