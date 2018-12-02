// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmParent
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.Options;

namespace KotorTool_2._0.Ui.Forms
{
  public class frmParent : Form
  {
    private IContainer components;
    public ConfigOptions CurrentSettings;
    protected int KotorVersionIndex;
    protected string m_EditingFilePath;
    protected string m_defaultTitleText;

    public string EditingFilePath
    {
      get => m_EditingFilePath;
      set
      {
        m_EditingFilePath = value;
        Text = m_defaultTitleText;
        if (KotorVersionIndex == 0)
          Text = Text + "I - ";
        else
          Text = Text + "II - ";
        Text = Text + Path.GetFileName(value);
      }
    }

    public frmParent()
    {
      InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
        components?.Dispose();
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ResourceManager resourceManager = new ResourceManager(typeof (frmParent));
      Size size = new Size(5, 13);
      AutoScaleBaseSize = size;
      size = new Size(292, 273);
      ClientSize = size;
    //  this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = "frmParent";
      Text = "frmParent";
    }

    protected void WriteConsoleMsg(object msg)
    {
      Console.WriteLine(RuntimeHelpers.GetObjectValue(msg));
    }

    public void PositionWindow(string FormClassName)
    {
     /* CurrentSettings = UserSettings.GetSettings();
     // Point point1 = CurrentSettings.get_WindowLoc(FormClassName);
      if (point1.X < 0 | point1.Y < 0)
      {
        point1.X = 10;
        point1.Y = 10;
       // CurrentSettings.set_WindowLoc(FormClassName, point1);
        UserSettings.SaveSettings(CurrentSettings);
      }
      ((Control) this).Location = point1;
     // Size size1 = CurrentSettings.get_WindowSize(FormClassName);
      if (size1.IsEmpty)
        return;
      Point point2;
      int height1 = 0;
      Size size2;
      if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
      {
        Point point3 = new Point(10,10);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Point local1 = @point3;
        point2 = ((Control) this).Location;
        int x = point2.X;
        int top = Screen.PrimaryScreen.WorkingArea.Top;
        // ISSUE: explicit reference operation
        local1 = new Point(x, top);
        ((Control) this).Location = point3;
        height1 = Screen.PrimaryScreen.WorkingArea.Height;
        Size size3 = new Size(40,40);
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Size local2 = @size3;
        size2 = Size;
        int width = size2.Width;
        int height2 = height1;
        // ISSUE: explicit reference operation
        local2 = new Size(width, height2);
        Size = size3;
      }
      int width1 = 0;
      if (size1.Width > Screen.PrimaryScreen.WorkingArea.Width)
      {
        point2 = new Point(Screen.PrimaryScreen.WorkingArea.Left, ((Control) this).Location.Y);
        ((Control) this).Location = point2;
        width1 = Screen.PrimaryScreen.WorkingArea.Width;
        size2 = new Size(width1, Size.Height);
        Size = size2;
      }
      if (!(width1 == 0 & height1 == 0))
        return;
      //Size = ConfigOptions.WindowSettings.GetWindowSize(FormClassName);
    }

    public void SaveSettings(string FormClassName)
    {
      CurrentSettings = UserSettings.GetSettings();
      if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Minimized)
        WindowState = FormWindowState.Normal;
      int width = Size.Width;
      Size size = Size;
      int height1 = size.Height;
      int num1 = height1;
      Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
      int height2 = workingArea.Height;
      if (num1 >= height2)
        height1 = checked (Screen.PrimaryScreen.WorkingArea.Height - 20);
      if (width >= Screen.PrimaryScreen.WorkingArea.Width)
      {
        workingArea = Screen.PrimaryScreen.WorkingArea;
        width = checked (workingArea.Width - 20);
      }
      size = new Size(width, height1);
      Size = size;
      Point point = new Point(10,10);
      // ISSUE: explicit reference operation
      // ISSUE: variable of a reference type
      Point local1 = @point;
      int x = ((Control) this).Location.X;
      Point location = ((Control) this).Location;
      int y = location.Y;
      // ISSUE: explicit reference operation
      local1 = new Point(x, y);
      location = ((Control) this).Location;
      if (location.X < 0)
        point.X = 0;
      location = ((Control) this).Location;
      if (checked (location.X + Size.Width) > Screen.PrimaryScreen.WorkingArea.Width)
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Point local2 = @point;
        workingArea = Screen.PrimaryScreen.WorkingArea;
        int num2 = checked (workingArea.Width - Size.Width - 30);
        // ISSUE: explicit reference operation
        (local2).X = num2;
      }
      location = ((Control) this).Location;
      if (location.Y < 0)
        point.Y = 0;
      location = ((Control) this).Location;
      if (checked (location.Y + Size.Height) > Screen.PrimaryScreen.WorkingArea.Height)
      {
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        Point local2 = @point;
        workingArea = Screen.PrimaryScreen.WorkingArea;
        int num2 = checked (workingArea.Height - Size.Height - 30);
        // ISSUE: explicit reference operation
        (local2).Y = num2;
      }
      ((Control) this).Location = point;
      //CurrentSettings.set_WindowLoc(FormClassName, ((Control) this).Location);
      //CurrentSettings.set_WindowSize(FormClassName, Size);
      UserSettings.SaveSettings(CurrentSettings);*/
    }
  }
}
