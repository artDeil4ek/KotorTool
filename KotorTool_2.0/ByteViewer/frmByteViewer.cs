using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.Options;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ByteViewer
{
    public class FrmByteViewer : Form
    {
        [AccessedThroughProperty("bv")] private System.ComponentModel.Design.ByteViewer _bv;
        [AccessedThroughProperty("rbHex")] private RadioButton _rbHex;
        [AccessedThroughProperty("rbUnicode")] private RadioButton _rbUnicode;
        [AccessedThroughProperty("rbANSI")] private RadioButton _rbAnsi;
        [AccessedThroughProperty("Button1")] private Button _button1;
        private readonly string _filepath;
        private readonly byte[] _data;
        private IContainer components;

        protected virtual System.ComponentModel.Design.ByteViewer bv
        {
            get => _bv;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_bv == null) ;
                _bv = value;
                if (_bv != null) ;
            }
        }

        internal virtual RadioButton rbHex
        {
            get => _rbHex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbHex != null)
                    _rbHex.Click -= rbHex_Click;
                _rbHex = value;
                if (_rbHex == null)
                    return;
                _rbHex.Click += rbHex_Click;
            }
        }

        internal virtual RadioButton rbANSI
        {
            get => _rbAnsi;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbAnsi != null)
                    _rbAnsi.Click -= rbANSI_Click;
                _rbAnsi = value;
                if (_rbAnsi == null)
                    return;
                _rbAnsi.Click += rbANSI_Click;
            }
        }

        internal virtual RadioButton rbUnicode
        {
            get => _rbUnicode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbUnicode != null)
                    _rbUnicode.Click -= rbUnicode_Click;
                _rbUnicode = value;
                if (_rbUnicode == null)
                    return;
                _rbUnicode.Click += rbUnicode_Click;
            }
        }

        protected virtual Button Button1
        {
            get => _button1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_button1 != null)
                    _button1.Click -= Button1_Click;
                _button1 = value;
                if (_button1 == null)
                    return;
                _button1.Click += Button1_Click;
            }
        }

        private FrmByteViewer()
        {
            Resize += frmByteViewer_Resize;
            Closing += frmByteViewer_Closing;
            Load += Form1_Load;
            bv = new System.ComponentModel.Design.ByteViewer();
            InitializeComponent();
        }

        public FrmByteViewer(string path)
            : this()
        {
            _filepath = path;
        }

        public FrmByteViewer(byte[] bytes)
            : this()
        {
            _data = bytes;
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
            ResourceManager resourceManager = new ResourceManager(typeof(FrmByteViewer));
            rbHex = new RadioButton();
            rbANSI = new RadioButton();
            rbUnicode = new RadioButton();
            Button1 = new Button();
            SuspendLayout();
            rbHex.Anchor = AnchorStyles.Bottom;
            rbHex.Checked = true;
            RadioButton rbHex1 = rbHex;
            Point point1 = new Point(64, 256);
            Point point2 = point1;
            rbHex1.Location = point2;
            rbHex.Name = "rbHex";
            RadioButton rbHex2 = rbHex;
            Size size1 = new Size(64, 16);
            Size size2 = size1;
            rbHex2.Size = size2;
            rbHex.TabIndex = 0;
            rbHex.TabStop = true;
            rbHex.Text = "Hex";
            rbANSI.Anchor = AnchorStyles.Bottom;
            RadioButton rbAnsi1 = rbANSI;
            point1 = new Point(156, 256);
            Point point3 = point1;
            rbAnsi1.Location = point3;
            rbANSI.Name = "rbANSI";
            RadioButton rbAnsi2 = rbANSI;
            size1 = new Size(64, 16);
            Size size3 = size1;
            rbAnsi2.Size = size3;
            rbANSI.TabIndex = 1;
            rbANSI.Text = "ANSI";
            rbUnicode.Anchor = AnchorStyles.Bottom;
            RadioButton rbUnicode1 = rbUnicode;
            point1 = new Point(248, 256);
            Point point4 = point1;
            rbUnicode1.Location = point4;
            rbUnicode.Name = "rbUnicode";
            RadioButton rbUnicode2 = rbUnicode;
            size1 = new Size(64, 16);
            Size size4 = size1;
            rbUnicode2.Size = size4;
            rbUnicode.TabIndex = 2;
            rbUnicode.Text = "Unicode";
            Button1.Anchor = AnchorStyles.Bottom;
            Button1.DialogResult = DialogResult.OK;
            Button button1 = Button1;
            point1 = new Point(504, 248);
            Point point5 = point1;
            button1.Location = point5;
            Button1.Name = "Button1";
            Button1.TabIndex = 3;
            Button1.Text = "OK";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(632, 277);
            ClientSize = size1;
            Controls.Add(Button1);
            Controls.Add(rbHex);
            Controls.Add(rbANSI);
            Controls.Add(rbUnicode);
            Icon = (Icon) resourceManager.GetObject("$this.Icon");
            size1 = new Size(640, 1600);
            MaximumSize = size1;
            size1 = new Size(640, 200);
            MinimumSize = size1;
            Name = "FrmByteViewer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Byte Viewer";
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bv.Size = new Size(638, 250);
            bv.Anchor = AnchorStyles.Top;
            bv.ForeColor = Color.Black;
            bv.BackColor = DefaultBackColor;
            bv.Visible = true;
            Controls.Add(bv);
            if (StringType.StrCmp(_filepath, "", false) != 0) bv.SetFile(_filepath);
            else if (_data.Length > 0) bv.SetBytes(_data);
            bv.SetDisplayMode(DisplayMode.Hexdump);
            bv.Height = (int) Math.Round(Conversion.Int(Height - 80 / 21.0) * 21.0 + 21.0);
        }

        private void rbANSI_Click(object sender, EventArgs e)
        {
            bv.SetDisplayMode(DisplayMode.Ansi);
            bv.Font = new Font("Lucida Console", 8f);
        }

        private void rbHex_Click(object sender, EventArgs e)
        {
            bv.SetDisplayMode(DisplayMode.Hexdump);
        }

        private void rbUnicode_Click(object sender, EventArgs e)
        {
            bv.SetDisplayMode(DisplayMode.Unicode);
        }

        private void frmByteViewer_Resize(object sender, EventArgs e)
        {
            bv.Height = (int) Math.Round(Conversion.Int(Height - 80 / 21.0) * 21.0 + 21.0);
        }


        private void SaveSettings()
        {
            ConfigOptions.WindowSettings.ByteViewerWindowLoc = ((Control) this).Location;
            ConfigOptions.WindowSettings.ByteViewerWindowSize = Size;
        }

        private void frmByteViewer_Closing(object sender, CancelEventArgs e)
        {
            SaveSettings();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}