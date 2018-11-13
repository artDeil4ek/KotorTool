using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.Models.CLS;
using Microsoft.VisualBasic;

namespace KotorTool_2._0.Forms
{
  public class frmAutoDialog : Form
  {
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    private IContainer components;
    private string filepath;

    internal virtual Timer Timer1
    {
      get => _Timer1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Timer1 != null)
          _Timer1.Tick -= Timer1_Tick;
        _Timer1 = value;
        if (_Timer1 == null)
          return;
        _Timer1.Tick += Timer1_Tick;
      }
    }

    internal virtual Label Label1
    {
      get => _Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label1 == null)
          ;
        _Label1 = value;
        if (_Label1 != null)
          ;
      }
    }

    public frmAutoDialog()
    {
      Load += frmAutoDialog_Load;
      Closing += frmAutoDialog_Closing;
      filepath = ConfigOptions.Paths.DefaultKotOrLocation + "\\override\\ft_watch.dlg";
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
      ResourceManager resourceManager = new ResourceManager(typeof (frmAutoDialog));
      Timer1 = new Timer(components);
      Label1 = new Label();
      SuspendLayout();
      Timer1.Interval = 10000;
      Label1.Location = new Point(32, 24);
      Label1.Name = "Label1";
      Label label1 = Label1;
      Size size1 = new Size(224, 40);
      Size size2 = size1;
      label1.Size = size2;
      Label1.TabIndex = 0;
      Label1.Text = "The time is being sent to the custom.dlg file in your SW:KotOR Override folder every 10 seconds. Close this window to stop.";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(292, 93);
      ClientSize = size1;
      Controls.Add(Label1);
      Icon = (Icon) resourceManager.GetObject("$this.Icon");
      Name = "frmAutoDialog";
      Text = "Auto Dialog";
      ResumeLayout(false);
    }

    private void SetDLGData()
    {
      ClsGff clsGff = new ClsGff(new FileStream(filepath, FileMode.Open), 0);
      DateTime now = DateAndTime.Now;
      clsGff.SetEnglishCExoLocSubStringEntry("EntryList(0).Text", "The time is " + now.ToLongTimeString());
      clsGff.WriteFile(filepath, "DLG");
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      SetDLGData();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      SetDLGData();
    }

    private void frmAutoDialog_Load(object sender, EventArgs e)
    {
      Timer1.Enabled = true;
    }

    private void frmAutoDialog_Closing(object sender, CancelEventArgs e)
    {
      Timer1.Enabled = false;
    }
  }
}
