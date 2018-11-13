using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KotorTool_2._0.Forms
{
  public class FrmAbout : Form
  {
    [AccessedThroughProperty("Button1")]
    private Button _button1;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _pictureBox1;
    [AccessedThroughProperty("Label1")]
    private Label _label1;
    [AccessedThroughProperty("Label5")]
    private Label _label5;
    [AccessedThroughProperty("Label3")]
    private Label _label3;
    [AccessedThroughProperty("lblVersion")]
    private Label _lblVersion;
    [AccessedThroughProperty("Label4")]
    private Label _label4;
    private IContainer components;

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

    internal virtual Button Button1
    {
      get => _button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_button1 == null)
          ;
        _button1 = value;
        if (_button1 != null)
          ;
      }
    }

    internal virtual Label Label3
    {
      get => _label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label3 == null)
          ;
        _label3 = value;
        if (_label3 != null)
          ;
      }
    }

    internal virtual PictureBox PictureBox1
    {
      get => _pictureBox1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_pictureBox1 == null)
          ;
        _pictureBox1 = value;
        if (_pictureBox1 != null)
          ;
      }
    }

    internal virtual Label Label4
    {
      get => _label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label4 == null)
          ;
        _label4 = value;
        if (_label4 != null)
          ;
      }
    }

    internal virtual Label Label5
    {
      get => _label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label5 == null)
          ;
        _label5 = value;
        if (_label5 != null)
          ;
      }
    }

    internal virtual Label LblVersion
    {
      get => _lblVersion;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblVersion == null)
          ;
        _lblVersion = value;
        if (_lblVersion != null)
          ;
      }
    }

    public FrmAbout()
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
            SuspendLayout();
            // 
            // frmAbout
            // 
            BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            ClientSize = new System.Drawing.Size(547, 460);
            Name = "FrmAbout";
            ResumeLayout(false);

    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(((LinkLabel) sender).Text);
    }
  }
}
