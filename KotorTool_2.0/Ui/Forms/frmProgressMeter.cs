// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmProgressMeter
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KotorTool_2._0.Ui.Forms
{
  public class frmProgressMeter : Form
  {
    [AccessedThroughProperty("pbar")]
    private ProgressBar _pbar;
    [AccessedThroughProperty("lblStatus")]
    private Label _lblStatus;
    [AccessedThroughProperty("lblMsg")]
    private Label _lblMsg;
    private IContainer components;

    internal virtual ProgressBar pbar
    {
      get => _pbar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_pbar == null)
          ;
        _pbar = value;
        if (_pbar != null)
          ;
      }
    }

    internal virtual Label lblStatus
    {
      get => _lblStatus;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblStatus == null)
          ;
        _lblStatus = value;
        if (_lblStatus != null)
          ;
      }
    }

    internal virtual Label lblMsg
    {
      get => _lblMsg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblMsg == null)
          ;
        _lblMsg = value;
        if (_lblMsg != null)
          ;
      }
    }

    public int progress
    {
      set => pbar.Value = value;
    }

    public int stepAmount
    {
      set => pbar.Step = value;
    }

    public string message
    {
      set
      {
        lblMsg.Text = value;
        Application.DoEvents();
      }
    }

    public string status
    {
      set
      {
        lblStatus.Text = value;
        Application.DoEvents();
      }
    }

    public int maxvalue
    {
      set => pbar.Maximum = value;
    }

    public frmProgressMeter()
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
      pbar = new ProgressBar();
      lblStatus = new Label();
      lblMsg = new Label();
      SuspendLayout();
      ProgressBar pbar1 = pbar;
      Point point1 = new Point(42, 48);
      Point point2 = point1;
      pbar1.Location = point2;
      pbar.Name = "pbar";
      ProgressBar pbar2 = pbar;
      Size size1 = new Size(203, 16);
      Size size2 = size1;
      pbar2.Size = size2;
      pbar.TabIndex = 0;
      Label lblStatus1 = lblStatus;
      point1 = new Point(27, 80);
      Point point3 = point1;
      lblStatus1.Location = point3;
      lblStatus.Name = "lblStatus";
      Label lblStatus2 = lblStatus;
      size1 = new Size(232, 23);
      Size size3 = size1;
      lblStatus2.Size = size3;
      lblStatus.TabIndex = 1;
      lblStatus.TextAlign = ContentAlignment.MiddleCenter;
      Label lblMsg1 = lblMsg;
      point1 = new Point(32, 8);
      Point point4 = point1;
      lblMsg1.Location = point4;
      lblMsg.Name = "lblMsg";
      Label lblMsg2 = lblMsg;
      size1 = new Size(224, 23);
      Size size4 = size1;
      lblMsg2.Size = size4;
      lblMsg.TabIndex = 2;
      lblMsg.TextAlign = ContentAlignment.MiddleCenter;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(286, 115);
      ClientSize = size1;
      ControlBox = false;
      Controls.AddRange(new Control[3]
      {
        lblMsg,
        lblStatus,
        pbar
      });
      Name = "frmProgressMeter";
      ShowInTaskbar = false;
      SizeGripStyle = SizeGripStyle.Hide;
      StartPosition = FormStartPosition.Manual;
      ResumeLayout(false);
    }

    public void stepUp()
    {
      pbar.PerformStep();
      Application.DoEvents();
    }
  }
}
