// Decompiled with JetBrains decompiler
// Type: KotorTool_2.RegReminder
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Forms
{
  public class RegReminder : Form
  {
    [AccessedThroughProperty("lblRegHeader")]
    private Label _lblRegHeader;
    [AccessedThroughProperty("Label1")]
    private Label _label1;
    [AccessedThroughProperty("Label2")]
    private Label _label2;
    [AccessedThroughProperty("Button1")]
    private Button _button1;
    [AccessedThroughProperty("lblTimeMsg")]
    private Label _lblTimeMsg;
    [AccessedThroughProperty("Button2")]
    private Button _button2;
    [AccessedThroughProperty("Timer1")]
    private Timer _timer1;
    private IContainer components;
    private object _mSec;
    public string BtnClicked;

    internal virtual Label LblRegHeader
    {
      get => _lblRegHeader;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblRegHeader == null)
          ;
        _lblRegHeader = value;
        if (_lblRegHeader != null)
          ;
      }
    }

    internal virtual Label Label2
    {
      get => _label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label2 == null)
          ;
        _label2 = value;
        if (_label2 != null)
          ;
      }
    }

    internal virtual Button Button1
    {
      get => _button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_button1 != null)
          _button1.Click -= Button1_Click;
        _button1 = value;
        if (_button1 == null)
          return;
        _button1.Click += Button1_Click;
      }
    }

    internal virtual Timer Timer1
    {
      get => _timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_timer1 != null)
          _timer1.Tick -= Timer1_Tick;
        _timer1 = value;
        if (_timer1 == null)
          return;
        _timer1.Tick += Timer1_Tick;
      }
    }

    internal virtual Label LblTimeMsg
    {
      get => _lblTimeMsg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblTimeMsg == null)
          ;
        _lblTimeMsg = value;
        if (_lblTimeMsg != null)
          ;
      }
    }

    internal virtual Button Button2
    {
      get => _button2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_button2 != null)
          _button2.Click -= Button2_Click;
        _button2 = value;
        if (_button2 == null)
          return;
        _button2.Click += Button2_Click;
      }
    }

    internal virtual Label Label1
    {
      get => _label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label1 == null)
          ;
        _label1 = value;
        if (_label1 != null)
          ;
      }
    }

    public RegReminder()
    {
      Load += RegReminder_Load;
      _mSec = 10;
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
      components = new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (RegReminder));
      LblRegHeader = new Label();
      Label2 = new Label();
      LblTimeMsg = new Label();
      Button1 = new Button();
      Timer1 = new Timer(components);
      Button2 = new Button();
      Label1 = new Label();
      SuspendLayout();
      LblRegHeader.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label lblRegHeader1 = LblRegHeader;
      Point point1 = new Point(15, 32);
      Point point2 = point1;
      lblRegHeader1.Location = point2;
      LblRegHeader.Name = "lblRegHeader";
      Label lblRegHeader2 = LblRegHeader;
      Size size1 = new Size(300, 23);
      Size size2 = size1;
      lblRegHeader2.Size = size2;
      LblRegHeader.TabIndex = 0;
      LblRegHeader.Text = "This copy of Kotor Tool is not registered";
      LblRegHeader.TextAlign = ContentAlignment.MiddleCenter;
      Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label label21 = Label2;
      point1 = new Point(16, 72);
      Point point3 = point1;
      label21.Location = point3;
      Label2.Name = "Label2";
      Label label22 = Label2;
      size1 = new Size(288, 48);
      Size size3 = size1;
      label22.Size = size3;
      Label2.TabIndex = 0;
      Label2.Text = "Registration removes this nag screen and unlocks additional features";
      Label2.TextAlign = ContentAlignment.TopCenter;
      LblTimeMsg.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label lblTimeMsg1 = LblTimeMsg;
      point1 = new Point(80, 192);
      Point point4 = point1;
      lblTimeMsg1.Location = point4;
      LblTimeMsg.Name = "lblTimeMsg";
      Label lblTimeMsg2 = LblTimeMsg;
      size1 = new Size(144, 23);
      Size size4 = size1;
      lblTimeMsg2.Size = size4;
      LblTimeMsg.TabIndex = 0;
      LblTimeMsg.Text = "Please wait .. ";
      Button1.Enabled = false;
      Button button1 = Button1;
      point1 = new Point(72, 240);
      Point point5 = point1;
      button1.Location = point5;
      Button1.Name = "Button1";
      Button1.TabIndex = 1;
      Button1.Text = "OK";
      Timer1.Interval = 800;
      Button button2 = Button2;
      point1 = new Point(176, 240);
      Point point6 = point1;
      button2.Location = point6;
      Button2.Name = "Button2";
      Button2.TabIndex = 2;
      Button2.Text = "Cancel";
      Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
      Label label11 = Label1;
      point1 = new Point(16, 128);
      Point point7 = point1;
      label11.Location = point7;
      Label1.Name = "Label1";
      Label label12 = Label1;
      size1 = new Size(312, 48);
      Size size5 = size1;
      label12.Size = size5;
      Label1.TabIndex = 3;
      Label1.Text = "Use the Registration option on the Help menu to start the registration process";
      Label1.TextAlign = ContentAlignment.TopCenter;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(336, 304);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(Label1);
      Controls.Add(Button2);
      Controls.Add(Button1);
      Controls.Add(LblRegHeader);
      Controls.Add(Label2);
      Controls.Add(LblTimeMsg);
     // this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
      size1 = new Size(328, 312);
      MinimumSize = size1;
      Name = "RegReminder";
      ShowInTaskbar = false;
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Reminder";
      TopMost = true;
      ResumeLayout(false);
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      LblTimeMsg.Text = StringType.FromObject(ObjectType.StrCatObj("Please wait ... ", _mSec));
      _mSec = ObjectType.SubObj(_mSec, 1);
      if (ObjectType.ObjTst(_mSec, -1, false) != 0)
        return;
      Timer1.Stop();
      Button1.Enabled = true;
    }

    private void RegReminder_Load(object sender, EventArgs e)
    {
      LblTimeMsg.Text = "Please wait ... 10";
      Timer1.Start();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      if (ObjectType.ObjTst(_mSec, 0, false) > 0)
        return;
      DialogResult = DialogResult.OK;
      BtnClicked = "OK";
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      BtnClicked = "Cancel";
    }
  }
}
