// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmPathManager
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace KotorTool_2._0.Ui.Forms
{
  public class frmPathManager : Form
  {
    [AccessedThroughProperty("btnKotorPath")]
    private Button _btnKotorPath;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _TabPage1;
    [AccessedThroughProperty("btnAutoDetectKotor2")]
    private Button _btnAutoDetectKotor2;
    [AccessedThroughProperty("ToolTip1")]
    private ToolTip _ToolTip1;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _TabPage2;
    [AccessedThroughProperty("tbModuleExportPath")]
    private TextBox _tbModuleExportPath;
    [AccessedThroughProperty("tbKotorPath")]
    private TextBox _tbKotorPath;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("TabPage3")]
    private TabPage _TabPage3;
    [AccessedThroughProperty("btnAutoDetectKotor1")]
    private Button _btnAutoDetectKotor1;
    [AccessedThroughProperty("tbKotorPath2")]
    private TextBox _tbKotorPath2;
    [AccessedThroughProperty("btnModuleExportPath")]
    private Button _btnModuleExportPath;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("btnKotorPath2")]
    private Button _btnKotorPath2;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("tbImportPath")]
    private TextBox _tbImportPath;
    [AccessedThroughProperty("btnImageViewerPath")]
    private Button _btnImageViewerPath;
    [AccessedThroughProperty("tbImageViewerPath")]
    private TextBox _tbImageViewerPath;
    [AccessedThroughProperty("tbSavePath")]
    private TextBox _tbSavePath;
    [AccessedThroughProperty("btnSavePath")]
    private Button _btnSavePath;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("btnImportPath")]
    private Button _btnImportPath;
    private IContainer components;
    private Options.ConfigOptions _configOptions;

    internal virtual Label Label7
    {
      get => _Label7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label7 == null)
          ;
        _Label7 = value;
        if (_Label7 != null)
          ;
      }
    }

    internal virtual TextBox tbKotorPath
    {
      get => _tbKotorPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbKotorPath == null)
          ;
        _tbKotorPath = value;
        if (_tbKotorPath != null)
          ;
      }
    }

    internal virtual Button btnKotorPath
    {
      get => _btnKotorPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnKotorPath != null)
          _btnKotorPath.Click -= btnKotorPath_Click;
        _btnKotorPath = value;
        if (_btnKotorPath == null)
          return;
        _btnKotorPath.Click += btnKotorPath_Click;
      }
    }

    internal virtual Button btnOK
    {
      get => _btnOK;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnOK != null)
          _btnOK.Click -= btnOK_Click;
        _btnOK = value;
        if (_btnOK == null)
          return;
        _btnOK.Click += btnOK_Click;
      }
    }

    internal virtual Button btnCancel
    {
      get => _btnCancel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnCancel == null)
          ;
        _btnCancel = value;
        if (_btnCancel != null)
          ;
      }
    }

    internal virtual ToolTip ToolTip1
    {
      get => _ToolTip1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_ToolTip1 == null)
          ;
        _ToolTip1 = value;
        if (_ToolTip1 != null)
          ;
      }
    }

    internal virtual TabControl TabControl1
    {
      get => _TabControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_TabControl1 == null)
          ;
        _TabControl1 = value;
        if (_TabControl1 != null)
          ;
      }
    }

    internal virtual TabPage TabPage1
    {
      get => _TabPage1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_TabPage1 == null)
          ;
        _TabPage1 = value;
        if (_TabPage1 != null)
          ;
      }
    }

    internal virtual TabPage TabPage2
    {
      get => _TabPage2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_TabPage2 == null)
          ;
        _TabPage2 = value;
        if (_TabPage2 != null)
          ;
      }
    }

    internal virtual Label Label14
    {
      get => _Label14;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label14 == null)
          ;
        _Label14 = value;
        if (_Label14 != null)
          ;
      }
    }

    internal virtual TextBox tbKotorPath2
    {
      get => _tbKotorPath2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbKotorPath2 == null)
          ;
        _tbKotorPath2 = value;
        if (_tbKotorPath2 != null)
          ;
      }
    }

    internal virtual Label Label6
    {
      get => _Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label6 == null)
          ;
        _Label6 = value;
        if (_Label6 != null)
          ;
      }
    }

    internal virtual Button btnImportPath
    {
      get => _btnImportPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnImportPath != null)
          _btnImportPath.Click -= btnImportPath_Click;
        _btnImportPath = value;
        if (_btnImportPath == null)
          return;
        _btnImportPath.Click += btnImportPath_Click;
      }
    }

    internal virtual Button btnSavePath
    {
      get => _btnSavePath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnSavePath != null)
          _btnSavePath.Click -= btnSavePath_Click;
        _btnSavePath = value;
        if (_btnSavePath == null)
          return;
        _btnSavePath.Click += btnSavePath_Click;
      }
    }

    internal virtual TextBox tbSavePath
    {
      get => _tbSavePath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbSavePath == null)
          ;
        _tbSavePath = value;
        if (_tbSavePath != null)
          ;
      }
    }

    internal virtual Label Label5
    {
      get => _Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label5 == null)
          ;
        _Label5 = value;
        if (_Label5 != null)
          ;
      }
    }

    internal virtual Label Label3
    {
      get => _Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label3 == null)
          ;
        _Label3 = value;
        if (_Label3 != null)
          ;
      }
    }

    internal virtual TextBox tbImageViewerPath
    {
      get => _tbImageViewerPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbImageViewerPath == null)
          ;
        _tbImageViewerPath = value;
        if (_tbImageViewerPath != null)
          ;
      }
    }

    internal virtual Button btnImageViewerPath
    {
      get => _btnImageViewerPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnImageViewerPath != null)
          _btnImageViewerPath.Click -= btnImageViewerPath_Click;
        _btnImageViewerPath = value;
        if (_btnImageViewerPath == null)
          return;
        _btnImageViewerPath.Click += btnImageViewerPath_Click;
      }
    }

    internal virtual TextBox tbImportPath
    {
      get => _tbImportPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbImportPath == null)
          ;
        _tbImportPath = value;
        if (_tbImportPath != null)
          ;
      }
    }

    internal virtual Button btnKotorPath2
    {
      get => _btnKotorPath2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnKotorPath2 != null)
          _btnKotorPath2.Click -= btnKotorPath2_Click;
        _btnKotorPath2 = value;
        if (_btnKotorPath2 == null)
          return;
        _btnKotorPath2.Click += btnKotorPath2_Click;
      }
    }

    internal virtual Button btnAutoDetectKotor1
    {
      get => _btnAutoDetectKotor1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnAutoDetectKotor1 != null)
          _btnAutoDetectKotor1.Click -= btnAutoDetectKotor1_Click;
        _btnAutoDetectKotor1 = value;
        if (_btnAutoDetectKotor1 == null)
          return;
        _btnAutoDetectKotor1.Click += btnAutoDetectKotor1_Click;
      }
    }

    internal virtual Button btnAutoDetectKotor2
    {
      get => _btnAutoDetectKotor2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnAutoDetectKotor2 != null)
          _btnAutoDetectKotor2.Click -= btnAutoDetectKotor2_Click;
        _btnAutoDetectKotor2 = value;
        if (_btnAutoDetectKotor2 == null)
          return;
        _btnAutoDetectKotor2.Click += btnAutoDetectKotor2_Click;
      }
    }

    internal virtual TabPage TabPage3
    {
      get => _TabPage3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_TabPage3 == null)
          ;
        _TabPage3 = value;
        if (_TabPage3 != null)
          ;
      }
    }

    internal virtual Label Label15
    {
      get => _Label15;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label15 == null)
          ;
        _Label15 = value;
        if (_Label15 != null)
          ;
      }
    }

    internal virtual TextBox tbModuleExportPath
    {
      get => _tbModuleExportPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbModuleExportPath == null)
          ;
        _tbModuleExportPath = value;
        if (_tbModuleExportPath != null)
          ;
      }
    }

    internal virtual Button btnModuleExportPath
    {
      get => _btnModuleExportPath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnModuleExportPath != null)
          _btnModuleExportPath.Click -= btnModuleExportPath_Click;
        _btnModuleExportPath = value;
        if (_btnModuleExportPath == null)
          return;
        _btnModuleExportPath.Click += btnModuleExportPath_Click;
      }
    }

    public frmPathManager()
    {
     InitializeComponent();
      CreateNew();
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
            // frmPathManager
            // 
            AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            ClientSize = new System.Drawing.Size(54, 0);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(5, 13);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(5, 13);
            Name = "frmPathManager";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Path Manager";
            ResumeLayout(false);

    }

    public void CreateNew()
    {
           
            if(ConfigOptions.Paths.KotorLocation(0) == null)
            {}
            else {
                try
                {
                    tbKotorPath.Text =ConfigOptions.Paths.KotorLocation(0);
                }
                catch (NullReferenceException nullIE )
                {
                    Console.Write("ERROR");
                }
                }
            if (ConfigOptions.Paths.KotorLocation(1) == null)
            { }
            else { tbKotorPath2.Text = ConfigOptions.Paths.KotorLocation(1); }
           if (ConfigOptions.Paths.DefaultImportLocation == null)
            {

            }
                else
            {
                tbImportPath.Text = ConfigOptions.Paths.DefaultImportLocation;
            }
            if(ConfigOptions.Paths.DefaultSaveLocation == null)
            {

            }
            else
            {
                tbSavePath.Text = ConfigOptions.Paths.DefaultSaveLocation;
            }
           if (ConfigOptions.Paths.ImageViewerLocation == null)
            {

            }
            else
            {
                tbImageViewerPath.Text = ConfigOptions.Paths.ImageViewerLocation;
            }
            if (ConfigOptions.Paths.ModelExportLocation == null)
            {

            }
            else
            {
                tbModuleExportPath.Text = ConfigOptions.Paths.ModelExportLocation;
            }
      
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      ConfigOptions.Paths.DefaultKotorLocation = tbKotorPath.Text;
      ConfigOptions.Paths.DefaultKotorTslLocation = tbKotorPath2.Text;
      ConfigOptions.Paths.DefaultImportLocation = tbImportPath.Text;
      ConfigOptions.Paths.DefaultSaveLocation = tbSavePath.Text;
      ConfigOptions.Paths.ImageViewerLocation = tbImageViewerPath.Text;
      ConfigOptions.Paths.ModelExportLocation = tbModuleExportPath.Text;
      UserSettings.SaveSettings(_configOptions);
    }

    private void BrowseForFolder(ref TextBox fld)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Locate folder";
      folderBrowserDialog.SelectedPath = fld.Text;
      folderBrowserDialog.ShowNewFolderButton = false;
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      fld.Text = folderBrowserDialog.SelectedPath;
    }

    private void BrowseForFile(ref TextBox fld)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "Select Chitin.key file...";
      openFileDialog.Filter = "Chitin files (*.key)|*.key";
      openFileDialog.InitialDirectory = fld.Text;
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      openFileDialog.FileName = "chitin.key";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      fld.Text = openFileDialog.FileName;
    }

    private void BrowseForApp(ref TextBox fld)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "Select Program file...";
      openFileDialog.Filter = "Image Viewer Application (*.exe)|*.exe";
      if (StringType.StrCmp(fld.Text, "", false) != 0)
        openFileDialog.InitialDirectory = Strings.Mid(fld.Text, 1, fld.Text.LastIndexOf("\\"));
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      openFileDialog.RestoreDirectory = true;
      if (StringType.StrCmp(fld.Text, "", false) != 0)
        openFileDialog.FileName = Strings.Mid(fld.Text, checked (fld.Text.LastIndexOf("\\") + 2));
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      fld.Text = openFileDialog.FileName;
    }

    private void btnKotorPath_Click(object sender, EventArgs e)
    {
      TextBox tbKotorPath = this.tbKotorPath;
      BrowseForFolder(ref tbKotorPath);
      this.tbKotorPath = tbKotorPath;
    }

    private void btnImageViewerPath_Click(object sender, EventArgs e)
    {
      TextBox tbImageViewerPath = this.tbImageViewerPath;
      BrowseForApp(ref tbImageViewerPath);
      this.tbImageViewerPath = tbImageViewerPath;
    }

    private void btnImportPath_Click(object sender, EventArgs e)
    {
      TextBox tbImportPath = this.tbImportPath;
      BrowseForFolder(ref tbImportPath);
      this.tbImportPath = tbImportPath;
    }

    private void btnSavePath_Click(object sender, EventArgs e)
    {
      TextBox tbSavePath = this.tbSavePath;
      BrowseForFolder(ref tbSavePath);
      this.tbSavePath = tbSavePath;
    }

    private void btnKotorPath2_Click(object sender, EventArgs e)
    {
      TextBox tbKotorPath2 = this.tbKotorPath2;
      BrowseForFolder(ref tbKotorPath2);
      this.tbKotorPath2 = tbKotorPath2;
    }

    public void btnAutoDetectKotor1_Click(object sender, EventArgs e)
    {
      RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\Bioware\\SW\\KOTOR");
      if (registryKey == null)
      {
         Interaction.MsgBox("KotOR I not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical, "Registry value not found");
      }
      else
        tbKotorPath.Text = StringType.FromObject(registryKey.GetValue("path"));
    }

    public void btnAutoDetectKotor2_Click(object sender, EventArgs e)
    {
      RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\LucasArts\\KotOR2");
      if (registryKey == null)
      {
          Interaction.MsgBox("KotOR II not detected in registry. You mau still enter paths manually", MsgBoxStyle.Critical, "Registry value not found");
      }
      else
        tbKotorPath2.Text = StringType.FromObject(registryKey.GetValue("path"));
    }

    private void btnModuleExportPath_Click(object sender, EventArgs e)
    {
      TextBox moduleExportPath = tbModuleExportPath;
      BrowseForFolder(ref moduleExportPath);
      tbModuleExportPath = moduleExportPath;
    }
  }
}
