﻿// Decompiled with JetBrains decompiler
// Type: KotorTool_2.ModItemTvNode
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System.Windows.Forms;

namespace KotorTool_2._0.ViewModels
{
  public class ModItemTvNode : TreeNode
  {
    public int ArrayIndex;
    public int ItemType;

    public ModItemTvNode()
    {
    }

    public ModItemTvNode(string text)
      : base(text)
    {
    }
  }
}
