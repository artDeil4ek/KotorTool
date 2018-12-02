using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.ImageViewer
{
    public class FrmImageViewer : Form
    {
        [AccessedThroughProperty("btnWriteFile")]
        private Button _btnWriteFile;

        [AccessedThroughProperty("lblMipMapCount")]
        private Label _lblMipMapCount;

        [AccessedThroughProperty("Label2")] private Label _label2;
        [AccessedThroughProperty("Label1")] private Label _label1;
        [AccessedThroughProperty("lblFlag1")] private Label _lblFlag1;
        [AccessedThroughProperty("lblFlag2")] private Label _lblFlag2;
        [AccessedThroughProperty("lblFlag3")] private Label _lblFlag3;
        [AccessedThroughProperty("lblFlag4")] protected Label _lblFlag4;
        [AccessedThroughProperty("Panel1")] private Panel _panel1;
        [AccessedThroughProperty("btnOK")] private Button _btnOk;

        [AccessedThroughProperty("tbImageInfo")]
        private TextBox _tbImageInfo;

        [AccessedThroughProperty("chkbExportSelectionToTXIfile")]
        private CheckBox _chkbExportSelectionToTxIfile;

        [AccessedThroughProperty("pbox")] private PictureBox _pbox;


        private IContainer components;
        private byte[] PxData;
        private byte[] TpcData;
        private byte[] Pixeldata;
        private short _xSize;
        private short _ySize;
        private short _bitsPerPixel;
        private string _fname;
        private GCHandle _ghImage;
        private bool _bNeedToFlipForWriting;
        private int _dataSize;
        private int _encoding1;
        private int _mipmapCnt;
        private int _decodeCmd;
        private byte _flag1;
        private byte _flag2;
        private byte _flag3;
        private byte _flag4;


        public FrmImageViewer()
        {
            Load += frmImageViewer_Load;
            Closing += frmImageViewer_Closing;
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }


        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            _pbox = new PictureBox();
            _btnOk = new Button();
            _panel1 = new Panel();
            _tbImageInfo = new TextBox();
            _label1 = new Label();
            _lblMipMapCount = new Label();
            _label2 = new Label();
            _btnWriteFile = new Button();
            _lblFlag1 = new Label();
            _lblFlag2 = new Label();
            _lblFlag3 = new Label();
            _lblFlag4 = new Label();
            _chkbExportSelectionToTxIfile = new CheckBox();
            _panel1.SuspendLayout();
            SuspendLayout();
            _pbox.BorderStyle = BorderStyle.FixedSingle;
            PictureBox pbox1 = _pbox;
            Point point1 = new Point(0, 0);
            Point point2 = point1;
            pbox1.Location = point2;
            _pbox.Name = "pbox";
            PictureBox pbox2 = _pbox;
            Size size1 = new Size(96, 80);
            Size size2 = size1;
            pbox2.Size = size2;
            _pbox.SizeMode = PictureBoxSizeMode.CenterImage;
            _pbox.TabIndex = 0;
            _pbox.TabStop = false;
            _btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnOk.DialogResult = DialogResult.Cancel;
            Button btnOk = _btnOk;
            point1 = new Point(344, 456);
            Point point3 = point1;
            btnOk.Location = point3;
            _btnOk.Name = "btnOK";
            _btnOk.TabIndex = 0;
            _btnOk.Text = "OK";
            _panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _panel1.AutoScroll = true;
            _panel1.Controls.Add(_pbox);
            Panel panel11 = _panel1;
            point1 = new Point(16, 16);
            Point point4 = point1;
            panel11.Location = point4;
            _panel1.Name = "Panel1";
            Panel panel12 = _panel1;
            size1 = new Size(416, 376);
            Size size3 = size1;
            panel12.Size = size3;
            _panel1.TabIndex = 1;
            _tbImageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBox tbImageInfo1 = _tbImageInfo;
            point1 = new Point(16, 400);
            Point point5 = point1;
            tbImageInfo1.Location = point5;
            _tbImageInfo.Multiline = true;
            _tbImageInfo.Name = "tbImageInfo";
            TextBox tbImageInfo2 = _tbImageInfo;
            size1 = new Size(160, 64);
            Size size4 = size1;
            tbImageInfo2.Size = size4;
            _tbImageInfo.TabIndex = 2;
            _tbImageInfo.Text = "";
            _label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label label11 = _label1;
            point1 = new Point(184, 400);
            Point point6 = point1;
            label11.Location = point6;
            _label1.Name = "Label1";
            Label label12 = _label1;
            size1 = new Size(112, 16);
            Size size5 = size1;
            label12.Size = size5;
            _label1.TabIndex = 3;
            _label1.Text = "Number of mipmaps:";
            _label1.TextAlign = ContentAlignment.MiddleRight;
            _lblMipMapCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _lblMipMapCount.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label lblMipMapCount1 = _lblMipMapCount;
            point1 = new Point(294, 400);
            Point point7 = point1;
            lblMipMapCount1.Location = point7;
            _lblMipMapCount.Name = "lblMipMapCount";
            Label lblMipMapCount2 = _lblMipMapCount;
            size1 = new Size(24, 16);
            Size size6 = size1;
            lblMipMapCount2.Size = size6;
            _lblMipMapCount.TabIndex = 4;
            _lblMipMapCount.TextAlign = ContentAlignment.MiddleCenter;
            _label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label label21 = _label2;
            point1 = new Point(288, 416);
            Point point8 = point1;
            label21.Location = point8;
            _label2.Name = "Label2";
            Label label22 = _label2;
            size1 = new Size(24, 16);
            Size size7 = size1;
            label22.Size = size7;
            _label2.TabIndex = 4;
            _label2.TextAlign = ContentAlignment.MiddleCenter;
            _btnWriteFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button btnWriteFile = _btnWriteFile;
            point1 = new Point(248, 456);
            Point point9 = point1;
            btnWriteFile.Location = point9;
            _btnWriteFile.Name = "btnWriteFile";
            _btnWriteFile.TabIndex = 0;
            _btnWriteFile.Text = "Write File";
            _lblFlag1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label lblFlag11 = _lblFlag1;
            point1 = new Point(184, 432);
            Point point10 = point1;
            lblFlag11.Location = point10;
            _lblFlag1.Name = "lblFlag1";
            Label lblFlag12 = _lblFlag1;
            size1 = new Size(20, 16);
            Size size8 = size1;
            lblFlag12.Size = size8;
            _lblFlag1.TabIndex = 5;
            _lblFlag1.Text = "AA";
            _lblFlag1.TextAlign = ContentAlignment.MiddleCenter;
            _lblFlag2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label lblFlag21 = _lblFlag2;
            point1 = new Point(208, 432);
            Point point11 = point1;
            lblFlag21.Location = point11;
            _lblFlag2.Name = "lblFlag2";
            Label lblFlag22 = _lblFlag2;
            size1 = new Size(20, 16);
            Size size9 = size1;
            lblFlag22.Size = size9;
            _lblFlag2.TabIndex = 6;
            _lblFlag2.Text = "AA";
            _lblFlag2.TextAlign = ContentAlignment.MiddleCenter;
            _lblFlag3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label lblFlag31 = _lblFlag3;
            point1 = new Point(232, 432);
            Point point12 = point1;
            lblFlag31.Location = point12;
            _lblFlag3.Name = "lblFlag3";
            Label lblFlag32 = _lblFlag3;
            size1 = new Size(20, 16);
            Size size10 = size1;
            lblFlag32.Size = size10;
            _lblFlag3.TabIndex = 7;
            _lblFlag3.Text = "AA";
            _lblFlag3.TextAlign = ContentAlignment.MiddleCenter;
            _lblFlag4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label lblFlag41 = _lblFlag4;
            point1 = new Point(256, 432);
            Point point13 = point1;
            lblFlag41.Location = point13;
            _lblFlag4.Name = "lblFlag4";
            Label lblFlag42 = _lblFlag4;
            size1 = new Size(20, 16);
            Size size11 = size1;
            lblFlag42.Size = size11;
            _lblFlag4.TabIndex = 8;
            _lblFlag4.Text = "AA";
            _lblFlag4.TextAlign = ContentAlignment.MiddleCenter;
            _chkbExportSelectionToTxIfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CheckBox selectionToTxIfile1 = _chkbExportSelectionToTxIfile;
            point1 = new Point(16, 472);
            Point point14 = point1;
            selectionToTxIfile1.Location = point14;
            _chkbExportSelectionToTxIfile.Name = "chkbExportSelectionToTXIfile";
            CheckBox selectionToTxIfile2 = _chkbExportSelectionToTxIfile;
            size1 = new Size(160, 16);
            Size size12 = size1;
            selectionToTxIfile2.Size = size12;
            _chkbExportSelectionToTxIfile.TabIndex = 9;
            _chkbExportSelectionToTxIfile.Text = "Export Selection to TXI file";
            AcceptButton = _btnOk;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            CancelButton = _btnOk;
            size1 = new Size(448, 493);
            ClientSize = size1;
            Controls.Add(_chkbExportSelectionToTxIfile);
            Controls.Add(_lblFlag4);
            Controls.Add(_lblFlag3);
            Controls.Add(_lblFlag2);
            Controls.Add(_lblFlag1);
            Controls.Add(_lblMipMapCount);
            Controls.Add(_label1);
            Controls.Add(_tbImageInfo);
            Controls.Add(_panel1);
            Controls.Add(_btnOk);
            Controls.Add(_label2);
            Controls.Add(_btnWriteFile);
            //this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
            size1 = new Size(456, 472);
            MinimumSize = size1;
            Name = "FrmImageViewer";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            Text = "Image Viewer";
            _panel1.ResumeLayout(false);
            ResumeLayout(false);
        }


        public void SetupPixelArray(Array data)
        {
            PxData = new Byte[data.Length];
            Array.Copy(data, PxData, data.Length);
        }


        public void SetupTpcData(Array data, string filename)
        {
            TpcData = new Byte[data.Length];
            Array.Copy(data, TpcData, data.Length);
            _fname = filename;
        }


      
        


        public void DecodeImage()
        {
            _dataSize = (int) Math.Round(TpcData[0] + TpcData[1] * 256.0 + TpcData[2] * 65536.0 + TpcData[3] * 16777216.0);
            _flag1 = TpcData[4];
            _flag2 = TpcData[5];
            _flag3 = TpcData[6];
            _flag4 = TpcData[7];
            _xSize = (short) (TpcData[8] + TpcData[9] * 256);
            _ySize = (short) (TpcData[10] + TpcData[11] * 256);
            _encoding1 = TpcData[12];
            _mipmapCnt = TpcData[13];
            Array.Copy(TpcData, 128, TpcData, 0, TpcData.Length - 128);
            int decodeCmd = 0;
            if (_dataSize == 0 & _encoding1 == 2 & _mipmapCnt == 1)
            {
                _bNeedToFlipForWriting = false;
                int num1 = 0;
                int num2 = _xSize * _ySize - 1;
                int num3 = num1;
                while (num3 <= num2)
                {
                    byte num4 = TpcData[num3 * 3];
                    TpcData[num3 * 3] = TpcData[num3 * 3 + 2];
                    TpcData[num3 * 3 + 2] = num4;
                    ++num3;
                }

                Pixeldata = new Byte[TpcData.Length];
                Array.Copy(TpcData, Pixeldata, TpcData.Length);
                Array pixeldata = Pixeldata;
                FlipImageVertically(ref pixeldata, 3 * _xSize, _ySize);
                Pixeldata = (byte[]) pixeldata;
            }
            else if (_dataSize == 0 & _encoding1 == 4 & _mipmapCnt == 1)
            {
                _bNeedToFlipForWriting = false;
                int num1 = _xSize * _ySize;
                int num2 = 0;
                int num3 = num1 - 1;
                int num4 = num2;
                while (num4 <= num3)
                {
                    byte num5 = TpcData[num4 * 4];
                    TpcData[num4 * 4] = TpcData[num4 * 4 + 2];
                    TpcData[num4 * 4 + 2] = num5;
                    ++num4;
                }

                Pixeldata = new Byte[TpcData.Length];
                Array.Copy(TpcData, Pixeldata, TpcData.Length);
                Array pixeldata = Pixeldata;
                FlipImageVertically(ref pixeldata, 4 * _xSize, _ySize);
                Pixeldata = (byte[]) pixeldata;
            }
            else if (_encoding1 == 2 | _encoding1 == 4)
            {
                _bNeedToFlipForWriting = true;
                long[] numArray1 = {_xSize};
                long[] numArray2 = numArray1;
                int index1 = 0;
                int index2 = index1;
                long num1 = numArray1[index1] * _ySize;
                numArray2[index2] = num1;
                long[] numArray3 = numArray1;
                int index3 = 0;
                int index4 = index3;
                long num2 = checked(numArray1[index3] * 4L);
                numArray3[index4] = num2;
                Pixeldata = (byte[]) Array.CreateInstance(typeof(byte), numArray1);
                if (_encoding1 == 2) decodeCmd = 1;
                else if (_encoding1 == 4) decodeCmd = 5;
            }

            if (_dataSize > 0 & (_encoding1 == 2 | _encoding1 == 4))
            {
                TpcTool tpcTool = new TpcTool();
                GCHandle gcHandle1 = GCHandle.Alloc(TpcData, GCHandleType.Pinned);
                GCHandle gcHandle2 = GCHandle.Alloc(Pixeldata, GCHandleType.Pinned);
                IntPtr data = gcHandle1.AddrOfPinnedObject();
                IntPtr outdata = gcHandle2.AddrOfPinnedObject();
                tpcTool.foo(data, outdata, _xSize, _ySize, decodeCmd);
                gcHandle1.Free();
                gcHandle2.Free();
            }

            if (_dataSize == 0 & _encoding1 == 2 & _mipmapCnt == 1) ShowImage(3, PixelFormat.Format24bppRgb);
            else if (_dataSize == 0 & _encoding1 == 4 & _mipmapCnt == 1)
            {
                ShowImage(4, PixelFormat.Format32bppArgb);
            }
            else
            {
                ShowImage(4, PixelFormat.Format32bppArgb);
                int byteIndex = 128 + MipLevel2Bytes(_mipmapCnt, _encoding1 * 4);
                ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                object o1 = TpcData.Length - byteIndex;
                _tbImageInfo.Text = ObjectType.ObjTst(o1, 0, false) <= 0 ? "" : asciiEncoding.GetString(TpcData, byteIndex, IntegerType.FromObject(o1));
            }

            _lblMipMapCount.Text = StringType.FromInteger(_mipmapCnt);
            _lblFlag1.Text = Strings.Format(_flag1, "x");
            _lblFlag2.Text = Strings.Format(_flag2, "x");
            _lblFlag3.Text = Strings.Format(_flag3, "x");
            _lblFlag4.Text = Strings.Format(_flag4, "x");
        }


        private int MipLevel2Bytes(int miplevel, int dxtBytesPerTexel)
        {
            int num = 0;
            switch (miplevel)
            {
                case 1:
                    num = 16;
                    break;
                case 2:
                    num = 32;
                    break;
                case 3:
                    num = 48;
                    break;
                case 4:
                    num = 112;
                    break;
                case 5:
                    num = 368;
                    break;
                case 6:
                    num = 1392;
                    break;
                case 7:
                    num = 5488;
                    break;
                case 8:
                    num = 21872;
                    break;
                case 9:
                    num = 87408;
                    break;
                case 10:
                    num = 349552;
                    break;
                case 11:
                    num = 1398128;
                    break;
            }

            return (int) Math.Round(num / 16.0 / dxtBytesPerTexel);
        }


        public void ShowImage(int BytesPerPixel, PixelFormat pxFormat)
        {
            if (_ghImage.IsAllocated)
                _ghImage.Free();
            _ghImage = GCHandle.Alloc((object)this.Pixeldata, GCHandleType.Pinned);
            IntPtr scan0 = _ghImage.AddrOfPinnedObject();
            try
            {
                _pbox.Image = (Image)new Bitmap((int)this._xSize, (int)this._ySize, checked(BytesPerPixel * (int)this._xSize), pxFormat, scan0);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox((object)"Cannot view this image", MsgBoxStyle.Critical, (object)"Weirdness Alert");
                ProjectData.ClearProjectError();
            }
            _pbox.Size = new Size((int)this._xSize, (int)this._ySize);
            _bitsPerPixel = checked((short)(BytesPerPixel * 8));
            //_ext = "Image Viewer: " + _fName;
        }

        private void FlipImageVertically(ref Array pixelData, int stride, int ySize)
        {
            Array instance = new Byte[stride];
            int num1 = 0;
            int num2 = (int) Math.Round(ySize / 2.0 - 1.0);
            int num3 = num1;
            while (num3 <= num2)
            {
                Array.Copy(pixelData, num3 * stride, instance, 0, stride);
                Array.Copy(pixelData, ySize - num3 - 1 * stride, pixelData, num3 * stride, stride);
                Array.Copy(instance, 0, pixelData, ySize - num3 - 1 * stride, stride);
                ++num3;
            }
        }


        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, Strings.Mid(_fname, 1, _fname.IndexOf(".")) + ".tga", "Save TGA file...", "tga"));
            if (StringType.StrCmp(str, "", false) == 0) return;
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(str, FileMode.Create), Encoding.ASCII);
            binaryWriter.Write((byte) 0);
            binaryWriter.Write((byte) 0);
            binaryWriter.Write((byte) 2);
            binaryWriter.Write(0);
            binaryWriter.Write(0);
            binaryWriter.Write((byte) 0);
            binaryWriter.Write(_xSize);
            binaryWriter.Write(_ySize);
            binaryWriter.Write(_bitsPerPixel);
            if (_dataSize > 0)
            {
                Array pixeldata = Pixeldata;
                FlipImageVertically(ref pixeldata, 4 * _xSize, _ySize);
                Pixeldata = (byte[]) pixeldata;
                binaryWriter.Write(Pixeldata);
            }
            else binaryWriter.Write(TpcData);

            binaryWriter.Close();
            if (_tbImageInfo.SelectionLength <= 0 || !_chkbExportSelectionToTxIfile.Checked) return;
            StreamWriter streamWriter = new StreamWriter(new FileStream(Strings.Replace(str, ".tga", ".txi"), FileMode.Create), Encoding.ASCII);
            streamWriter.Write(_tbImageInfo.SelectedText);
            streamWriter.Close();
        }


        public void WriteTgaFile(string outputPath)
        {
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create), Encoding.ASCII);
            binaryWriter.Write((byte) 0);
            binaryWriter.Write((byte) 0);
            binaryWriter.Write((byte) 2);
            binaryWriter.Write(0);
            binaryWriter.Write(0);
            binaryWriter.Write((byte) 0);
            binaryWriter.Write(_xSize);
            binaryWriter.Write(_ySize);
            binaryWriter.Write(_bitsPerPixel);
            if (_dataSize > 0)
            {
                Array pixeldata = Pixeldata;
                FlipImageVertically(ref pixeldata, 4 * _xSize, _ySize);
                Pixeldata = (byte[]) pixeldata;
                binaryWriter.Write(Pixeldata);
            }
            else
            {
                binaryWriter.Write(TpcData);
            }

            binaryWriter.Close();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_ghImage.IsAllocated) _ghImage.Free();
            Hide();
        }


        private void SaveSettings()
        {
            ConfigOptions.WindowSettings.ImageViewerWindowLoc = ((Control) this).Location;
            ConfigOptions.WindowSettings.ImageViewerWindowSize = Size;
        }


        private void frmImageViewer_Load(object sender, EventArgs e)
        {
        }

        private void frmImageViewer_Closing(object sender, CancelEventArgs e)
        {
            SaveSettings();
        }

        public class Factory
        {
            public static void SetTpcDataAndShow()
            {
                
            }

            public static void ShowTgaImage(KotorTreeNode node)
            {
                Array data;
              
                /*Get data from Erf or Biff file */
                if (StringType.StrCmp(node.ContainingFileType, "ERF", false) == 0)
                {
                    data = new ErfObject().GetErfResource(node.FilePath, node);
                }
                else
                {
                    if (StringType.StrCmp(node.ContainingFileType, "BIF", false) != 0) return;
                    data = BiffFunctions.GetBiffResource(node.FilePath, node.LocalResId).Data;
                }

                if (Constants.GImageViewer == null || !Constants.GImageViewer.Created)
                {
                    Constants.GImageViewer = new FrmImageViewer();
                }

                Constants.GImageViewer.SetupTpcData(data, node.Filename);
                Constants.GImageViewer.DecodeImage();
                Constants.GImageViewer.Show();
            }
        }
    }
}