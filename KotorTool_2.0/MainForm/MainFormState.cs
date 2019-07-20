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
        public string GRootPath;
        public ArrayList[,] BiffEntryListArray;
        public ArrayList[] BiffEntries;
        public KotorTreeNode LastClickedTvNode;
        public KotorTreeNode SecondToLastClickedTvNode;
        public byte[] Buffer;
        public string[] CmdArgs;
        public bool HasK1;
        public bool HasK2;
    }



}