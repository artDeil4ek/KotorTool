// Decompiled with JetBrains decompiler
// Type: KotorTool_2.RepeatButton
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.Windows.Forms;

namespace KotorTool_2._0.Forms
{
  public class RepeatButton : Button
  {
    public Timer Timer;

    public int Interval
    {
      get => Timer.Interval;
      set => Timer.Interval = value;
    }

    public RepeatButton()
    {
      MouseUp += RepeatButton_MouseUp;
      MouseDown += RepeatButton_MouseDown;
      Timer = new Timer();
      Timer.Tick += OnTimer;
      Timer.Interval = 200;
      Timer.Enabled = false;
    }

    private void OnTimer(object sender, EventArgs e)
    {
      OnClick(EventArgs.Empty);
    }

    private void RepeatButton_MouseDown(object sender, MouseEventArgs e)
    {
      Timer.Enabled = true;
    }

    private void RepeatButton_MouseUp(object sender, MouseEventArgs e)
    {
      Timer.Enabled = false;
    }
  }
}
