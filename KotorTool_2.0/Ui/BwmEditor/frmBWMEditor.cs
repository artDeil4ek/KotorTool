// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmBWMEditor
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.BwmEditor
{
    public class FrmBwmEditor : frmParent
    {
        [AccessedThroughProperty("miOpenAscii")]
        private MenuItem _miOpenAscii;

        [AccessedThroughProperty("miOpenBinary")]
        private MenuItem _miOpenBinary;

        [AccessedThroughProperty("MenuItem4")] private MenuItem _menuItem4;
        [AccessedThroughProperty("nudUnk4z")] private NumericUpDown _nudUnk4Z;
        [AccessedThroughProperty("Label6")] private Label _label6;
        [AccessedThroughProperty("nudUnk5y")] private NumericUpDown _nudUnk5Y;
        [AccessedThroughProperty("Label2")] private Label _label2;
        [AccessedThroughProperty("nudUnk4y")] private NumericUpDown _nudUnk4Y;
        [AccessedThroughProperty("miQuit")] private MenuItem _miQuit;
        [AccessedThroughProperty("nudUnk5z")] private NumericUpDown _nudUnk5Z;
        [AccessedThroughProperty("nudUnk4x")] private NumericUpDown _nudUnk4X;
        [AccessedThroughProperty("nudUnk5x")] private NumericUpDown _nudUnk5X;
        [AccessedThroughProperty("nudUnk3z")] private NumericUpDown _nudUnk3Z;
        [AccessedThroughProperty("nudUnk3y")] private NumericUpDown _nudUnk3Y;

        [AccessedThroughProperty("tbFilepath")]
        private TextBox _tbFilepath;

        [AccessedThroughProperty("GroupBox1")] private GroupBox _groupBox1;
        [AccessedThroughProperty("MenuItem1")] private MenuItem _menuItem1;
        [AccessedThroughProperty("nudUnk3x")] private NumericUpDown _nudUnk3X;
        [AccessedThroughProperty("ToolTip1")] private ToolTip _toolTip1;
        [AccessedThroughProperty("MainMenu1")] private MainMenu _mainMenu1;

        [AccessedThroughProperty("miSaveAsBinary")]
        private MenuItem _miSaveAsBinary;

        [AccessedThroughProperty("miSaveAsASCII")]
        private MenuItem _miSaveAsAscii;

        [AccessedThroughProperty("lblNotSupported")]
        private Label _lblNotSupported;

        [AccessedThroughProperty("nudUnk1")] private NumericUpDown _nudUnk1;
        [AccessedThroughProperty("Label1")] private Label _label1;
        [AccessedThroughProperty("Label3")] private Label _label3;
        [AccessedThroughProperty("Label4")] private Label _label4;
        [AccessedThroughProperty("Label5")] private Label _label5;
        [AccessedThroughProperty("nudUnk2z")] private NumericUpDown _nudUnk2Z;
        [AccessedThroughProperty("tbInfo")] private TextBox _tbInfo;
        [AccessedThroughProperty("nudUnk2x")] private NumericUpDown _nudUnk2X;
        [AccessedThroughProperty("nudUnk2y")] private NumericUpDown _nudUnk2Y;
        private IContainer components;
        private ClsBwm _walk;
        private string _filepath;

        internal virtual NumericUpDown NudUnk2X
        {
            get => _nudUnk2X;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk2X == null)
                    ;
                _nudUnk2X = value;
                if (_nudUnk2X != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk2Y
        {
            get => _nudUnk2Y;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk2Y == null)
                    ;
                _nudUnk2Y = value;
                if (_nudUnk2Y != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk2Z
        {
            get => _nudUnk2Z;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk2Z == null)
                    ;
                _nudUnk2Z = value;
                if (_nudUnk2Z != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk1
        {
            get => _nudUnk1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk1 == null)
                    ;
                _nudUnk1 = value;
                if (_nudUnk1 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk3X
        {
            get => _nudUnk3X;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk3X == null)
                    ;
                _nudUnk3X = value;
                if (_nudUnk3X != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk3Y
        {
            get => _nudUnk3Y;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk3Y == null)
                    ;
                _nudUnk3Y = value;
                if (_nudUnk3Y != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk3Z
        {
            get => _nudUnk3Z;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk3Z == null)
                    ;
                _nudUnk3Z = value;
                if (_nudUnk3Z != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk5X
        {
            get => _nudUnk5X;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk5X == null)
                    ;
                _nudUnk5X = value;
                if (_nudUnk5X != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk4X
        {
            get => _nudUnk4X;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk4X == null)
                    ;
                _nudUnk4X = value;
                if (_nudUnk4X != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk5Z
        {
            get => _nudUnk5Z;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk5Z == null)
                    ;
                _nudUnk5Z = value;
                if (_nudUnk5Z != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk4Y
        {
            get => _nudUnk4Y;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk4Y == null)
                    ;
                _nudUnk4Y = value;
                if (_nudUnk4Y != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk5Y
        {
            get => _nudUnk5Y;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk5Y == null)
                    ;
                _nudUnk5Y = value;
                if (_nudUnk5Y != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudUnk4Z
        {
            get => _nudUnk4Z;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudUnk4Z == null)
                    ;
                _nudUnk4Z = value;
                if (_nudUnk4Z != null)
                    ;
            }
        }

        internal virtual MainMenu MainMenu1
        {
            get => _mainMenu1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mainMenu1 == null)
                    ;
                _mainMenu1 = value;
                if (_mainMenu1 != null)
                    ;
            }
        }

        internal virtual MenuItem MenuItem1
        {
            get => _menuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem1 == null)
                    ;
                _menuItem1 = value;
                if (_menuItem1 != null)
                    ;
            }
        }

        internal virtual MenuItem MenuItem4
        {
            get => _menuItem4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem4 == null)
                    ;
                _menuItem4 = value;
                if (_menuItem4 != null)
                    ;
            }
        }

        internal virtual MenuItem MiQuit
        {
            get => _miQuit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miQuit != null)
                    _miQuit.Click -= miQuit_Click;
                _miQuit = value;
                if (_miQuit == null)
                    return;
                _miQuit.Click += miQuit_Click;
            }
        }

        internal virtual MenuItem MiOpenBinary
        {
            get => _miOpenBinary;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miOpenBinary != null)
                    _miOpenBinary.Click -= miOpenBinary_Click;
                _miOpenBinary = value;
                if (_miOpenBinary == null)
                    return;
                _miOpenBinary.Click += miOpenBinary_Click;
            }
        }

        internal virtual Label Label1
        {
            get => _label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label1 == null)
                    ;
                _label1 = value;
                if (_label1 != null)
                    ;
            }
        }

        internal virtual Label Label2
        {
            get => _label2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label2 == null)
                    ;
                _label2 = value;
                if (_label2 != null)
                    ;
            }
        }

        internal virtual Label Label3
        {
            get => _label3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label3 == null)
                    ;
                _label3 = value;
                if (_label3 != null)
                    ;
            }
        }

        internal virtual Label Label4
        {
            get => _label4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label5 == null)
                    ;
                _label5 = value;
                if (_label5 != null)
                    ;
            }
        }

        internal virtual MenuItem MiOpenAscii
        {
            get => _miOpenAscii;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miOpenAscii != null)
                    _miOpenAscii.Click -= miOpenAscii_Click;
                _miOpenAscii = value;
                if (_miOpenAscii == null)
                    return;
                _miOpenAscii.Click += miOpenAscii_Click;
            }
        }

        internal virtual TextBox TbInfo
        {
            get => _tbInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbInfo == null)
                    ;
                _tbInfo = value;
                if (_tbInfo != null)
                    ;
            }
        }

        internal virtual TextBox TbFilepath
        {
            get => _tbFilepath;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbFilepath == null)
                    ;
                _tbFilepath = value;
                if (_tbFilepath != null)
                    ;
            }
        }

        internal virtual Label Label6
        {
            get => _label6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label6 == null)
                    ;
                _label6 = value;
                if (_label6 != null)
                    ;
            }
        }

        internal virtual GroupBox GroupBox1
        {
            get => _groupBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_groupBox1 == null)
                    ;
                _groupBox1 = value;
                if (_groupBox1 != null)
                    ;
            }
        }

        internal virtual ToolTip ToolTip1
        {
            get => _toolTip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_toolTip1 == null)
                    ;
                _toolTip1 = value;
                if (_toolTip1 != null)
                    ;
            }
        }

        internal virtual MenuItem MiSaveAsBinary
        {
            get => _miSaveAsBinary;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSaveAsBinary != null)
                    _miSaveAsBinary.Click -= miSaveAsBinary_Click;
                _miSaveAsBinary = value;
                if (_miSaveAsBinary == null)
                    return;
                _miSaveAsBinary.Click += miSaveAsBinary_Click;
            }
        }

        internal virtual MenuItem MiSaveAsAscii
        {
            get => _miSaveAsAscii;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSaveAsAscii != null)
                    _miSaveAsAscii.Click -= miSaveAsASCII_Click;
                _miSaveAsAscii = value;
                if (_miSaveAsAscii == null)
                    return;
                _miSaveAsAscii.Click += miSaveAsASCII_Click;
            }
        }

        internal virtual Label LblNotSupported
        {
            get => _lblNotSupported;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblNotSupported == null)
                    ;
                _lblNotSupported = value;
                if (_lblNotSupported != null)
                    ;
            }
        }

        public FrmBwmEditor()
        {
            InitializeComponent();
        }

        public FrmBwmEditor(byte[] data, string filename)
            : this()
        {
            _walk = new ClsBwm(data);
            DisplayInfo();
            TbFilepath.Text = filename;
            _filepath = filename;
            ShowMsgIfNotSupported(filename);
            EnableSaveMenus();
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
            NudUnk2X = new NumericUpDown();
            NudUnk2Y = new NumericUpDown();
            NudUnk2Z = new NumericUpDown();
            NudUnk1 = new NumericUpDown();
            NudUnk3X = new NumericUpDown();
            NudUnk3Y = new NumericUpDown();
            NudUnk3Z = new NumericUpDown();
            NudUnk5X = new NumericUpDown();
            NudUnk4X = new NumericUpDown();
            NudUnk5Z = new NumericUpDown();
            NudUnk4Y = new NumericUpDown();
            NudUnk5Y = new NumericUpDown();
            NudUnk4Z = new NumericUpDown();
            MainMenu1 = new MainMenu();
            MenuItem1 = new MenuItem();
            MiOpenBinary = new MenuItem();
            MiOpenAscii = new MenuItem();
            MiSaveAsBinary = new MenuItem();
            MiSaveAsAscii = new MenuItem();
            MenuItem4 = new MenuItem();
            MiQuit = new MenuItem();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            TbInfo = new TextBox();
            TbFilepath = new TextBox();
            Label6 = new Label();
            GroupBox1 = new GroupBox();
            ToolTip1 = new ToolTip(components);
            LblNotSupported = new Label();
            NudUnk2X.BeginInit();
            NudUnk2Y.BeginInit();
            NudUnk2Z.BeginInit();
            NudUnk1.BeginInit();
            NudUnk3X.BeginInit();
            NudUnk3Y.BeginInit();
            NudUnk3Z.BeginInit();
            NudUnk5X.BeginInit();
            NudUnk4X.BeginInit();
            NudUnk5Z.BeginInit();
            NudUnk4Y.BeginInit();
            NudUnk5Y.BeginInit();
            NudUnk4Z.BeginInit();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            NudUnk2X.DecimalPlaces = 6;
            NumericUpDown nudUnk2X1 = NudUnk2X;
            Point point1 = new Point(96, 48);
            Point point2 = point1;
            nudUnk2X1.Location = point2;
            NumericUpDown nudUnk2X2 = NudUnk2X;
            Decimal num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num2 = num1;
            nudUnk2X2.Maximum = num2;
            NumericUpDown nudUnk2X3 = NudUnk2X;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num3 = num1;
            nudUnk2X3.Minimum = num3;
            NudUnk2X.Name = "nudUnk2x";
            NumericUpDown nudUnk2X4 = NudUnk2X;
            Size size1 = new Size(88, 20);
            Size size2 = size1;
            nudUnk2X4.Size = size2;
            NudUnk2X.TabIndex = 0;
            NudUnk2X.TextAlign = HorizontalAlignment.Right;
            NudUnk2Y.DecimalPlaces = 6;
            NumericUpDown nudUnk2Y1 = NudUnk2Y;
            point1 = new Point(192, 48);
            Point point3 = point1;
            nudUnk2Y1.Location = point3;
            NumericUpDown nudUnk2Y2 = NudUnk2Y;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num4 = num1;
            nudUnk2Y2.Maximum = num4;
            NumericUpDown nudUnk2Y3 = NudUnk2Y;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num5 = num1;
            nudUnk2Y3.Minimum = num5;
            NudUnk2Y.Name = "nudUnk2y";
            NumericUpDown nudUnk2Y4 = NudUnk2Y;
            size1 = new Size(88, 20);
            Size size3 = size1;
            nudUnk2Y4.Size = size3;
            NudUnk2Y.TabIndex = 0;
            NudUnk2Y.TextAlign = HorizontalAlignment.Right;
            NudUnk2Z.DecimalPlaces = 6;
            NumericUpDown nudUnk2Z1 = NudUnk2Z;
            point1 = new Point(288, 48);
            Point point4 = point1;
            nudUnk2Z1.Location = point4;
            NumericUpDown nudUnk2Z2 = NudUnk2Z;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num6 = num1;
            nudUnk2Z2.Maximum = num6;
            NumericUpDown nudUnk2Z3 = NudUnk2Z;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num7 = num1;
            nudUnk2Z3.Minimum = num7;
            NudUnk2Z.Name = "nudUnk2z";
            NumericUpDown nudUnk2Z4 = NudUnk2Z;
            size1 = new Size(88, 20);
            Size size4 = size1;
            nudUnk2Z4.Size = size4;
            NudUnk2Z.TabIndex = 0;
            NudUnk2Z.TextAlign = HorizontalAlignment.Right;
            NudUnk1.DecimalPlaces = 6;
            NumericUpDown nudUnk11 = NudUnk1;
            point1 = new Point(96, 24);
            Point point5 = point1;
            nudUnk11.Location = point5;
            NumericUpDown nudUnk12 = NudUnk1;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num8 = num1;
            nudUnk12.Maximum = num8;
            NumericUpDown nudUnk13 = NudUnk1;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num9 = num1;
            nudUnk13.Minimum = num9;
            NudUnk1.Name = "nudUnk1";
            NumericUpDown nudUnk14 = NudUnk1;
            size1 = new Size(88, 20);
            Size size5 = size1;
            nudUnk14.Size = size5;
            NudUnk1.TabIndex = 0;
            NudUnk1.TextAlign = HorizontalAlignment.Right;
            NudUnk3X.DecimalPlaces = 6;
            NumericUpDown nudUnk3X1 = NudUnk3X;
            point1 = new Point(96, 72);
            Point point6 = point1;
            nudUnk3X1.Location = point6;
            NumericUpDown nudUnk3X2 = NudUnk3X;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num10 = num1;
            nudUnk3X2.Maximum = num10;
            NumericUpDown nudUnk3X3 = NudUnk3X;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num11 = num1;
            nudUnk3X3.Minimum = num11;
            NudUnk3X.Name = "nudUnk3x";
            NumericUpDown nudUnk3X4 = NudUnk3X;
            size1 = new Size(88, 20);
            Size size6 = size1;
            nudUnk3X4.Size = size6;
            NudUnk3X.TabIndex = 3;
            NudUnk3X.TextAlign = HorizontalAlignment.Right;
            NudUnk3Y.DecimalPlaces = 6;
            NumericUpDown nudUnk3Y1 = NudUnk3Y;
            point1 = new Point(192, 72);
            Point point7 = point1;
            nudUnk3Y1.Location = point7;
            NumericUpDown nudUnk3Y2 = NudUnk3Y;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num12 = num1;
            nudUnk3Y2.Maximum = num12;
            NumericUpDown nudUnk3Y3 = NudUnk3Y;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num13 = num1;
            nudUnk3Y3.Minimum = num13;
            NudUnk3Y.Name = "nudUnk3y";
            NumericUpDown nudUnk3Y4 = NudUnk3Y;
            size1 = new Size(88, 20);
            Size size7 = size1;
            nudUnk3Y4.Size = size7;
            NudUnk3Y.TabIndex = 2;
            NudUnk3Y.TextAlign = HorizontalAlignment.Right;
            NudUnk3Z.DecimalPlaces = 6;
            NumericUpDown nudUnk3Z1 = NudUnk3Z;
            point1 = new Point(288, 72);
            Point point8 = point1;
            nudUnk3Z1.Location = point8;
            NumericUpDown nudUnk3Z2 = NudUnk3Z;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num14 = num1;
            nudUnk3Z2.Maximum = num14;
            NumericUpDown nudUnk3Z3 = NudUnk3Z;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num15 = num1;
            nudUnk3Z3.Minimum = num15;
            NudUnk3Z.Name = "nudUnk3z";
            NumericUpDown nudUnk3Z4 = NudUnk3Z;
            size1 = new Size(88, 20);
            Size size8 = size1;
            nudUnk3Z4.Size = size8;
            NudUnk3Z.TabIndex = 1;
            NudUnk3Z.TextAlign = HorizontalAlignment.Right;
            NudUnk5X.DecimalPlaces = 6;
            NumericUpDown nudUnk5X1 = NudUnk5X;
            point1 = new Point(96, 120);
            Point point9 = point1;
            nudUnk5X1.Location = point9;
            NumericUpDown nudUnk5X2 = NudUnk5X;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num16 = num1;
            nudUnk5X2.Maximum = num16;
            NumericUpDown nudUnk5X3 = NudUnk5X;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num17 = num1;
            nudUnk5X3.Minimum = num17;
            NudUnk5X.Name = "nudUnk5x";
            NumericUpDown nudUnk5X4 = NudUnk5X;
            size1 = new Size(88, 20);
            Size size9 = size1;
            nudUnk5X4.Size = size9;
            NudUnk5X.TabIndex = 3;
            NudUnk5X.TextAlign = HorizontalAlignment.Right;
            NudUnk4X.DecimalPlaces = 6;
            NumericUpDown nudUnk4X1 = NudUnk4X;
            point1 = new Point(96, 96);
            Point point10 = point1;
            nudUnk4X1.Location = point10;
            NumericUpDown nudUnk4X2 = NudUnk4X;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num18 = num1;
            nudUnk4X2.Maximum = num18;
            NumericUpDown nudUnk4X3 = NudUnk4X;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num19 = num1;
            nudUnk4X3.Minimum = num19;
            NudUnk4X.Name = "nudUnk4x";
            NumericUpDown nudUnk4X4 = NudUnk4X;
            size1 = new Size(88, 20);
            Size size10 = size1;
            nudUnk4X4.Size = size10;
            NudUnk4X.TabIndex = 0;
            NudUnk4X.TextAlign = HorizontalAlignment.Right;
            NudUnk5Z.DecimalPlaces = 6;
            NumericUpDown nudUnk5Z1 = NudUnk5Z;
            point1 = new Point(288, 120);
            Point point11 = point1;
            nudUnk5Z1.Location = point11;
            NumericUpDown nudUnk5Z2 = NudUnk5Z;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num20 = num1;
            nudUnk5Z2.Maximum = num20;
            NumericUpDown nudUnk5Z3 = NudUnk5Z;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num21 = num1;
            nudUnk5Z3.Minimum = num21;
            NudUnk5Z.Name = "nudUnk5z";
            NumericUpDown nudUnk5Z4 = NudUnk5Z;
            size1 = new Size(88, 20);
            Size size11 = size1;
            nudUnk5Z4.Size = size11;
            NudUnk5Z.TabIndex = 1;
            NudUnk5Z.TextAlign = HorizontalAlignment.Right;
            NudUnk4Y.DecimalPlaces = 6;
            NumericUpDown nudUnk4Y1 = NudUnk4Y;
            point1 = new Point(192, 96);
            Point point12 = point1;
            nudUnk4Y1.Location = point12;
            NumericUpDown nudUnk4Y2 = NudUnk4Y;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num22 = num1;
            nudUnk4Y2.Maximum = num22;
            NumericUpDown nudUnk4Y3 = NudUnk4Y;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num23 = num1;
            nudUnk4Y3.Minimum = num23;
            NudUnk4Y.Name = "nudUnk4y";
            NumericUpDown nudUnk4Y4 = NudUnk4Y;
            size1 = new Size(88, 20);
            Size size12 = size1;
            nudUnk4Y4.Size = size12;
            NudUnk4Y.TabIndex = 0;
            NudUnk4Y.TextAlign = HorizontalAlignment.Right;
            NudUnk5Y.DecimalPlaces = 6;
            NumericUpDown nudUnk5Y1 = NudUnk5Y;
            point1 = new Point(192, 120);
            Point point13 = point1;
            nudUnk5Y1.Location = point13;
            NumericUpDown nudUnk5Y2 = NudUnk5Y;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num24 = num1;
            nudUnk5Y2.Maximum = num24;
            NumericUpDown nudUnk5Y3 = NudUnk5Y;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num25 = num1;
            nudUnk5Y3.Minimum = num25;
            NudUnk5Y.Name = "nudUnk5y";
            NumericUpDown nudUnk5Y4 = NudUnk5Y;
            size1 = new Size(88, 20);
            Size size13 = size1;
            nudUnk5Y4.Size = size13;
            NudUnk5Y.TabIndex = 2;
            NudUnk5Y.TextAlign = HorizontalAlignment.Right;
            NudUnk4Z.DecimalPlaces = 6;
            NumericUpDown nudUnk4Z1 = NudUnk4Z;
            point1 = new Point(288, 96);
            Point point14 = point1;
            nudUnk4Z1.Location = point14;
            NumericUpDown nudUnk4Z2 = NudUnk4Z;
            num1 = new Decimal(new int[4] {1000, 0, 0, 0});
            Decimal num26 = num1;
            nudUnk4Z2.Maximum = num26;
            NumericUpDown nudUnk4Z3 = NudUnk4Z;
            num1 = new Decimal(new int[4]
            {
                1000,
                0,
                0,
                int.MinValue
            });
            Decimal num27 = num1;
            nudUnk4Z3.Minimum = num27;
            NudUnk4Z.Name = "nudUnk4z";
            NumericUpDown nudUnk4Z4 = NudUnk4Z;
            size1 = new Size(88, 20);
            Size size14 = size1;
            nudUnk4Z4.Size = size14;
            NudUnk4Z.TabIndex = 0;
            NudUnk4Z.TextAlign = HorizontalAlignment.Right;
            MainMenu1.MenuItems.AddRange(new MenuItem[1]
            {
                MenuItem1
            });
            MenuItem1.Index = 0;
            MenuItem1.MenuItems.AddRange(new MenuItem[6]
            {
                MiOpenBinary,
                MiOpenAscii,
                MiSaveAsBinary,
                MiSaveAsAscii,
                MenuItem4,
                MiQuit
            });
            MenuItem1.Text = "&File";
            MiOpenBinary.Index = 0;
            MiOpenBinary.Shortcut = Shortcut.CtrlO;
            MiOpenBinary.Text = "&Open Binary PWK...";
            MiOpenAscii.Index = 1;
            MiOpenAscii.Text = "Open &ASCII PWK...";
            MiSaveAsBinary.Enabled = false;
            MiSaveAsBinary.Index = 2;
            MiSaveAsBinary.Shortcut = Shortcut.CtrlS;
            MiSaveAsBinary.Text = "&Save as Binary...";
            MiSaveAsAscii.Enabled = false;
            MiSaveAsAscii.Index = 3;
            MiSaveAsAscii.Text = "Save as AS&CII...";
            MenuItem4.Index = 4;
            MenuItem4.Text = "-";
            MiQuit.Index = 5;
            MiQuit.Shortcut = Shortcut.CtrlQ;
            MiQuit.Text = "&Quit";
            Label label11 = Label1;
            point1 = new Point(24, 24);
            Point point15 = point1;
            label11.Location = point15;
            Label1.Name = "Label1";
            Label label12 = Label1;
            size1 = new Size(56, 16);
            Size size15 = size1;
            label12.Size = size15;
            Label1.TabIndex = 4;
            Label1.Text = "1";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            Label label21 = Label2;
            point1 = new Point(24, 48);
            Point point16 = point1;
            label21.Location = point16;
            Label2.Name = "Label2";
            Label label22 = Label2;
            size1 = new Size(56, 16);
            Size size16 = size1;
            label22.Size = size16;
            Label2.TabIndex = 4;
            Label2.Text = "2";
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            Label label31 = Label3;
            point1 = new Point(24, 72);
            Point point17 = point1;
            label31.Location = point17;
            Label3.Name = "Label3";
            Label label32 = Label3;
            size1 = new Size(56, 16);
            Size size17 = size1;
            label32.Size = size17;
            Label3.TabIndex = 4;
            Label3.Text = "3";
            Label3.TextAlign = ContentAlignment.MiddleCenter;
            Label label41 = Label4;
            point1 = new Point(24, 96);
            Point point18 = point1;
            label41.Location = point18;
            Label4.Name = "Label4";
            Label label42 = Label4;
            size1 = new Size(56, 16);
            Size size18 = size1;
            label42.Size = size18;
            Label4.TabIndex = 4;
            Label4.Text = "4";
            Label4.TextAlign = ContentAlignment.MiddleCenter;
            Label label51 = Label5;
            point1 = new Point(24, 120);
            Point point19 = point1;
            label51.Location = point19;
            Label5.Name = "Label5";
            Label label52 = Label5;
            size1 = new Size(56, 16);
            Size size19 = size1;
            label52.Size = size19;
            Label5.TabIndex = 4;
            Label5.Text = "5";
            Label5.TextAlign = ContentAlignment.MiddleCenter;
            TbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbInfo.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox tbInfo1 = TbInfo;
            point1 = new Point(56, 240);
            Point point20 = point1;
            tbInfo1.Location = point20;
            TbInfo.Multiline = true;
            TbInfo.Name = "tbInfo";
            TbInfo.ReadOnly = true;
            TbInfo.ScrollBars = ScrollBars.Vertical;
            TextBox tbInfo2 = TbInfo;
            size1 = new Size(344, 200);
            Size size20 = size1;
            tbInfo2.Size = size20;
            TbInfo.TabIndex = 5;
            TbInfo.Text = "";
            TextBox tbFilepath1 = TbFilepath;
            point1 = new Point(108, 8);
            Point point21 = point1;
            tbFilepath1.Location = point21;
            TbFilepath.Name = "tbFilepath";
            TextBox tbFilepath2 = TbFilepath;
            size1 = new Size(240, 20);
            Size size21 = size1;
            tbFilepath2.Size = size21;
            TbFilepath.TabIndex = 6;
            TbFilepath.Text = "";
            Label label61 = Label6;
            point1 = new Point(32, 8);
            Point point22 = point1;
            label61.Location = point22;
            Label6.Name = "Label6";
            Label label62 = Label6;
            size1 = new Size(56, 16);
            Size size22 = size1;
            label62.Size = size22;
            Label6.TabIndex = 4;
            Label6.Text = "File name";
            Label6.TextAlign = ContentAlignment.MiddleCenter;
            GroupBox1.Controls.Add(NudUnk3Y);
            GroupBox1.Controls.Add(NudUnk3X);
            GroupBox1.Controls.Add(NudUnk1);
            GroupBox1.Controls.Add(NudUnk2Z);
            GroupBox1.Controls.Add(NudUnk2Y);
            GroupBox1.Controls.Add(NudUnk2X);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Label5);
            GroupBox1.Controls.Add(NudUnk4Z);
            GroupBox1.Controls.Add(NudUnk5Y);
            GroupBox1.Controls.Add(NudUnk4Y);
            GroupBox1.Controls.Add(NudUnk5Z);
            GroupBox1.Controls.Add(NudUnk4X);
            GroupBox1.Controls.Add(NudUnk5X);
            GroupBox1.Controls.Add(NudUnk3Z);
            GroupBox groupBox11 = GroupBox1;
            point1 = new Point(28, 64);
            Point point23 = point1;
            groupBox11.Location = point23;
            GroupBox1.Name = "GroupBox1";
            GroupBox groupBox12 = GroupBox1;
            size1 = new Size(400, 160);
            Size size23 = size1;
            groupBox12.Size = size23;
            GroupBox1.TabIndex = 7;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Unknown data";
            ToolTip1.SetToolTip(GroupBox1, "This box contains data the purpose of which is unknown. You can edit these values and see what effect they have in the game.");
            Label lblNotSupported1 = LblNotSupported;
            point1 = new Point(120, 40);
            Point point24 = point1;
            lblNotSupported1.Location = point24;
            LblNotSupported.Name = "lblNotSupported";
            Label lblNotSupported2 = LblNotSupported;
            size1 = new Size(216, 16);
            Size size24 = size1;
            lblNotSupported2.Size = size24;
            LblNotSupported.TabIndex = 8;
            LblNotSupported.TextAlign = ContentAlignment.MiddleCenter;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(456, 457);
            ClientSize = size1;
            Controls.Add(LblNotSupported);
            Controls.Add(GroupBox1);
            Controls.Add(TbFilepath);
            Controls.Add(TbInfo);
            Controls.Add(Label6);
            Menu = MainMenu1;
            Name = "FrmBwmEditor";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "PWK/DWK Editor";
            NudUnk2X.EndInit();
            NudUnk2Y.EndInit();
            NudUnk2Z.EndInit();
            NudUnk1.EndInit();
            NudUnk3X.EndInit();
            NudUnk3Y.EndInit();
            NudUnk3Z.EndInit();
            NudUnk5X.EndInit();
            NudUnk4X.EndInit();
            NudUnk5Z.EndInit();
            NudUnk4Y.EndInit();
            NudUnk5Y.EndInit();
            NudUnk4Z.EndInit();
            GroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void miOpenBinary_Click(object sender, EventArgs e)
        {
            _filepath = StringType.FromObject(FileUtils.GetFilePath("load", StringType.StrCmp(_filepath, "", false) != 0 ? _filepath : ConfigOptions.Paths.DefaultImportLocation, "*.pwk", "Select a binary PWK/DWK file", "pwk"));
            if (StringType.StrCmp(_filepath, "", false) == 0)
                return;
            try
            {
                _walk = new ClsBwm(_filepath);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PWK Editor Error");
                ProjectData.ClearProjectError();
                return;
            }

            DisplayInfo();
            TbFilepath.Text = _filepath;
            ShowMsgIfNotSupported(_filepath);
            EnableSaveMenus();
        }

        private void miOpenAscii_Click(object sender, EventArgs e)
        {
            _filepath = StringType.FromObject(FileUtils.GetFilePath("load", StringType.StrCmp(_filepath, "", false) != 0 ? _filepath : ConfigOptions.Paths.DefaultImportLocation, "", "Select an ASCII PWK/DWK/WOK file", "pwk"));
            if (StringType.StrCmp(_filepath, "", false) == 0) return;
            _walk = new ClsBwm();
            try
            {
                _walk.ParseAsciiWalkMesh(_filepath);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PWK Editor Error");
                ProjectData.ClearProjectError();
                return;
            }

            DisplayInfo();
            TbFilepath.Text = _filepath;
            ShowMsgIfNotSupported(_filepath);
            EnableSaveMenus();
        }

        private void miSaveAsBinary_Click(object sender, EventArgs e)
        {
            string startPath;
            string suggFilename;
            if (StringType.StrCmp(_filepath, "", false) == 0)
            {
                startPath = ConfigOptions.Paths.DefaultSaveLocation;
                suggFilename = "*.pwk";
            }
            else
            {
                startPath = Path.GetDirectoryName(_filepath);
                suggFilename = Path.GetFileName(_filepath);
            }

            _filepath = StringType.FromObject(FileUtils.GetFilePath("save", startPath, suggFilename, "Save binary PWK/DWK file", "pwk"));
            if (StringType.StrCmp(_filepath, "", false) == 0) return;
            _walk.WriteBinary(_filepath);
            TbFilepath.Text = _filepath;
        }

        private void miSaveAsASCII_Click(object sender, EventArgs e)
        {
            string startPath;
            string suggFilename;
            if (StringType.StrCmp(_filepath, "", false) == 0)
            {
                startPath = ConfigOptions.Paths.DefaultSaveLocation;
                suggFilename = "*.pwk";
            }
            else
            {
                startPath = Path.GetDirectoryName(_filepath);
                suggFilename = Path.GetFileName(_filepath);
            }

            _filepath = StringType.FromObject(FileUtils.GetFilePath("save", startPath, suggFilename, "Save ASCII PWK/DWK file", "pwk"));
            if (StringType.StrCmp(_filepath, "", false) == 0) return;
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.lblMsg.Text = "Enter name to use for Walkmesh Parent or click OK to use default";
            if (frmPromptForString.ShowDialog() != DialogResult.OK) return;
            if (StringType.StrCmp(frmPromptForString.tbValue.Text.Trim(), "", false) != 0) _walk.WriteAscii(_filepath, frmPromptForString.tbValue.Text.Trim());
            else _walk.WriteAscii(_filepath);
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowMsgIfNotSupported(object filepath)
        {
            if (BooleanType.FromObject(LateBinding.LateGet(LateBinding.LateGet(filepath, null, "ToLower", new object[0], null, null), null, "EndsWith", new object[1] {"dwk"}, null, null))) LblNotSupported.Text = "DWK files are not fully supported";
            else LblNotSupported.Text = "";
        }

        private void EnableSaveMenus()
        {
            MiSaveAsAscii.Enabled = true;
            MiSaveAsBinary.Enabled = true;
        }

        private void DisplayInfo()
        {
            StringBuilder stringBuilder = new StringBuilder(300);
            NudUnk1.Value = new Decimal(_walk.UnkSingles[0]);
            NudUnk2X.Value = new Decimal(_walk.UnkSingles[1]);
            NudUnk2Y.Value = new Decimal(_walk.UnkSingles[2]);
            NudUnk2Z.Value = new Decimal(_walk.UnkSingles[3]);
            NudUnk3X.Value = new Decimal(_walk.UnkSingles[4]);
            NudUnk3Y.Value = new Decimal(_walk.UnkSingles[5]);
            NudUnk3Z.Value = new Decimal(_walk.UnkSingles[6]);
            NudUnk4X.Value = new Decimal(_walk.UnkSingles[7]);
            NudUnk4Y.Value = new Decimal(_walk.UnkSingles[8]);
            NudUnk4Z.Value = new Decimal(_walk.UnkSingles[9]);
            NudUnk5X.Value = new Decimal(_walk.UnkSingles[10]);
            NudUnk5Y.Value = new Decimal(_walk.UnkSingles[11]);
            NudUnk5Z.Value = new Decimal(_walk.UnkSingles[12]);
            TbInfo.Text = "";
            stringBuilder.Append("Verts: " + StringType.FromInteger(_walk.Verts.Length) + "\r\n");
            int num1 = 0;
            int num2 = _walk.Verts.Length - 1;
            int index1 = num1;
            while (index1 <= num2)
            {
                stringBuilder.AppendFormat("{0,10:f4}", _walk.Verts[index1].X);
                stringBuilder.AppendFormat("{0,10:f4}", _walk.Verts[index1].Y);
                stringBuilder.AppendFormat("{0,10:f4}", _walk.Verts[index1].Z);
                stringBuilder.Append("\r\n");
                ++index1;
            }

            stringBuilder.Append("\r\n");
            stringBuilder.Append("Faces: " + StringType.FromInteger(_walk.Faces.Length) + "\r\n");
            int num3 = 0;
            int num4 = _walk.Faces.Length - 1;
            int index2 = num3;
            while (index2 <= num4)
            {
                stringBuilder.AppendFormat("{0,4:d}", _walk.Faces[index2].V1);
                stringBuilder.AppendFormat("{0,4:d}", _walk.Faces[index2].V2);
                stringBuilder.AppendFormat("{0,4:d}", _walk.Faces[index2].V3);
                stringBuilder.Append("\r\n");
                ++index2;
            }

            stringBuilder.Append("\r\n");
            stringBuilder.Append("Walk Types: " + StringType.FromInteger(_walk.Faces.Length) + "\r\n");
            int num5 = 0;
            int num6 = _walk.Faces.Length - 1;
            int index3 = num5;
            while (index3 <= num6)
            {
                stringBuilder.Append(StringType.FromInteger(_walk.WalkTypes[index3]) + " (" + WalkTypeString(_walk.WalkTypes[index3]) + ")\r\n");
                ++index3;
            }

            stringBuilder.Append("\r\n");
            if (_walk.AabbNodes != null && _walk.AabbNodes.Length > 0)
            {
                stringBuilder.Append("AABB Nodes: " + StringType.FromInteger(_walk.AabbNodes.Length) + "\r\n");
                int num7 = 0;
                int num8 = _walk.AabbNodes.Length - 1;
                int num9 = num7;
                while (num9 <= num8)
                {
                    ClsBwm walk = _walk;
                    int index4 = num9;
                    stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMin.X);
                    stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMin.Y);
                    stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMin.Z);
                    stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMax.X);
                    stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMax.Y);
                    stringBuilder.AppendFormat("{0,10:f4}", walk.AabbNodes[index4].BBoxMax.Z);
                    stringBuilder.AppendFormat("{0,3:d}", walk.AabbNodes[index4].LeafFacePartNumber);
                    stringBuilder.Append("\r\n");
                    ++num9;
                }
            }

            TbInfo.Text = stringBuilder.ToString();
            TbInfo.SelectionLength = 0;
        }

        private string WalkTypeString(int walktype)
        {
            switch (walktype)
            {
                case 0: return "Not Defined";
                case 1: return "Dirt";
                case 2: return "Obscuring";
                case 3: return "Grass";
                case 4: return "Stone";
                case 5: return "Wood";
                case 6: return "Water";
                case 7: return "Non-walk";
                case 8: return "Transparent";
                case 9: return "Carpet";
                case 10: return "Metal";
                case 11: return "Puddles";
                case 12: return "Swamp";
                case 13: return "Mud";
                case 14: return "Leaves";
                case 15: return "Lava";
                case 16: return "BottomlessPit";
                case 17: return "DeepWater";
                case 18: return "Door";
                case 19: return "NonWalkGrass";
                default:
                    string str = "";
                    return str;
            }
        }
    }
}