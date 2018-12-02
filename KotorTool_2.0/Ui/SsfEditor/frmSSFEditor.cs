// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmSSFEditor
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.SsfEditor
{
    public class FrmSsfEditor : frmParent
    {
        [AccessedThroughProperty("TextBox30")] private TextBox _textBox30;
        [AccessedThroughProperty("TextBox41")] private TextBox _textBox41;
        [AccessedThroughProperty("TextBox40")] private TextBox _textBox40;
        [AccessedThroughProperty("TextBox39")] private TextBox _textBox39;
        [AccessedThroughProperty("nudDMin")] private NumericUpDown _nudDMin;
        [AccessedThroughProperty("nudLMin")] private NumericUpDown _nudLMin;
        [AccessedThroughProperty("nudTIA")] private NumericUpDown _nudTia;
        [AccessedThroughProperty("nudCrit")] private NumericUpDown _nudCrit;
        [AccessedThroughProperty("miSave")] private MenuItem _miSave;

        [AccessedThroughProperty("nudLowHlth")]
        private NumericUpDown _nudLowHlth;

        [AccessedThroughProperty("miOpen")] private MenuItem _miOpen;
        [AccessedThroughProperty("nudDead")] private NumericUpDown _nudDead;
        [AccessedThroughProperty("nudHit1")] private NumericUpDown _nudHit1;
        [AccessedThroughProperty("Label2")] private Label _label2;
        [AccessedThroughProperty("nudHit2")] private NumericUpDown _nudHit2;
        [AccessedThroughProperty("nudAtk3")] private NumericUpDown _nudAtk3;
        [AccessedThroughProperty("nudAtk1")] private NumericUpDown _nudAtk1;
        [AccessedThroughProperty("nudAtk2")] private NumericUpDown _nudAtk2;
        [AccessedThroughProperty("nudSel2")] private NumericUpDown _nudSel2;
        [AccessedThroughProperty("nudSel3")] private NumericUpDown _nudSel3;
        [AccessedThroughProperty("nudSel1")] private NumericUpDown _nudSel1;
        [AccessedThroughProperty("TextBox43")] private TextBox _textBox43;
        [AccessedThroughProperty("nudBat6")] private NumericUpDown _nudBat6;
        [AccessedThroughProperty("Label25")] private Label _label25;
        [AccessedThroughProperty("nudBat5")] private NumericUpDown _nudBat5;
        [AccessedThroughProperty("Label28")] private Label _label28;
        [AccessedThroughProperty("Label6")] private Label _label6;
        [AccessedThroughProperty("nudBat4")] private NumericUpDown _nudBat4;
        [AccessedThroughProperty("nudBat3")] private NumericUpDown _nudBat3;
        [AccessedThroughProperty("nudBat2")] private NumericUpDown _nudBat2;
        [AccessedThroughProperty("TextBox38")] private TextBox _textBox38;
        [AccessedThroughProperty("TextBox37")] private TextBox _textBox37;
        [AccessedThroughProperty("TextBox36")] private TextBox _textBox36;
        [AccessedThroughProperty("Label26")] private Label _label26;
        [AccessedThroughProperty("TextBox35")] private TextBox _textBox35;
        [AccessedThroughProperty("TextBox44")] private TextBox _textBox44;
        [AccessedThroughProperty("TextBox34")] private TextBox _textBox34;
        [AccessedThroughProperty("TextBox33")] private TextBox _textBox33;
        [AccessedThroughProperty("TextBox32")] private TextBox _textBox32;
        [AccessedThroughProperty("TextBox31")] private TextBox _textBox31;
        [AccessedThroughProperty("TextBox29")] private TextBox _textBox29;
        [AccessedThroughProperty("TextBox28")] private TextBox _textBox28;
        [AccessedThroughProperty("Label7")] private Label _label7;
        [AccessedThroughProperty("TextBox27")] private TextBox _textBox27;
        [AccessedThroughProperty("TextBox26")] private TextBox _textBox26;
        [AccessedThroughProperty("TextBox25")] private TextBox _textBox25;
        [AccessedThroughProperty("TextBox45")] private TextBox _textBox45;
        [AccessedThroughProperty("miNew")] private MenuItem _miNew;
        [AccessedThroughProperty("TextBox24")] private TextBox _textBox24;
        [AccessedThroughProperty("TextBox23")] private TextBox _textBox23;
        [AccessedThroughProperty("TextBox22")] private TextBox _textBox22;
        [AccessedThroughProperty("TextBox46")] private TextBox _textBox46;
        [AccessedThroughProperty("TextBox21")] private TextBox _textBox21;
        [AccessedThroughProperty("TextBox47")] private TextBox _textBox47;
        [AccessedThroughProperty("Label24")] private Label _label24;
        [AccessedThroughProperty("Label8")] private Label _label8;
        [AccessedThroughProperty("TextBox20")] private TextBox _textBox20;
        [AccessedThroughProperty("Label23")] private Label _label23;
        [AccessedThroughProperty("TextBox48")] private TextBox _textBox48;
        [AccessedThroughProperty("TextBox49")] private TextBox _textBox49;
        [AccessedThroughProperty("TextBox50")] private TextBox _textBox50;
        [AccessedThroughProperty("TextBox19")] private TextBox _textBox19;
        [AccessedThroughProperty("Label22")] private Label _label22;
        [AccessedThroughProperty("TextBox18")] private TextBox _textBox18;
        [AccessedThroughProperty("TextBox51")] private TextBox _textBox51;
        [AccessedThroughProperty("Label21")] private Label _label21;
        [AccessedThroughProperty("TextBox52")] private TextBox _textBox52;
        [AccessedThroughProperty("TextBox53")] private TextBox _textBox53;
        [AccessedThroughProperty("Label9")] private Label _label9;
        [AccessedThroughProperty("TextBox54")] private TextBox _textBox54;
        [AccessedThroughProperty("Label1")] private Label _label1;
        [AccessedThroughProperty("nudStlh")] private NumericUpDown _nudStlh;
        [AccessedThroughProperty("nudSrch")] private NumericUpDown _nudSrch;
        [AccessedThroughProperty("Label3")] private Label _label3;

        [AccessedThroughProperty("nudTryUnlock")]
        private NumericUpDown _nudTryUnlock;

        [AccessedThroughProperty("nudFailUnlock")]
        private NumericUpDown _nudFailUnlock;

        [AccessedThroughProperty("Label4")] private Label _label4;

        [AccessedThroughProperty("nudSucceedUnlock")]
        private NumericUpDown _nudSucceedUnlock;

        [AccessedThroughProperty("Label5")] private Label _label5;

        [AccessedThroughProperty("nudLeaveParty")]
        private NumericUpDown _nudLeaveParty;

        [AccessedThroughProperty("nudRejoinParty")]
        private NumericUpDown _nudRejoinParty;

        [AccessedThroughProperty("Label10")] private Label _label10;

        [AccessedThroughProperty("nudPoisoned")]
        private NumericUpDown _nudPoisoned;

        [AccessedThroughProperty("label111")] private Label _label111;
        [AccessedThroughProperty("miSaveAs")] private MenuItem _miSaveAs;
        [AccessedThroughProperty("TextBox1")] private TextBox _textBox1;

        [AccessedThroughProperty("miUseK1DialogTlk")]
        private MenuItem _miUseK1DialogTlk;

        [AccessedThroughProperty("miUseK2DialogTlk")]
        private MenuItem _miUseK2DialogTlk;

        [AccessedThroughProperty("miUseExtDialogTlk")]
        private MenuItem _miUseExtDialogTlk;

        [AccessedThroughProperty("TextBox17")] private TextBox _textBox17;

        [AccessedThroughProperty("miAskDialogTlk")]
        private MenuItem _miAskDialogTlk;

        [AccessedThroughProperty("nudBat1")] private NumericUpDown _nudBat1;
        [AccessedThroughProperty("Label11")] private Label _label11;

        [AccessedThroughProperty("tbBat1ResRef")]
        private TextBox _tbBat1ResRef;

        [AccessedThroughProperty("tbBat1Desc")]
        private TextBox _tbBat1Desc;

        [AccessedThroughProperty("TextBox2")] private TextBox _textBox2;
        [AccessedThroughProperty("TextBox3")] private TextBox _textBox3;
        [AccessedThroughProperty("TextBox4")] private TextBox _textBox4;
        [AccessedThroughProperty("Label12")] private Label _label12;
        [AccessedThroughProperty("MainMenu1")] private MainMenu _mainMenu1;
        [AccessedThroughProperty("StatusBar1")]private StatusBar _statusBar1;
        [AccessedThroughProperty("TextBox5")] private TextBox _textBox5;
        [AccessedThroughProperty("TextBox6")] private TextBox _textBox6;
        [AccessedThroughProperty("TextBox7")] private TextBox _textBox7;
        [AccessedThroughProperty("TextBox8")] private TextBox _textBox8;
        [AccessedThroughProperty("TextBox9")] private TextBox _textBox9;
        [AccessedThroughProperty("Label13")] private Label _label13;
        [AccessedThroughProperty("MenuItem1")] private MenuItem _menuItem1;
        [AccessedThroughProperty("ToolTip1")] private ToolTip _toolTip1;
        [AccessedThroughProperty("Label20")] private Label _label20;
        [AccessedThroughProperty("TextBox10")] private TextBox _textBox10;
        [AccessedThroughProperty("Label14")] private Label _label14;
        [AccessedThroughProperty("TextBox11")] private TextBox _textBox11;
        [AccessedThroughProperty("Label15")] private Label _label15;
        [AccessedThroughProperty("TextBox16")] private TextBox _textBox16;
        [AccessedThroughProperty("TextBox12")] private TextBox _textBox12;
        [AccessedThroughProperty("MenuItem2")] private MenuItem _menuItem2;
        [AccessedThroughProperty("Label16")] private Label _label16;
        [AccessedThroughProperty("TextBox13")] private TextBox _textBox13;
        [AccessedThroughProperty("Label17")] private Label _label17;
        [AccessedThroughProperty("miQuit")] private MenuItem _miQuit;
        [AccessedThroughProperty("Panel1")] private Panel _panel1;
        [AccessedThroughProperty("TextBox14")] private TextBox _textBox14;
        [AccessedThroughProperty("Label18")] private Label _label18;
        [AccessedThroughProperty("MenuItem5")] private MenuItem _menuItem5;
        [AccessedThroughProperty("TextBox15")] private TextBox _textBox15;
        [AccessedThroughProperty("Label19")] private Label _label19;
        [AccessedThroughProperty("TextBox42")] private TextBox _textBox42;
       
        private ClsSsf _ssf;
        private ClsDialogTlk _gDialogtlk;
        private string _gFilepath;
        private IContainer components;

        internal virtual NumericUpDown NudBat1
        {
            get => _nudBat1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudBat1 == null)
                    ;
                _nudBat1 = value;
                if (_nudBat1 != null)
                    ;
            }
        }

        internal virtual TextBox TbBat1ResRef
        {
            get => _tbBat1ResRef;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbBat1ResRef == null)
                    ;
                _tbBat1ResRef = value;
                if (_tbBat1ResRef != null)
                    ;
            }
        }

        internal virtual TextBox TbBat1Desc
        {
            get => _tbBat1Desc;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbBat1Desc == null)
                    ;
                _tbBat1Desc = value;
                if (_tbBat1Desc != null)
                    ;
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

        internal virtual TextBox TextBox1
        {
            get => _textBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox1 == null)
                    ;
                _textBox1 = value;
                if (_textBox1 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox2
        {
            get => _textBox2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox2 == null)
                    ;
                _textBox2 = value;
                if (_textBox2 != null)
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

        internal virtual TextBox TextBox3
        {
            get => _textBox3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox3 == null)
                    ;
                _textBox3 = value;
                if (_textBox3 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox4
        {
            get => _textBox4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox4 == null)
                    ;
                _textBox4 = value;
                if (_textBox4 != null)
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

        internal virtual TextBox TextBox5
        {
            get => _textBox5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox5 == null)
                    ;
                _textBox5 = value;
                if (_textBox5 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox6
        {
            get => _textBox6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox6 == null)
                    ;
                _textBox6 = value;
                if (_textBox6 != null)
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

        internal virtual Panel Panel1
        {
            get => _panel1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_panel1 == null)
                    ;
                _panel1 = value;
                if (_panel1 != null)
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

        internal virtual TextBox TextBox7
        {
            get => _textBox7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox7 == null)
                    ;
                _textBox7 = value;
                if (_textBox7 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox8
        {
            get => _textBox8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox8 == null)
                    ;
                _textBox8 = value;
                if (_textBox8 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox9
        {
            get => _textBox9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox9 == null)
                    ;
                _textBox9 = value;
                if (_textBox9 != null)
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

        internal virtual TextBox TextBox10
        {
            get => _textBox10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox10 == null)
                    ;
                _textBox10 = value;
                if (_textBox10 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox11
        {
            get => _textBox11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox11 == null)
                    ;
                _textBox11 = value;
                if (_textBox11 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox12
        {
            get => _textBox12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox12 == null)
                    ;
                _textBox12 = value;
                if (_textBox12 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox13
        {
            get => _textBox13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox13 == null)
                    ;
                _textBox13 = value;
                if (_textBox13 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox14
        {
            get => _textBox14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox14 == null)
                    ;
                _textBox14 = value;
                if (_textBox14 != null)
                    ;
            }
        }

        internal virtual Label Label7
        {
            get => _label7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label7 == null)
                    ;
                _label7 = value;
                if (_label7 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox15
        {
            get => _textBox15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox15 == null)
                    ;
                _textBox15 = value;
                if (_textBox15 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox16
        {
            get => _textBox16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox16 == null)
                    ;
                _textBox16 = value;
                if (_textBox16 != null)
                    ;
            }
        }

        internal virtual Label Label8
        {
            get => _label8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label8 == null)
                    ;
                _label8 = value;
                if (_label8 != null)
                    ;
            }
        }

        internal virtual Label Label9
        {
            get => _label9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label9 == null)
                    ;
                _label9 = value;
                if (_label9 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox17
        {
            get => _textBox17;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox17 == null)
                    ;
                _textBox17 = value;
                if (_textBox17 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox18
        {
            get => _textBox18;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox18 == null)
                    ;
                _textBox18 = value;
                if (_textBox18 != null)
                    ;
            }
        }

        internal virtual Label Label10
        {
            get => _label10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label10 == null)
                    ;
                _label10 = value;
                if (_label10 != null)
                    ;
            }
        }

        internal virtual Label Label11
        {
            get => _label11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label11 == null)
                    ;
                _label11 = value;
                if (_label11 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox19
        {
            get => _textBox19;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox19 == null)
                    ;
                _textBox19 = value;
                if (_textBox19 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox20
        {
            get => _textBox20;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox20 == null)
                    ;
                _textBox20 = value;
                if (_textBox20 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox21
        {
            get => _textBox21;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox21 == null)
                    ;
                _textBox21 = value;
                if (_textBox21 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox22
        {
            get => _textBox22;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox22 == null)
                    ;
                _textBox22 = value;
                if (_textBox22 != null)
                    ;
            }
        }

        internal virtual Label Label12
        {
            get => _label12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label12 == null)
                    ;
                _label12 = value;
                if (_label12 != null)
                    ;
            }
        }

        internal virtual Label Label13
        {
            get => _label13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label13 == null)
                    ;
                _label13 = value;
                if (_label13 != null)
                    ;
            }
        }

        internal virtual Label Label14
        {
            get => _label14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label14 == null)
                    ;
                _label14 = value;
                if (_label14 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox23
        {
            get => _textBox23;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox23 == null)
                    ;
                _textBox23 = value;
                if (_textBox23 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox24
        {
            get => _textBox24;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox24 == null)
                    ;
                _textBox24 = value;
                if (_textBox24 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox25
        {
            get => _textBox25;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox25 == null)
                    ;
                _textBox25 = value;
                if (_textBox25 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox26
        {
            get => _textBox26;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox26 == null)
                    ;
                _textBox26 = value;
                if (_textBox26 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox27
        {
            get => _textBox27;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox27 == null)
                    ;
                _textBox27 = value;
                if (_textBox27 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox28
        {
            get => _textBox28;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox28 == null)
                    ;
                _textBox28 = value;
                if (_textBox28 != null)
                    ;
            }
        }

        internal virtual Label Label15
        {
            get => _label15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label15 == null)
                    ;
                _label15 = value;
                if (_label15 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox29
        {
            get => _textBox29;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox29 == null)
                    ;
                _textBox29 = value;
                if (_textBox29 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox30
        {
            get => _textBox30;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox30 == null)
                    ;
                _textBox30 = value;
                if (_textBox30 != null)
                    ;
            }
        }

        internal virtual Label Label16
        {
            get => _label16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label16 == null)
                    ;
                _label16 = value;
                if (_label16 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox31
        {
            get => _textBox31;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox31 == null)
                    ;
                _textBox31 = value;
                if (_textBox31 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox32
        {
            get => _textBox32;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox32 == null)
                    ;
                _textBox32 = value;
                if (_textBox32 != null)
                    ;
            }
        }

        internal virtual Label Label17
        {
            get => _label17;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label17 == null)
                    ;
                _label17 = value;
                if (_label17 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox33
        {
            get => _textBox33;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox33 == null)
                    ;
                _textBox33 = value;
                if (_textBox33 != null)
                    ;
            }
        }

        internal virtual Label Label18
        {
            get => _label18;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label18 == null)
                    ;
                _label18 = value;
                if (_label18 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox34
        {
            get => _textBox34;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox34 == null)
                    ;
                _textBox34 = value;
                if (_textBox34 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox35
        {
            get => _textBox35;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox35 == null)
                    ;
                _textBox35 = value;
                if (_textBox35 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox36
        {
            get => _textBox36;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox36 == null)
                    ;
                _textBox36 = value;
                if (_textBox36 != null)
                    ;
            }
        }

        internal virtual Label Label19
        {
            get => _label19;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label19 == null)
                    ;
                _label19 = value;
                if (_label19 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox37
        {
            get => _textBox37;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox37 == null)
                    ;
                _textBox37 = value;
                if (_textBox37 != null)
                    ;
            }
        }

        internal virtual Label Label20
        {
            get => _label20;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label20 == null)
                    ;
                _label20 = value;
                if (_label20 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox38
        {
            get => _textBox38;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox38 == null)
                    ;
                _textBox38 = value;
                if (_textBox38 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudBat2
        {
            get => _nudBat2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudBat2 == null)
                    ;
                _nudBat2 = value;
                if (_nudBat2 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudBat3
        {
            get => _nudBat3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudBat3 == null)
                    ;
                _nudBat3 = value;
                if (_nudBat3 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudBat4
        {
            get => _nudBat4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudBat4 == null)
                    ;
                _nudBat4 = value;
                if (_nudBat4 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudBat5
        {
            get => _nudBat5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudBat5 == null)
                    ;
                _nudBat5 = value;
                if (_nudBat5 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudBat6
        {
            get => _nudBat6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudBat6 == null)
                    ;
                _nudBat6 = value;
                if (_nudBat6 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudSel1
        {
            get => _nudSel1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudSel1 == null)
                    ;
                _nudSel1 = value;
                if (_nudSel1 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudSel3
        {
            get => _nudSel3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudSel3 == null)
                    ;
                _nudSel3 = value;
                if (_nudSel3 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudSel2
        {
            get => _nudSel2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudSel2 == null)
                    ;
                _nudSel2 = value;
                if (_nudSel2 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudAtk2
        {
            get => _nudAtk2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudAtk2 == null)
                    ;
                _nudAtk2 = value;
                if (_nudAtk2 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudAtk1
        {
            get => _nudAtk1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudAtk1 == null)
                    ;
                _nudAtk1 = value;
                if (_nudAtk1 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudAtk3
        {
            get => _nudAtk3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudAtk3 == null)
                    ;
                _nudAtk3 = value;
                if (_nudAtk3 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudHit2
        {
            get => _nudHit2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudHit2 == null)
                    ;
                _nudHit2 = value;
                if (_nudHit2 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudHit1
        {
            get => _nudHit1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudHit1 == null)
                    ;
                _nudHit1 = value;
                if (_nudHit1 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudDead
        {
            get => _nudDead;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudDead == null)
                    ;
                _nudDead = value;
                if (_nudDead != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudLowHlth
        {
            get => _nudLowHlth;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudLowHlth == null)
                    ;
                _nudLowHlth = value;
                if (_nudLowHlth != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudCrit
        {
            get => _nudCrit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudCrit == null)
                    ;
                _nudCrit = value;
                if (_nudCrit != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudTia
        {
            get => _nudTia;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTia == null)
                    ;
                _nudTia = value;
                if (_nudTia != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudLMin
        {
            get => _nudLMin;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudLMin == null)
                    ;
                _nudLMin = value;
                if (_nudLMin != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudDMin
        {
            get => _nudDMin;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudDMin == null)
                    ;
                _nudDMin = value;
                if (_nudDMin != null)
                    ;
            }
        }

        internal virtual TextBox TextBox39
        {
            get => _textBox39;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox39 == null)
                    ;
                _textBox39 = value;
                if (_textBox39 != null)
                    ;
            }
        }

        internal virtual Label Label21
        {
            get => _label21;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label21 == null)
                    ;
                _label21 = value;
                if (_label21 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox40
        {
            get => _textBox40;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox40 == null)
                    ;
                _textBox40 = value;
                if (_textBox40 != null)
                    ;
            }
        }

        internal virtual Label Label22
        {
            get => _label22;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label22 == null)
                    ;
                _label22 = value;
                if (_label22 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox41
        {
            get => _textBox41;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox41 == null)
                    ;
                _textBox41 = value;
                if (_textBox41 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox42
        {
            get => _textBox42;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox42 == null)
                    ;
                _textBox42 = value;
                if (_textBox42 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox43
        {
            get => _textBox43;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox43 == null)
                    ;
                _textBox43 = value;
                if (_textBox43 != null)
                    ;
            }
        }

        internal virtual Label Label23
        {
            get => _label23;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label23 == null)
                    ;
                _label23 = value;
                if (_label23 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox44
        {
            get => _textBox44;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox44 == null)
                    ;
                _textBox44 = value;
                if (_textBox44 != null)
                    ;
            }
        }

        internal virtual Label Label24
        {
            get => _label24;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label24 == null)
                    ;
                _label24 = value;
                if (_label24 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox45
        {
            get => _textBox45;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox45 == null)
                    ;
                _textBox45 = value;
                if (_textBox45 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox46
        {
            get => _textBox46;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox46 == null)
                    ;
                _textBox46 = value;
                if (_textBox46 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox47
        {
            get => _textBox47;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox47 == null)
                    ;
                _textBox47 = value;
                if (_textBox47 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox48
        {
            get => _textBox48;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox48 == null)
                    ;
                _textBox48 = value;
                if (_textBox48 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox49
        {
            get => _textBox49;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox49 == null)
                    ;
                _textBox49 = value;
                if (_textBox49 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox50
        {
            get => _textBox50;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox50 == null)
                    ;
                _textBox50 = value;
                if (_textBox50 != null)
                    ;
            }
        }

        internal virtual Label Label25
        {
            get => _label25;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label25 == null)
                    ;
                _label25 = value;
                if (_label25 != null)
                    ;
            }
        }

        internal virtual Label Label26
        {
            get => _label26;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label26 == null)
                    ;
                _label26 = value;
                if (_label26 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox51
        {
            get => _textBox51;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox51 == null)
                    ;
                _textBox51 = value;
                if (_textBox51 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox52
        {
            get => _textBox52;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox52 == null)
                    ;
                _textBox52 = value;
                if (_textBox52 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox53
        {
            get => _textBox53;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox53 == null)
                    ;
                _textBox53 = value;
                if (_textBox53 != null)
                    ;
            }
        }

        internal virtual TextBox TextBox54
        {
            get => _textBox54;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_textBox54 == null)
                    ;
                _textBox54 = value;
                if (_textBox54 != null)
                    ;
            }
        }

        internal virtual Label Label28
        {
            get => _label28;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label28 == null)
                    ;
                _label28 = value;
                if (_label28 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudStlh
        {
            get => _nudStlh;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudStlh == null)
                    ;
                _nudStlh = value;
                if (_nudStlh != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudSrch
        {
            get => _nudSrch;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudSrch == null)
                    ;
                _nudSrch = value;
                if (_nudSrch != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudTryUnlock
        {
            get => _nudTryUnlock;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTryUnlock == null)
                    ;
                _nudTryUnlock = value;
                if (_nudTryUnlock != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudFailUnlock
        {
            get => _nudFailUnlock;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudFailUnlock == null)
                    ;
                _nudFailUnlock = value;
                if (_nudFailUnlock != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudSucceedUnlock
        {
            get => _nudSucceedUnlock;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudSucceedUnlock == null)
                    ;
                _nudSucceedUnlock = value;
                if (_nudSucceedUnlock != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudLeaveParty
        {
            get => _nudLeaveParty;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudLeaveParty == null)
                    ;
                _nudLeaveParty = value;
                if (_nudLeaveParty != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudRejoinParty
        {
            get => _nudRejoinParty;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudRejoinParty == null)
                    ;
                _nudRejoinParty = value;
                if (_nudRejoinParty != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudPoisoned
        {
            get => _nudPoisoned;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudPoisoned == null)
                    ;
                _nudPoisoned = value;
                if (_nudPoisoned != null)
                    ;
            }
        }

        internal virtual Label Label111
        {
            get => _label111;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label111 == null)
                    ;
                _label111 = value;
                if (_label111 != null)
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

        internal virtual MenuItem MiSave
        {
            get => _miSave;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSave != null)
                    _miSave.Click -= miSave_Click;
                _miSave = value;
                if (_miSave == null)
                    return;
                _miSave.Click += miSave_Click;
            }
        }

        internal virtual MenuItem MenuItem5
        {
            get => _menuItem5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem5 == null)
                    ;
                _menuItem5 = value;
                if (_menuItem5 != null)
                    ;
            }
        }

        internal virtual MenuItem MiNew
        {
            get => _miNew;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miNew != null)
                    _miNew.Click -= miNew_Click;
                _miNew = value;
                if (_miNew == null)
                    return;
                _miNew.Click += miNew_Click;
            }
        }

        internal virtual MenuItem MiOpen
        {
            get => _miOpen;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miOpen != null) _miOpen.Click -= miOpen_Click;
                _miOpen = value;
                if (_miOpen == null) return;
                _miOpen.Click += miOpen_Click;
            }
        }

        internal virtual MenuItem MiQuit
        {
            get => _miQuit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miQuit != null) _miQuit.Click -= miQuit_Click;
                _miQuit = value;
                if (_miQuit == null) return;
                _miQuit.Click += miQuit_Click;
            }
        }

        internal virtual MenuItem MiSaveAs
        {
            get => _miSaveAs;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSaveAs != null)
                    _miSaveAs.Click -= miSaveAs_Click;
                _miSaveAs = value;
                if (_miSaveAs == null)
                    return;
                _miSaveAs.Click += miSaveAs_Click;
            }
        }

        internal virtual MenuItem MenuItem2
        {
            get => _menuItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem2 == null)
                    ;
                _menuItem2 = value;
                if (_menuItem2 != null)
                    ;
            }
        }

        internal virtual MenuItem MiUseK1DialogTlk
        {
            get => _miUseK1DialogTlk;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miUseK1DialogTlk != null)
                    _miUseK1DialogTlk.Click -= UseDialogTlk_Click;
                _miUseK1DialogTlk = value;
                if (_miUseK1DialogTlk == null)
                    return;
                _miUseK1DialogTlk.Click += UseDialogTlk_Click;
            }
        }

        internal virtual MenuItem MiUseK2DialogTlk
        {
            get => _miUseK2DialogTlk;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miUseK2DialogTlk != null)
                    _miUseK2DialogTlk.Click -= UseDialogTlk_Click;
                _miUseK2DialogTlk = value;
                if (_miUseK2DialogTlk == null)
                    return;
                _miUseK2DialogTlk.Click += UseDialogTlk_Click;
            }
        }

        internal virtual MenuItem MiUseExtDialogTlk
        {
            get => _miUseExtDialogTlk;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miUseExtDialogTlk != null)
                    _miUseExtDialogTlk.Click -= UseDialogTlk_Click;
                _miUseExtDialogTlk = value;
                if (_miUseExtDialogTlk == null)
                    return;
                _miUseExtDialogTlk.Click += UseDialogTlk_Click;
            }
        }

        internal virtual MenuItem MiAskDialogTlk
        {
            get => _miAskDialogTlk;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miAskDialogTlk != null)
                    _miAskDialogTlk.Click -= UseDialogTlk_Click;
                _miAskDialogTlk = value;
                if (_miAskDialogTlk == null)
                    return;
                _miAskDialogTlk.Click += UseDialogTlk_Click;
            }
        }

        internal virtual StatusBar StatusBar1
        {
            get => _statusBar1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_statusBar1 == null)
                    ;
                _statusBar1 = value;
                if (_statusBar1 != null)
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

        public FrmSsfEditor()
        {
            Load += OnLoad;
            InitializeComponent();
            CurrentSettings = UserSettings.GetSettings();
            KotorVersionIndex = -1;
        }

        public FrmSsfEditor(FileStream fs, int kotorVersionIndex) : this(new ClsSsf(fs, kotorVersionIndex))
        {
            fs.Close();
        }

        public FrmSsfEditor(string filepath, int kotorVersionIndex) : this(new FileStream(filepath, FileMode.Open), kotorVersionIndex)
        {
        }

        public FrmSsfEditor(ClsSsf ssf) : this()
        {
            _ssf = ssf;
            ParseSsf();
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
            NudBat1 = new NumericUpDown();
            TbBat1ResRef = new TextBox();
            TbBat1Desc = new TextBox();
            Label1 = new Label();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            NudBat2 = new NumericUpDown();
            Label2 = new Label();
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            Label3 = new Label();
            NudBat3 = new NumericUpDown();
            TextBox5 = new TextBox();
            TextBox6 = new TextBox();
            NudBat4 = new NumericUpDown();
            Label4 = new Label();
            Panel1 = new Panel();
            TextBox43 = new TextBox();
            Label23 = new Label();
            TextBox44 = new TextBox();
            Label24 = new Label();
            TextBox45 = new TextBox();
            NudTryUnlock = new NumericUpDown();
            NudFailUnlock = new NumericUpDown();
            TextBox46 = new TextBox();
            TextBox9 = new TextBox();
            Label6 = new Label();
            TextBox8 = new TextBox();
            TextBox7 = new TextBox();
            NudBat5 = new NumericUpDown();
            TextBox10 = new TextBox();
            Label5 = new Label();
            NudBat6 = new NumericUpDown();
            NudSel1 = new NumericUpDown();
            TextBox11 = new TextBox();
            TextBox12 = new TextBox();
            TextBox13 = new TextBox();
            TextBox14 = new TextBox();
            Label7 = new Label();
            NudSel3 = new NumericUpDown();
            TextBox15 = new TextBox();
            TextBox16 = new TextBox();
            NudSel2 = new NumericUpDown();
            Label8 = new Label();
            Label9 = new Label();
            TextBox17 = new TextBox();
            TextBox18 = new TextBox();
            NudAtk2 = new NumericUpDown();
            Label10 = new Label();
            Label11 = new Label();
            NudAtk1 = new NumericUpDown();
            TextBox19 = new TextBox();
            TextBox20 = new TextBox();
            TextBox21 = new TextBox();
            TextBox22 = new TextBox();
            NudAtk3 = new NumericUpDown();
            Label12 = new Label();
            NudHit2 = new NumericUpDown();
            Label13 = new Label();
            Label14 = new Label();
            NudHit1 = new NumericUpDown();
            TextBox23 = new TextBox();
            TextBox24 = new TextBox();
            TextBox25 = new TextBox();
            TextBox26 = new TextBox();
            TextBox27 = new TextBox();
            TextBox28 = new TextBox();
            NudDead = new NumericUpDown();
            Label15 = new Label();
            TextBox29 = new TextBox();
            NudLowHlth = new NumericUpDown();
            TextBox30 = new TextBox();
            Label16 = new Label();
            NudCrit = new NumericUpDown();
            TextBox31 = new TextBox();
            TextBox32 = new TextBox();
            NudTia = new NumericUpDown();
            Label17 = new Label();
            TextBox33 = new TextBox();
            Label18 = new Label();
            TextBox34 = new TextBox();
            TextBox35 = new TextBox();
            TextBox36 = new TextBox();
            NudLMin = new NumericUpDown();
            Label19 = new Label();
            NudDMin = new NumericUpDown();
            TextBox37 = new TextBox();
            Label20 = new Label();
            TextBox38 = new TextBox();
            TextBox39 = new TextBox();
            Label21 = new Label();
            TextBox40 = new TextBox();
            Label22 = new Label();
            TextBox41 = new TextBox();
            NudStlh = new NumericUpDown();
            NudSrch = new NumericUpDown();
            TextBox42 = new TextBox();
            TextBox47 = new TextBox();
            NudSucceedUnlock = new NumericUpDown();
            NudLeaveParty = new NumericUpDown();
            TextBox48 = new TextBox();
            TextBox49 = new TextBox();
            TextBox50 = new TextBox();
            Label25 = new Label();
            Label26 = new Label();
            TextBox51 = new TextBox();
            NudRejoinParty = new NumericUpDown();
            NudPoisoned = new NumericUpDown();
            TextBox52 = new TextBox();
            TextBox53 = new TextBox();
            TextBox54 = new TextBox();
            Label111 = new Label();
            Label28 = new Label();
            MainMenu1 = new MainMenu();
            MenuItem1 = new MenuItem();
            MiNew = new MenuItem();
            MiOpen = new MenuItem();
            MiSave = new MenuItem();
            MiSaveAs = new MenuItem();
            MenuItem5 = new MenuItem();
            MiQuit = new MenuItem();
            MenuItem2 = new MenuItem();
            MiUseK1DialogTlk = new MenuItem();
            MiUseK2DialogTlk = new MenuItem();
            MiUseExtDialogTlk = new MenuItem();
            MiAskDialogTlk = new MenuItem();
            StatusBar1 = new StatusBar();
            ToolTip1 = new ToolTip(components);
            NudBat1.BeginInit();
            NudBat2.BeginInit();
            NudBat3.BeginInit();
            NudBat4.BeginInit();
            Panel1.SuspendLayout();
            NudTryUnlock.BeginInit();
            NudFailUnlock.BeginInit();
            NudBat5.BeginInit();
            NudBat6.BeginInit();
            NudSel1.BeginInit();
            NudSel3.BeginInit();
            NudSel2.BeginInit();
            NudAtk2.BeginInit();
            NudAtk1.BeginInit();
            NudAtk3.BeginInit();
            NudHit2.BeginInit();
            NudHit1.BeginInit();
            NudDead.BeginInit();
            NudLowHlth.BeginInit();
            NudCrit.BeginInit();
            NudTia.BeginInit();
            NudLMin.BeginInit();
            NudDMin.BeginInit();
            NudStlh.BeginInit();
            NudSrch.BeginInit();
            NudSucceedUnlock.BeginInit();
            NudLeaveParty.BeginInit();
            NudRejoinParty.BeginInit();
            NudPoisoned.BeginInit();
            SuspendLayout();
            NudBat1.Enabled = false;
            NumericUpDown nudBat11 = NudBat1;
            Point point1 = new Point(152, 16);
            Point point2 = point1;
            nudBat11.Location = point2;
            NumericUpDown nudBat12 = NudBat1;
            Decimal num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num2 = num1;
            nudBat12.Maximum = num2;
            NumericUpDown nudBat13 = NudBat1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num3 = num1;
            nudBat13.Minimum = num3;
            NudBat1.Name = "nudBat1";
            NumericUpDown nudBat14 = NudBat1;
            Size size1 = new Size(64, 20);
            Size size2 = size1;
            nudBat14.Size = size2;
            NudBat1.TabIndex = 0;
            NudBat1.Tag = "0";
            NudBat1.TextAlign = HorizontalAlignment.Right;
            TextBox tbBat1ResRef1 = TbBat1ResRef;
            point1 = new Point(224, 16);
            Point point3 = point1;
            tbBat1ResRef1.Location = point3;
            TbBat1ResRef.Name = "tbBat1ResRef";
            TbBat1ResRef.ReadOnly = true;
            TextBox tbBat1ResRef2 = TbBat1ResRef;
            size1 = new Size(136, 20);
            Size size3 = size1;
            tbBat1ResRef2.Size = size3;
            TbBat1ResRef.TabIndex = 4;
            TbBat1ResRef.TabStop = false;
            TbBat1ResRef.Tag = "rr0";
            TbBat1ResRef.Text = "";
            TbBat1ResRef.TextAlign = HorizontalAlignment.Right;
            TbBat1Desc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbBat1Desc1 = TbBat1Desc;
            point1 = new Point(368, 16);
            Point point4 = point1;
            tbBat1Desc1.Location = point4;
            TbBat1Desc.Name = "tbBat1Desc";
            TbBat1Desc.ReadOnly = true;
            TextBox tbBat1Desc2 = TbBat1Desc;
            size1 = new Size(272, 20);
            Size size4 = size1;
            tbBat1Desc2.Size = size4;
            TbBat1Desc.TabIndex = 4;
            TbBat1Desc.TabStop = false;
            TbBat1Desc.Tag = "d0";
            TbBat1Desc.Text = "";
            Label label11 = Label1;
            point1 = new Point(16, 16);
            Point point5 = point1;
            label11.Location = point5;
            Label1.Name = "Label1";
            Label label12 = Label1;
            size1 = new Size(64, 16);
            Size size5 = size1;
            label12.Size = size5;
            Label1.TabIndex = 5;
            Label1.Text = "Battlecry 1";
            TextBox textBox11 = TextBox1;
            point1 = new Point(224, 40);
            Point point6 = point1;
            textBox11.Location = point6;
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox textBox12 = TextBox1;
            size1 = new Size(136, 20);
            Size size6 = size1;
            textBox12.Size = size6;
            TextBox1.TabIndex = 4;
            TextBox1.TabStop = false;
            TextBox1.Tag = "rr1";
            TextBox1.Text = "";
            TextBox1.TextAlign = HorizontalAlignment.Right;
            TextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox21 = TextBox2;
            point1 = new Point(368, 40);
            Point point7 = point1;
            textBox21.Location = point7;
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox textBox22 = TextBox2;
            size1 = new Size(272, 20);
            Size size7 = size1;
            textBox22.Size = size7;
            TextBox2.TabIndex = 4;
            TextBox2.TabStop = false;
            TextBox2.Tag = "d1";
            TextBox2.Text = "";
            NudBat2.Enabled = false;
            NumericUpDown nudBat21 = NudBat2;
            point1 = new Point(152, 40);
            Point point8 = point1;
            nudBat21.Location = point8;
            NumericUpDown nudBat22 = NudBat2;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num4 = num1;
            nudBat22.Maximum = num4;
            NumericUpDown nudBat23 = NudBat2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num5 = num1;
            nudBat23.Minimum = num5;
            NudBat2.Name = "nudBat2";
            NumericUpDown nudBat24 = NudBat2;
            size1 = new Size(64, 20);
            Size size8 = size1;
            nudBat24.Size = size8;
            NudBat2.TabIndex = 1;
            NudBat2.Tag = "1";
            NudBat2.TextAlign = HorizontalAlignment.Right;
            Label label21 = Label2;
            point1 = new Point(16, 40);
            Point point9 = point1;
            label21.Location = point9;
            Label2.Name = "Label2";
            Label label22 = Label2;
            size1 = new Size(64, 16);
            Size size9 = size1;
            label22.Size = size9;
            Label2.TabIndex = 5;
            Label2.Text = "Battlecry 2";
            TextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox31 = TextBox3;
            point1 = new Point(368, 64);
            Point point10 = point1;
            textBox31.Location = point10;
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox textBox32 = TextBox3;
            size1 = new Size(272, 20);
            Size size10 = size1;
            textBox32.Size = size10;
            TextBox3.TabIndex = 4;
            TextBox3.TabStop = false;
            TextBox3.Tag = "d2";
            TextBox3.Text = "";
            TextBox textBox41 = TextBox4;
            point1 = new Point(224, 64);
            Point point11 = point1;
            textBox41.Location = point11;
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox textBox42 = TextBox4;
            size1 = new Size(136, 20);
            Size size11 = size1;
            textBox42.Size = size11;
            TextBox4.TabIndex = 4;
            TextBox4.TabStop = false;
            TextBox4.Tag = "rr2";
            TextBox4.Text = "";
            TextBox4.TextAlign = HorizontalAlignment.Right;
            Label label31 = Label3;
            point1 = new Point(16, 64);
            Point point12 = point1;
            label31.Location = point12;
            Label3.Name = "Label3";
            Label label32 = Label3;
            size1 = new Size(64, 16);
            Size size12 = size1;
            label32.Size = size12;
            Label3.TabIndex = 5;
            Label3.Text = "Battlecry 3";
            NudBat3.Enabled = false;
            NumericUpDown nudBat31 = NudBat3;
            point1 = new Point(152, 64);
            Point point13 = point1;
            nudBat31.Location = point13;
            NumericUpDown nudBat32 = NudBat3;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num6 = num1;
            nudBat32.Maximum = num6;
            NumericUpDown nudBat33 = NudBat3;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num7 = num1;
            nudBat33.Minimum = num7;
            NudBat3.Name = "nudBat3";
            NumericUpDown nudBat34 = NudBat3;
            size1 = new Size(64, 20);
            Size size13 = size1;
            nudBat34.Size = size13;
            NudBat3.TabIndex = 2;
            NudBat3.Tag = "2";
            NudBat3.TextAlign = HorizontalAlignment.Right;
            TextBox textBox51 = TextBox5;
            point1 = new Point(224, 88);
            Point point14 = point1;
            textBox51.Location = point14;
            TextBox5.Name = "TextBox5";
            TextBox5.ReadOnly = true;
            TextBox textBox52 = TextBox5;
            size1 = new Size(136, 20);
            Size size14 = size1;
            textBox52.Size = size14;
            TextBox5.TabIndex = 4;
            TextBox5.TabStop = false;
            TextBox5.Tag = "rr3";
            TextBox5.Text = "";
            TextBox5.TextAlign = HorizontalAlignment.Right;
            TextBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox61 = TextBox6;
            point1 = new Point(368, 88);
            Point point15 = point1;
            textBox61.Location = point15;
            TextBox6.Name = "TextBox6";
            TextBox6.ReadOnly = true;
            TextBox textBox62 = TextBox6;
            size1 = new Size(272, 20);
            Size size15 = size1;
            textBox62.Size = size15;
            TextBox6.TabIndex = 4;
            TextBox6.TabStop = false;
            TextBox6.Tag = "d3";
            TextBox6.Text = "";
            NudBat4.Enabled = false;
            NumericUpDown nudBat41 = NudBat4;
            point1 = new Point(152, 88);
            Point point16 = point1;
            nudBat41.Location = point16;
            NumericUpDown nudBat42 = NudBat4;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num8 = num1;
            nudBat42.Maximum = num8;
            NumericUpDown nudBat43 = NudBat4;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num9 = num1;
            nudBat43.Minimum = num9;
            NudBat4.Name = "nudBat4";
            NumericUpDown nudBat44 = NudBat4;
            size1 = new Size(64, 20);
            Size size16 = size1;
            nudBat44.Size = size16;
            NudBat4.TabIndex = 3;
            NudBat4.Tag = "3";
            NudBat4.TextAlign = HorizontalAlignment.Right;
            Label label41 = Label4;
            point1 = new Point(16, 88);
            Point point17 = point1;
            label41.Location = point17;
            Label4.Name = "Label4";
            Label label42 = Label4;
            size1 = new Size(64, 16);
            Size size17 = size1;
            label42.Size = size17;
            Label4.TabIndex = 5;
            Label4.Text = "Battlecry 4";
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.AutoScroll = true;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(TextBox43);
            Panel1.Controls.Add(Label23);
            Panel1.Controls.Add(TextBox44);
            Panel1.Controls.Add(Label24);
            Panel1.Controls.Add(TextBox45);
            Panel1.Controls.Add(NudTryUnlock);
            Panel1.Controls.Add(NudFailUnlock);
            Panel1.Controls.Add(TextBox46);
            Panel1.Controls.Add(NudBat1);
            Panel1.Controls.Add(TbBat1ResRef);
            Panel1.Controls.Add(TextBox5);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TextBox9);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(TbBat1Desc);
            Panel1.Controls.Add(TextBox3);
            Panel1.Controls.Add(TextBox4);
            Panel1.Controls.Add(TextBox1);
            Panel1.Controls.Add(NudBat3);
            Panel1.Controls.Add(NudBat2);
            Panel1.Controls.Add(TextBox2);
            Panel1.Controls.Add(NudBat4);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(TextBox8);
            Panel1.Controls.Add(TextBox7);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(NudBat5);
            Panel1.Controls.Add(TextBox6);
            Panel1.Controls.Add(TextBox10);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(NudBat6);
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(NudSel1);
            Panel1.Controls.Add(TextBox11);
            Panel1.Controls.Add(TextBox12);
            Panel1.Controls.Add(TextBox13);
            Panel1.Controls.Add(TextBox14);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(NudSel3);
            Panel1.Controls.Add(TextBox15);
            Panel1.Controls.Add(TextBox16);
            Panel1.Controls.Add(NudSel2);
            Panel1.Controls.Add(Label8);
            Panel1.Controls.Add(Label9);
            Panel1.Controls.Add(TextBox17);
            Panel1.Controls.Add(TextBox18);
            Panel1.Controls.Add(NudAtk2);
            Panel1.Controls.Add(Label10);
            Panel1.Controls.Add(Label11);
            Panel1.Controls.Add(NudAtk1);
            Panel1.Controls.Add(TextBox19);
            Panel1.Controls.Add(TextBox20);
            Panel1.Controls.Add(TextBox21);
            Panel1.Controls.Add(TextBox22);
            Panel1.Controls.Add(NudAtk3);
            Panel1.Controls.Add(Label12);
            Panel1.Controls.Add(NudHit2);
            Panel1.Controls.Add(Label13);
            Panel1.Controls.Add(Label14);
            Panel1.Controls.Add(NudHit1);
            Panel1.Controls.Add(TextBox23);
            Panel1.Controls.Add(TextBox24);
            Panel1.Controls.Add(TextBox25);
            Panel1.Controls.Add(TextBox26);
            Panel1.Controls.Add(TextBox27);
            Panel1.Controls.Add(TextBox28);
            Panel1.Controls.Add(NudDead);
            Panel1.Controls.Add(Label15);
            Panel1.Controls.Add(TextBox29);
            Panel1.Controls.Add(NudLowHlth);
            Panel1.Controls.Add(TextBox30);
            Panel1.Controls.Add(Label16);
            Panel1.Controls.Add(NudCrit);
            Panel1.Controls.Add(TextBox31);
            Panel1.Controls.Add(TextBox32);
            Panel1.Controls.Add(NudTia);
            Panel1.Controls.Add(Label17);
            Panel1.Controls.Add(TextBox33);
            Panel1.Controls.Add(Label18);
            Panel1.Controls.Add(TextBox34);
            Panel1.Controls.Add(TextBox35);
            Panel1.Controls.Add(TextBox36);
            Panel1.Controls.Add(NudLMin);
            Panel1.Controls.Add(Label19);
            Panel1.Controls.Add(NudDMin);
            Panel1.Controls.Add(TextBox37);
            Panel1.Controls.Add(Label20);
            Panel1.Controls.Add(TextBox38);
            Panel1.Controls.Add(TextBox39);
            Panel1.Controls.Add(Label21);
            Panel1.Controls.Add(TextBox40);
            Panel1.Controls.Add(Label22);
            Panel1.Controls.Add(TextBox41);
            Panel1.Controls.Add(NudStlh);
            Panel1.Controls.Add(NudSrch);
            Panel1.Controls.Add(TextBox42);
            Panel1.Controls.Add(TextBox47);
            Panel1.Controls.Add(NudSucceedUnlock);
            Panel1.Controls.Add(NudLeaveParty);
            Panel1.Controls.Add(TextBox48);
            Panel1.Controls.Add(TextBox49);
            Panel1.Controls.Add(TextBox50);
            Panel1.Controls.Add(Label25);
            Panel1.Controls.Add(Label26);
            Panel1.Controls.Add(TextBox51);
            Panel1.Controls.Add(NudRejoinParty);
            Panel1.Controls.Add(NudPoisoned);
            Panel1.Controls.Add(TextBox52);
            Panel1.Controls.Add(TextBox53);
            Panel1.Controls.Add(TextBox54);
            Panel1.Controls.Add(Label111);
            Panel1.Controls.Add(Label28);
            Panel panel11 = Panel1;
            point1 = new Point(8, 16);
            Point point18 = point1;
            panel11.Location = point18;
            Panel1.Name = "Panel1";
            Panel panel12 = Panel1;
            size1 = new Size(672, 336);
            Size size18 = size1;
            panel12.Size = size18;
            Panel1.TabIndex = 6;
            TextBox textBox431 = TextBox43;
            point1 = new Point(224, 592);
            Point point19 = point1;
            textBox431.Location = point19;
            TextBox43.Name = "TextBox43";
            TextBox43.ReadOnly = true;
            TextBox textBox432 = TextBox43;
            size1 = new Size(136, 20);
            Size size19 = size1;
            textBox432.Size = size19;
            TextBox43.TabIndex = 17;
            TextBox43.TabStop = false;
            TextBox43.Tag = "rr22";
            TextBox43.Text = "";
            TextBox43.TextAlign = HorizontalAlignment.Right;
            Label label231 = Label23;
            point1 = new Point(16, 616);
            Point point20 = point1;
            label231.Location = point20;
            Label23.Name = "Label23";
            Label label232 = Label23;
            size1 = new Size(80, 16);
            Size size20 = size1;
            label232.Size = size20;
            Label23.TabIndex = 20;
            Label23.Text = "Unlock Failed";
            TextBox textBox441 = TextBox44;
            point1 = new Point(224, 616);
            Point point21 = point1;
            textBox441.Location = point21;
            TextBox44.Name = "TextBox44";
            TextBox44.ReadOnly = true;
            TextBox textBox442 = TextBox44;
            size1 = new Size(136, 20);
            Size size21 = size1;
            textBox442.Size = size21;
            TextBox44.TabIndex = 16;
            TextBox44.TabStop = false;
            TextBox44.Tag = "rr23";
            TextBox44.Text = "";
            TextBox44.TextAlign = HorizontalAlignment.Right;
            Label label241 = Label24;
            point1 = new Point(16, 592);
            Point point22 = point1;
            label241.Location = point22;
            Label24.Name = "Label24";
            Label label242 = Label24;
            size1 = new Size(80, 16);
            Size size22 = size1;
            label242.Size = size22;
            Label24.TabIndex = 21;
            Label24.Text = "Begin Unlock";
            TextBox45.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox451 = TextBox45;
            point1 = new Point(368, 592);
            Point point23 = point1;
            textBox451.Location = point23;
            TextBox45.Name = "TextBox45";
            TextBox45.ReadOnly = true;
            TextBox textBox452 = TextBox45;
            size1 = new Size(272, 20);
            Size size23 = size1;
            textBox452.Size = size23;
            TextBox45.TabIndex = 18;
            TextBox45.TabStop = false;
            TextBox45.Tag = "d22";
            TextBox45.Text = "";
            NudTryUnlock.Enabled = false;
            NumericUpDown nudTryUnlock1 = NudTryUnlock;
            point1 = new Point(152, 592);
            Point point24 = point1;
            nudTryUnlock1.Location = point24;
            NumericUpDown nudTryUnlock2 = NudTryUnlock;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num10 = num1;
            nudTryUnlock2.Maximum = num10;
            NumericUpDown nudTryUnlock3 = NudTryUnlock;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num11 = num1;
            nudTryUnlock3.Minimum = num11;
            NudTryUnlock.Name = "nudTryUnlock";
            NumericUpDown nudTryUnlock4 = NudTryUnlock;
            size1 = new Size(64, 20);
            Size size24 = size1;
            nudTryUnlock4.Size = size24;
            NudTryUnlock.TabIndex = 22;
            NudTryUnlock.Tag = "22";
            NudTryUnlock.TextAlign = HorizontalAlignment.Right;
            NudFailUnlock.Enabled = false;
            NumericUpDown nudFailUnlock1 = NudFailUnlock;
            point1 = new Point(152, 616);
            Point point25 = point1;
            nudFailUnlock1.Location = point25;
            NumericUpDown nudFailUnlock2 = NudFailUnlock;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num12 = num1;
            nudFailUnlock2.Maximum = num12;
            NumericUpDown nudFailUnlock3 = NudFailUnlock;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num13 = num1;
            nudFailUnlock3.Minimum = num13;
            NudFailUnlock.Name = "nudFailUnlock";
            NumericUpDown nudFailUnlock4 = NudFailUnlock;
            size1 = new Size(64, 20);
            Size size25 = size1;
            nudFailUnlock4.Size = size25;
            NudFailUnlock.TabIndex = 23;
            NudFailUnlock.Tag = "23";
            NudFailUnlock.TextAlign = HorizontalAlignment.Right;
            TextBox46.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox461 = TextBox46;
            point1 = new Point(368, 616);
            Point point26 = point1;
            textBox461.Location = point26;
            TextBox46.Name = "TextBox46";
            TextBox46.ReadOnly = true;
            TextBox textBox462 = TextBox46;
            size1 = new Size(272, 20);
            Size size26 = size1;
            textBox462.Size = size26;
            TextBox46.TabIndex = 19;
            TextBox46.TabStop = false;
            TextBox46.Tag = "d23";
            TextBox46.Text = "";
            TextBox textBox91 = TextBox9;
            point1 = new Point(224, 112);
            Point point27 = point1;
            textBox91.Location = point27;
            TextBox9.Name = "TextBox9";
            TextBox9.ReadOnly = true;
            TextBox textBox92 = TextBox9;
            size1 = new Size(136, 20);
            Size size27 = size1;
            textBox92.Size = size27;
            TextBox9.TabIndex = 9;
            TextBox9.TabStop = false;
            TextBox9.Tag = "rr4";
            TextBox9.Text = "";
            TextBox9.TextAlign = HorizontalAlignment.Right;
            Label label61 = Label6;
            point1 = new Point(16, 112);
            Point point28 = point1;
            label61.Location = point28;
            Label6.Name = "Label6";
            Label label62 = Label6;
            size1 = new Size(64, 16);
            Size size28 = size1;
            label62.Size = size28;
            Label6.TabIndex = 13;
            Label6.Text = "Battlecry 5";
            TextBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox81 = TextBox8;
            point1 = new Point(368, 112);
            Point point29 = point1;
            textBox81.Location = point29;
            TextBox8.Name = "TextBox8";
            TextBox8.ReadOnly = true;
            TextBox textBox82 = TextBox8;
            size1 = new Size(272, 20);
            Size size29 = size1;
            textBox82.Size = size29;
            TextBox8.TabIndex = 11;
            TextBox8.TabStop = false;
            TextBox8.Tag = "d4";
            TextBox8.Text = "";
            TextBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox71 = TextBox7;
            point1 = new Point(368, 136);
            Point point30 = point1;
            textBox71.Location = point30;
            TextBox7.Name = "TextBox7";
            TextBox7.ReadOnly = true;
            TextBox textBox72 = TextBox7;
            size1 = new Size(272, 20);
            Size size30 = size1;
            textBox72.Size = size30;
            TextBox7.TabIndex = 10;
            TextBox7.TabStop = false;
            TextBox7.Tag = "d5";
            TextBox7.Text = "";
            NudBat5.Enabled = false;
            NumericUpDown nudBat51 = NudBat5;
            point1 = new Point(152, 112);
            Point point31 = point1;
            nudBat51.Location = point31;
            NumericUpDown nudBat52 = NudBat5;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num14 = num1;
            nudBat52.Maximum = num14;
            NumericUpDown nudBat53 = NudBat5;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num15 = num1;
            nudBat53.Minimum = num15;
            NudBat5.Name = "nudBat5";
            NumericUpDown nudBat54 = NudBat5;
            size1 = new Size(64, 20);
            Size size31 = size1;
            nudBat54.Size = size31;
            NudBat5.TabIndex = 4;
            NudBat5.Tag = "4";
            NudBat5.TextAlign = HorizontalAlignment.Right;
            TextBox textBox101 = TextBox10;
            point1 = new Point(224, 136);
            Point point32 = point1;
            textBox101.Location = point32;
            TextBox10.Name = "TextBox10";
            TextBox10.ReadOnly = true;
            TextBox textBox102 = TextBox10;
            size1 = new Size(136, 20);
            Size size32 = size1;
            textBox102.Size = size32;
            TextBox10.TabIndex = 8;
            TextBox10.TabStop = false;
            TextBox10.Tag = "rr5";
            TextBox10.Text = "";
            TextBox10.TextAlign = HorizontalAlignment.Right;
            Label label51 = Label5;
            point1 = new Point(16, 136);
            Point point33 = point1;
            label51.Location = point33;
            Label5.Name = "Label5";
            Label label52 = Label5;
            size1 = new Size(64, 16);
            Size size33 = size1;
            label52.Size = size33;
            Label5.TabIndex = 12;
            Label5.Text = "Battlecry 6";
            NudBat6.Enabled = false;
            NumericUpDown nudBat61 = NudBat6;
            point1 = new Point(152, 136);
            Point point34 = point1;
            nudBat61.Location = point34;
            NumericUpDown nudBat62 = NudBat6;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num16 = num1;
            nudBat62.Maximum = num16;
            NumericUpDown nudBat63 = NudBat6;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num17 = num1;
            nudBat63.Minimum = num17;
            NudBat6.Name = "nudBat6";
            NumericUpDown nudBat64 = NudBat6;
            size1 = new Size(64, 20);
            Size size34 = size1;
            nudBat64.Size = size34;
            NudBat6.TabIndex = 5;
            NudBat6.Tag = "5";
            NudBat6.TextAlign = HorizontalAlignment.Right;
            NudSel1.Enabled = false;
            NumericUpDown nudSel11 = NudSel1;
            point1 = new Point(152, 168);
            Point point35 = point1;
            nudSel11.Location = point35;
            NumericUpDown nudSel12 = NudSel1;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num18 = num1;
            nudSel12.Maximum = num18;
            NumericUpDown nudSel13 = NudSel1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num19 = num1;
            nudSel13.Minimum = num19;
            NudSel1.Name = "nudSel1";
            NumericUpDown nudSel14 = NudSel1;
            size1 = new Size(64, 20);
            Size size35 = size1;
            nudSel14.Size = size35;
            NudSel1.TabIndex = 6;
            NudSel1.Tag = "6";
            NudSel1.TextAlign = HorizontalAlignment.Right;
            TextBox textBox111 = TextBox11;
            point1 = new Point(224, 168);
            Point point36 = point1;
            textBox111.Location = point36;
            TextBox11.Name = "TextBox11";
            TextBox11.ReadOnly = true;
            TextBox textBox112 = TextBox11;
            size1 = new Size(136, 20);
            Size size36 = size1;
            textBox112.Size = size36;
            TextBox11.TabIndex = 4;
            TextBox11.TabStop = false;
            TextBox11.Tag = "rr6";
            TextBox11.Text = "";
            TextBox11.TextAlign = HorizontalAlignment.Right;
            TextBox12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox121 = TextBox12;
            point1 = new Point(368, 168);
            Point point37 = point1;
            textBox121.Location = point37;
            TextBox12.Name = "TextBox12";
            TextBox12.ReadOnly = true;
            TextBox textBox122 = TextBox12;
            size1 = new Size(272, 20);
            Size size37 = size1;
            textBox122.Size = size37;
            TextBox12.TabIndex = 4;
            TextBox12.TabStop = false;
            TextBox12.Tag = "d6";
            TextBox12.Text = "";
            TextBox13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox131 = TextBox13;
            point1 = new Point(368, 216);
            Point point38 = point1;
            textBox131.Location = point38;
            TextBox13.Name = "TextBox13";
            TextBox13.ReadOnly = true;
            TextBox textBox132 = TextBox13;
            size1 = new Size(272, 20);
            Size size38 = size1;
            textBox132.Size = size38;
            TextBox13.TabIndex = 4;
            TextBox13.TabStop = false;
            TextBox13.Tag = "d8";
            TextBox13.Text = "";
            TextBox textBox141 = TextBox14;
            point1 = new Point(224, 216);
            Point point39 = point1;
            textBox141.Location = point39;
            TextBox14.Name = "TextBox14";
            TextBox14.ReadOnly = true;
            TextBox textBox142 = TextBox14;
            size1 = new Size(136, 20);
            Size size39 = size1;
            textBox142.Size = size39;
            TextBox14.TabIndex = 4;
            TextBox14.TabStop = false;
            TextBox14.Tag = "rr8";
            TextBox14.Text = "";
            TextBox14.TextAlign = HorizontalAlignment.Right;
            Label label71 = Label7;
            point1 = new Point(16, 216);
            Point point40 = point1;
            label71.Location = point40;
            Label7.Name = "Label7";
            Label label72 = Label7;
            size1 = new Size(64, 16);
            Size size40 = size1;
            label72.Size = size40;
            Label7.TabIndex = 5;
            Label7.Text = "Select 3";
            NudSel3.Enabled = false;
            NumericUpDown nudSel31 = NudSel3;
            point1 = new Point(152, 216);
            Point point41 = point1;
            nudSel31.Location = point41;
            NumericUpDown nudSel32 = NudSel3;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num20 = num1;
            nudSel32.Maximum = num20;
            NumericUpDown nudSel33 = NudSel3;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num21 = num1;
            nudSel33.Minimum = num21;
            NudSel3.Name = "nudSel3";
            NumericUpDown nudSel34 = NudSel3;
            size1 = new Size(64, 20);
            Size size41 = size1;
            nudSel34.Size = size41;
            NudSel3.TabIndex = 8;
            NudSel3.Tag = "8";
            NudSel3.TextAlign = HorizontalAlignment.Right;
            TextBox textBox151 = TextBox15;
            point1 = new Point(224, 192);
            Point point42 = point1;
            textBox151.Location = point42;
            TextBox15.Name = "TextBox15";
            TextBox15.ReadOnly = true;
            TextBox textBox152 = TextBox15;
            size1 = new Size(136, 20);
            Size size42 = size1;
            textBox152.Size = size42;
            TextBox15.TabIndex = 4;
            TextBox15.TabStop = false;
            TextBox15.Tag = "rr7";
            TextBox15.Text = "";
            TextBox15.TextAlign = HorizontalAlignment.Right;
            TextBox16.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox161 = TextBox16;
            point1 = new Point(368, 192);
            Point point43 = point1;
            textBox161.Location = point43;
            TextBox16.Name = "TextBox16";
            TextBox16.ReadOnly = true;
            TextBox textBox162 = TextBox16;
            size1 = new Size(272, 20);
            Size size43 = size1;
            textBox162.Size = size43;
            TextBox16.TabIndex = 4;
            TextBox16.TabStop = false;
            TextBox16.Tag = "d7";
            TextBox16.Text = "";
            NudSel2.Enabled = false;
            NumericUpDown nudSel21 = NudSel2;
            point1 = new Point(152, 192);
            Point point44 = point1;
            nudSel21.Location = point44;
            NumericUpDown nudSel22 = NudSel2;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num22 = num1;
            nudSel22.Maximum = num22;
            NumericUpDown nudSel23 = NudSel2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num23 = num1;
            nudSel23.Minimum = num23;
            NudSel2.Name = "nudSel2";
            NumericUpDown nudSel24 = NudSel2;
            size1 = new Size(64, 20);
            Size size44 = size1;
            nudSel24.Size = size44;
            NudSel2.TabIndex = 7;
            NudSel2.Tag = "7";
            NudSel2.TextAlign = HorizontalAlignment.Right;
            Label label81 = Label8;
            point1 = new Point(16, 192);
            Point point45 = point1;
            label81.Location = point45;
            Label8.Name = "Label8";
            Label label82 = Label8;
            size1 = new Size(64, 16);
            Size size45 = size1;
            label82.Size = size45;
            Label8.TabIndex = 5;
            Label8.Text = "Select 2";
            Label label91 = Label9;
            point1 = new Point(16, 168);
            Point point46 = point1;
            label91.Location = point46;
            Label9.Name = "Label9";
            Label label92 = Label9;
            size1 = new Size(64, 16);
            Size size46 = size1;
            label92.Size = size46;
            Label9.TabIndex = 5;
            Label9.Text = "Select 1";
            TextBox textBox171 = TextBox17;
            point1 = new Point(224, 272);
            Point point47 = point1;
            textBox171.Location = point47;
            TextBox17.Name = "TextBox17";
            TextBox17.ReadOnly = true;
            TextBox textBox172 = TextBox17;
            size1 = new Size(136, 20);
            Size size47 = size1;
            textBox172.Size = size47;
            TextBox17.TabIndex = 4;
            TextBox17.TabStop = false;
            TextBox17.Tag = "rr10";
            TextBox17.Text = "";
            TextBox17.TextAlign = HorizontalAlignment.Right;
            TextBox18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox181 = TextBox18;
            point1 = new Point(368, 272);
            Point point48 = point1;
            textBox181.Location = point48;
            TextBox18.Name = "TextBox18";
            TextBox18.ReadOnly = true;
            TextBox textBox182 = TextBox18;
            size1 = new Size(272, 20);
            Size size48 = size1;
            textBox182.Size = size48;
            TextBox18.TabIndex = 4;
            TextBox18.TabStop = false;
            TextBox18.Tag = "d10";
            TextBox18.Text = "";
            NudAtk2.Enabled = false;
            NumericUpDown nudAtk21 = NudAtk2;
            point1 = new Point(152, 272);
            Point point49 = point1;
            nudAtk21.Location = point49;
            NumericUpDown nudAtk22 = NudAtk2;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num24 = num1;
            nudAtk22.Maximum = num24;
            NumericUpDown nudAtk23 = NudAtk2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num25 = num1;
            nudAtk23.Minimum = num25;
            NudAtk2.Name = "nudAtk2";
            NumericUpDown nudAtk24 = NudAtk2;
            size1 = new Size(64, 20);
            Size size49 = size1;
            nudAtk24.Size = size49;
            NudAtk2.TabIndex = 10;
            NudAtk2.Tag = "10";
            NudAtk2.TextAlign = HorizontalAlignment.Right;
            Label label101 = Label10;
            point1 = new Point(16, 272);
            Point point50 = point1;
            label101.Location = point50;
            Label10.Name = "Label10";
            Label label102 = Label10;
            size1 = new Size(88, 16);
            Size size50 = size1;
            label102.Size = size50;
            Label10.TabIndex = 5;
            Label10.Text = "Attack Grunt 2";
            Label label111 = Label11;
            point1 = new Point(16, 248);
            Point point51 = point1;
            label111.Location = point51;
            Label11.Name = "Label11";
            Label label112 = Label11;
            size1 = new Size(88, 16);
            Size size51 = size1;
            label112.Size = size51;
            Label11.TabIndex = 5;
            Label11.Text = "Attack Grunt 1";
            NudAtk1.Enabled = false;
            NumericUpDown nudAtk11 = NudAtk1;
            point1 = new Point(152, 248);
            Point point52 = point1;
            nudAtk11.Location = point52;
            NumericUpDown nudAtk12 = NudAtk1;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num26 = num1;
            nudAtk12.Maximum = num26;
            NumericUpDown nudAtk13 = NudAtk1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num27 = num1;
            nudAtk13.Minimum = num27;
            NudAtk1.Name = "nudAtk1";
            NumericUpDown nudAtk14 = NudAtk1;
            size1 = new Size(64, 20);
            Size size52 = size1;
            nudAtk14.Size = size52;
            NudAtk1.TabIndex = 9;
            NudAtk1.Tag = "9";
            NudAtk1.TextAlign = HorizontalAlignment.Right;
            TextBox textBox191 = TextBox19;
            point1 = new Point(224, 248);
            Point point53 = point1;
            textBox191.Location = point53;
            TextBox19.Name = "TextBox19";
            TextBox19.ReadOnly = true;
            TextBox textBox192 = TextBox19;
            size1 = new Size(136, 20);
            Size size53 = size1;
            textBox192.Size = size53;
            TextBox19.TabIndex = 4;
            TextBox19.TabStop = false;
            TextBox19.Tag = "rr9";
            TextBox19.Text = "";
            TextBox19.TextAlign = HorizontalAlignment.Right;
            TextBox20.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox201 = TextBox20;
            point1 = new Point(368, 248);
            Point point54 = point1;
            textBox201.Location = point54;
            TextBox20.Name = "TextBox20";
            TextBox20.ReadOnly = true;
            TextBox textBox202 = TextBox20;
            size1 = new Size(272, 20);
            Size size54 = size1;
            textBox202.Size = size54;
            TextBox20.TabIndex = 4;
            TextBox20.TabStop = false;
            TextBox20.Tag = "d9";
            TextBox20.Text = "";
            TextBox textBox211 = TextBox21;
            point1 = new Point(224, 296);
            Point point55 = point1;
            textBox211.Location = point55;
            TextBox21.Name = "TextBox21";
            TextBox21.ReadOnly = true;
            TextBox textBox212 = TextBox21;
            size1 = new Size(136, 20);
            Size size55 = size1;
            textBox212.Size = size55;
            TextBox21.TabIndex = 4;
            TextBox21.TabStop = false;
            TextBox21.Tag = "rr11";
            TextBox21.Text = "";
            TextBox21.TextAlign = HorizontalAlignment.Right;
            TextBox22.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox221 = TextBox22;
            point1 = new Point(368, 296);
            Point point56 = point1;
            textBox221.Location = point56;
            TextBox22.Name = "TextBox22";
            TextBox22.ReadOnly = true;
            TextBox textBox222 = TextBox22;
            size1 = new Size(272, 20);
            Size size56 = size1;
            textBox222.Size = size56;
            TextBox22.TabIndex = 4;
            TextBox22.TabStop = false;
            TextBox22.Tag = "d11";
            TextBox22.Text = "";
            NudAtk3.Enabled = false;
            NumericUpDown nudAtk31 = NudAtk3;
            point1 = new Point(152, 296);
            Point point57 = point1;
            nudAtk31.Location = point57;
            NumericUpDown nudAtk32 = NudAtk3;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num28 = num1;
            nudAtk32.Maximum = num28;
            NumericUpDown nudAtk33 = NudAtk3;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num29 = num1;
            nudAtk33.Minimum = num29;
            NudAtk3.Name = "nudAtk3";
            NumericUpDown nudAtk34 = NudAtk3;
            size1 = new Size(64, 20);
            Size size57 = size1;
            nudAtk34.Size = size57;
            NudAtk3.TabIndex = 11;
            NudAtk3.Tag = "11";
            NudAtk3.TextAlign = HorizontalAlignment.Right;
            Label label121 = Label12;
            point1 = new Point(16, 296);
            Point point58 = point1;
            label121.Location = point58;
            Label12.Name = "Label12";
            Label label122 = Label12;
            size1 = new Size(88, 16);
            Size size58 = size1;
            label122.Size = size58;
            Label12.TabIndex = 5;
            Label12.Text = "Attack Grunt 3";
            NudHit2.Enabled = false;
            NumericUpDown nudHit21 = NudHit2;
            point1 = new Point(152, 352);
            Point point59 = point1;
            nudHit21.Location = point59;
            NumericUpDown nudHit22 = NudHit2;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num30 = num1;
            nudHit22.Maximum = num30;
            NumericUpDown nudHit23 = NudHit2;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num31 = num1;
            nudHit23.Minimum = num31;
            NudHit2.Name = "nudHit2";
            NumericUpDown nudHit24 = NudHit2;
            size1 = new Size(64, 20);
            Size size59 = size1;
            nudHit24.Size = size59;
            NudHit2.TabIndex = 13;
            NudHit2.Tag = "13";
            NudHit2.TextAlign = HorizontalAlignment.Right;
            Label label131 = Label13;
            point1 = new Point(16, 352);
            Point point60 = point1;
            label131.Location = point60;
            Label13.Name = "Label13";
            Label label132 = Label13;
            size1 = new Size(88, 16);
            Size size60 = size1;
            label132.Size = size60;
            Label13.TabIndex = 5;
            Label13.Text = "Pain Grunt 2";
            Label label141 = Label14;
            point1 = new Point(16, 328);
            Point point61 = point1;
            label141.Location = point61;
            Label14.Name = "Label14";
            Label label142 = Label14;
            size1 = new Size(88, 16);
            Size size61 = size1;
            label142.Size = size61;
            Label14.TabIndex = 5;
            Label14.Text = "Pain Grunt 1";
            NudHit1.Enabled = false;
            NumericUpDown nudHit11 = NudHit1;
            point1 = new Point(152, 328);
            Point point62 = point1;
            nudHit11.Location = point62;
            NumericUpDown nudHit12 = NudHit1;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num32 = num1;
            nudHit12.Maximum = num32;
            NumericUpDown nudHit13 = NudHit1;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num33 = num1;
            nudHit13.Minimum = num33;
            NudHit1.Name = "nudHit1";
            NumericUpDown nudHit14 = NudHit1;
            size1 = new Size(64, 20);
            Size size62 = size1;
            nudHit14.Size = size62;
            NudHit1.TabIndex = 12;
            NudHit1.Tag = "12";
            NudHit1.TextAlign = HorizontalAlignment.Right;
            TextBox textBox231 = TextBox23;
            point1 = new Point(224, 328);
            Point point63 = point1;
            textBox231.Location = point63;
            TextBox23.Name = "TextBox23";
            TextBox23.ReadOnly = true;
            TextBox textBox232 = TextBox23;
            size1 = new Size(136, 20);
            Size size63 = size1;
            textBox232.Size = size63;
            TextBox23.TabIndex = 4;
            TextBox23.TabStop = false;
            TextBox23.Tag = "rr12";
            TextBox23.Text = "";
            TextBox23.TextAlign = HorizontalAlignment.Right;
            TextBox24.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox241 = TextBox24;
            point1 = new Point(368, 328);
            Point point64 = point1;
            textBox241.Location = point64;
            TextBox24.Name = "TextBox24";
            TextBox24.ReadOnly = true;
            TextBox textBox242 = TextBox24;
            size1 = new Size(272, 20);
            Size size64 = size1;
            textBox242.Size = size64;
            TextBox24.TabIndex = 4;
            TextBox24.TabStop = false;
            TextBox24.Tag = "d12";
            TextBox24.Text = "";
            TextBox textBox251 = TextBox25;
            point1 = new Point(224, 352);
            Point point65 = point1;
            textBox251.Location = point65;
            TextBox25.Name = "TextBox25";
            TextBox25.ReadOnly = true;
            TextBox textBox252 = TextBox25;
            size1 = new Size(136, 20);
            Size size65 = size1;
            textBox252.Size = size65;
            TextBox25.TabIndex = 4;
            TextBox25.TabStop = false;
            TextBox25.Tag = "rr13";
            TextBox25.Text = "";
            TextBox25.TextAlign = HorizontalAlignment.Right;
            TextBox26.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox261 = TextBox26;
            point1 = new Point(368, 352);
            Point point66 = point1;
            textBox261.Location = point66;
            TextBox26.Name = "TextBox26";
            TextBox26.ReadOnly = true;
            TextBox textBox262 = TextBox26;
            size1 = new Size(272, 20);
            Size size66 = size1;
            textBox262.Size = size66;
            TextBox26.TabIndex = 4;
            TextBox26.TabStop = false;
            TextBox26.Tag = "d13";
            TextBox26.Text = "";
            TextBox textBox271 = TextBox27;
            point1 = new Point(224, 408);
            Point point67 = point1;
            textBox271.Location = point67;
            TextBox27.Name = "TextBox27";
            TextBox27.ReadOnly = true;
            TextBox textBox272 = TextBox27;
            size1 = new Size(136, 20);
            Size size67 = size1;
            textBox272.Size = size67;
            TextBox27.TabIndex = 4;
            TextBox27.TabStop = false;
            TextBox27.Tag = "rr15";
            TextBox27.Text = "";
            TextBox27.TextAlign = HorizontalAlignment.Right;
            TextBox28.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox281 = TextBox28;
            point1 = new Point(368, 408);
            Point point68 = point1;
            textBox281.Location = point68;
            TextBox28.Name = "TextBox28";
            TextBox28.ReadOnly = true;
            TextBox textBox282 = TextBox28;
            size1 = new Size(272, 20);
            Size size68 = size1;
            textBox282.Size = size68;
            TextBox28.TabIndex = 4;
            TextBox28.TabStop = false;
            TextBox28.Tag = "d15";
            TextBox28.Text = "";
            NudDead.Enabled = false;
            NumericUpDown nudDead1 = NudDead;
            point1 = new Point(152, 408);
            Point point69 = point1;
            nudDead1.Location = point69;
            NumericUpDown nudDead2 = NudDead;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num34 = num1;
            nudDead2.Maximum = num34;
            NumericUpDown nudDead3 = NudDead;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num35 = num1;
            nudDead3.Minimum = num35;
            NudDead.Name = "nudDead";
            NumericUpDown nudDead4 = NudDead;
            size1 = new Size(64, 20);
            Size size69 = size1;
            nudDead4.Size = size69;
            NudDead.TabIndex = 15;
            NudDead.Tag = "15";
            NudDead.TextAlign = HorizontalAlignment.Right;
            Label label151 = Label15;
            point1 = new Point(16, 408);
            Point point70 = point1;
            label151.Location = point70;
            Label15.Name = "Label15";
            Label label152 = Label15;
            size1 = new Size(64, 16);
            Size size70 = size1;
            label152.Size = size70;
            Label15.TabIndex = 5;
            Label15.Text = "Dead";
            TextBox29.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox291 = TextBox29;
            point1 = new Point(368, 432);
            Point point71 = point1;
            textBox291.Location = point71;
            TextBox29.Name = "TextBox29";
            TextBox29.ReadOnly = true;
            TextBox textBox292 = TextBox29;
            size1 = new Size(272, 20);
            Size size71 = size1;
            textBox292.Size = size71;
            TextBox29.TabIndex = 4;
            TextBox29.TabStop = false;
            TextBox29.Tag = "d16";
            TextBox29.Text = "";
            NudLowHlth.Enabled = false;
            NumericUpDown nudLowHlth1 = NudLowHlth;
            point1 = new Point(152, 384);
            Point point72 = point1;
            nudLowHlth1.Location = point72;
            NumericUpDown nudLowHlth2 = NudLowHlth;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num36 = num1;
            nudLowHlth2.Maximum = num36;
            NumericUpDown nudLowHlth3 = NudLowHlth;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num37 = num1;
            nudLowHlth3.Minimum = num37;
            NudLowHlth.Name = "nudLowHlth";
            NumericUpDown nudLowHlth4 = NudLowHlth;
            size1 = new Size(64, 20);
            Size size72 = size1;
            nudLowHlth4.Size = size72;
            NudLowHlth.TabIndex = 14;
            NudLowHlth.Tag = "14";
            NudLowHlth.TextAlign = HorizontalAlignment.Right;
            TextBox textBox301 = TextBox30;
            point1 = new Point(224, 432);
            Point point73 = point1;
            textBox301.Location = point73;
            TextBox30.Name = "TextBox30";
            TextBox30.ReadOnly = true;
            TextBox textBox302 = TextBox30;
            size1 = new Size(136, 20);
            Size size73 = size1;
            textBox302.Size = size73;
            TextBox30.TabIndex = 4;
            TextBox30.TabStop = false;
            TextBox30.Tag = "rr16";
            TextBox30.Text = "";
            TextBox30.TextAlign = HorizontalAlignment.Right;
            Label label161 = Label16;
            point1 = new Point(16, 432);
            Point point74 = point1;
            label161.Location = point74;
            Label16.Name = "Label16";
            Label label162 = Label16;
            size1 = new Size(64, 16);
            Size size74 = size1;
            label162.Size = size74;
            Label16.TabIndex = 5;
            Label16.Text = "Critical Hit";
            NudCrit.Enabled = false;
            NumericUpDown nudCrit1 = NudCrit;
            point1 = new Point(152, 432);
            Point point75 = point1;
            nudCrit1.Location = point75;
            NumericUpDown nudCrit2 = NudCrit;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num38 = num1;
            nudCrit2.Maximum = num38;
            NumericUpDown nudCrit3 = NudCrit;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num39 = num1;
            nudCrit3.Minimum = num39;
            NudCrit.Name = "nudCrit";
            NumericUpDown nudCrit4 = NudCrit;
            size1 = new Size(64, 20);
            Size size75 = size1;
            nudCrit4.Size = size75;
            NudCrit.TabIndex = 16;
            NudCrit.Tag = "16";
            NudCrit.TextAlign = HorizontalAlignment.Right;
            TextBox textBox311 = TextBox31;
            point1 = new Point(224, 456);
            Point point76 = point1;
            textBox311.Location = point76;
            TextBox31.Name = "TextBox31";
            TextBox31.ReadOnly = true;
            TextBox textBox312 = TextBox31;
            size1 = new Size(136, 20);
            Size size76 = size1;
            textBox312.Size = size76;
            TextBox31.TabIndex = 4;
            TextBox31.TabStop = false;
            TextBox31.Tag = "rr17";
            TextBox31.Text = "";
            TextBox31.TextAlign = HorizontalAlignment.Right;
            TextBox32.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox321 = TextBox32;
            point1 = new Point(368, 456);
            Point point77 = point1;
            textBox321.Location = point77;
            TextBox32.Name = "TextBox32";
            TextBox32.ReadOnly = true;
            TextBox textBox322 = TextBox32;
            size1 = new Size(272, 20);
            Size size77 = size1;
            textBox322.Size = size77;
            TextBox32.TabIndex = 4;
            TextBox32.TabStop = false;
            TextBox32.Tag = "d17";
            TextBox32.Text = "";
            NudTia.Enabled = false;
            NumericUpDown nudTia1 = NudTia;
            point1 = new Point(152, 456);
            Point point78 = point1;
            nudTia1.Location = point78;
            NumericUpDown nudTia2 = NudTia;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num40 = num1;
            nudTia2.Maximum = num40;
            NumericUpDown nudTia3 = NudTia;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num41 = num1;
            nudTia3.Minimum = num41;
            NudTia.Name = "nudTIA";
            NumericUpDown nudTia4 = NudTia;
            size1 = new Size(64, 20);
            Size size78 = size1;
            nudTia4.Size = size78;
            NudTia.TabIndex = 17;
            NudTia.Tag = "17";
            NudTia.TextAlign = HorizontalAlignment.Right;
            Label label171 = Label17;
            point1 = new Point(16, 456);
            Point point79 = point1;
            label171.Location = point79;
            Label17.Name = "Label17";
            Label label172 = Label17;
            size1 = new Size(152, 16);
            Size size79 = size1;
            label172.Size = size79;
            Label17.TabIndex = 5;
            Label17.Text = "Target Immune to Assault";
            TextBox textBox331 = TextBox33;
            point1 = new Point(224, 480);
            Point point80 = point1;
            textBox331.Location = point80;
            TextBox33.Name = "TextBox33";
            TextBox33.ReadOnly = true;
            TextBox textBox332 = TextBox33;
            size1 = new Size(136, 20);
            Size size80 = size1;
            textBox332.Size = size80;
            TextBox33.TabIndex = 9;
            TextBox33.TabStop = false;
            TextBox33.Tag = "rr18";
            TextBox33.Text = "";
            TextBox33.TextAlign = HorizontalAlignment.Right;
            Label label181 = Label18;
            point1 = new Point(16, 480);
            Point point81 = point1;
            label181.Location = point81;
            Label18.Name = "Label18";
            Label label182 = Label18;
            size1 = new Size(64, 16);
            Size size81 = size1;
            label182.Size = size81;
            Label18.TabIndex = 13;
            Label18.Text = "Lay Mine";
            TextBox34.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox341 = TextBox34;
            point1 = new Point(368, 480);
            Point point82 = point1;
            textBox341.Location = point82;
            TextBox34.Name = "TextBox34";
            TextBox34.ReadOnly = true;
            TextBox textBox342 = TextBox34;
            size1 = new Size(272, 20);
            Size size82 = size1;
            textBox342.Size = size82;
            TextBox34.TabIndex = 11;
            TextBox34.TabStop = false;
            TextBox34.Tag = "d18";
            TextBox34.Text = "";
            TextBox textBox351 = TextBox35;
            point1 = new Point(224, 384);
            Point point83 = point1;
            textBox351.Location = point83;
            TextBox35.Name = "TextBox35";
            TextBox35.ReadOnly = true;
            TextBox textBox352 = TextBox35;
            size1 = new Size(136, 20);
            Size size83 = size1;
            textBox352.Size = size83;
            TextBox35.TabIndex = 4;
            TextBox35.TabStop = false;
            TextBox35.Tag = "rr14";
            TextBox35.Text = "";
            TextBox35.TextAlign = HorizontalAlignment.Right;
            TextBox36.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox361 = TextBox36;
            point1 = new Point(368, 384);
            Point point84 = point1;
            textBox361.Location = point84;
            TextBox36.Name = "TextBox36";
            TextBox36.ReadOnly = true;
            TextBox textBox362 = TextBox36;
            size1 = new Size(272, 20);
            Size size84 = size1;
            textBox362.Size = size84;
            TextBox36.TabIndex = 4;
            TextBox36.TabStop = false;
            TextBox36.Tag = "d14";
            TextBox36.Text = "";
            NudLMin.Enabled = false;
            NumericUpDown nudLmin1 = NudLMin;
            point1 = new Point(152, 480);
            Point point85 = point1;
            nudLmin1.Location = point85;
            NumericUpDown nudLmin2 = NudLMin;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num42 = num1;
            nudLmin2.Maximum = num42;
            NumericUpDown nudLmin3 = NudLMin;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num43 = num1;
            nudLmin3.Minimum = num43;
            NudLMin.Name = "nudLMin";
            NumericUpDown nudLmin4 = NudLMin;
            size1 = new Size(64, 20);
            Size size85 = size1;
            nudLmin4.Size = size85;
            NudLMin.TabIndex = 18;
            NudLMin.Tag = "18";
            NudLMin.TextAlign = HorizontalAlignment.Right;
            Label label191 = Label19;
            point1 = new Point(16, 384);
            Point point86 = point1;
            label191.Location = point86;
            Label19.Name = "Label19";
            Label label192 = Label19;
            size1 = new Size(64, 16);
            Size size86 = size1;
            label192.Size = size86;
            Label19.TabIndex = 5;
            Label19.Text = "Low Health";
            NudDMin.Enabled = false;
            NumericUpDown nudDmin1 = NudDMin;
            point1 = new Point(152, 504);
            Point point87 = point1;
            nudDmin1.Location = point87;
            NumericUpDown nudDmin2 = NudDMin;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num44 = num1;
            nudDmin2.Maximum = num44;
            NumericUpDown nudDmin3 = NudDMin;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num45 = num1;
            nudDmin3.Minimum = num45;
            NudDMin.Name = "nudDMin";
            NumericUpDown nudDmin4 = NudDMin;
            size1 = new Size(64, 20);
            Size size87 = size1;
            nudDmin4.Size = size87;
            NudDMin.TabIndex = 19;
            NudDMin.Tag = "19";
            NudDMin.TextAlign = HorizontalAlignment.Right;
            TextBox37.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox371 = TextBox37;
            point1 = new Point(368, 504);
            Point point88 = point1;
            textBox371.Location = point88;
            TextBox37.Name = "TextBox37";
            TextBox37.ReadOnly = true;
            TextBox textBox372 = TextBox37;
            size1 = new Size(272, 20);
            Size size88 = size1;
            textBox372.Size = size88;
            TextBox37.TabIndex = 11;
            TextBox37.TabStop = false;
            TextBox37.Tag = "d19";
            TextBox37.Text = "";
            Label label201 = Label20;
            point1 = new Point(16, 504);
            Point point89 = point1;
            label201.Location = point89;
            Label20.Name = "Label20";
            Label label202 = Label20;
            size1 = new Size(96, 16);
            Size size89 = size1;
            label202.Size = size89;
            Label20.TabIndex = 13;
            Label20.Text = "Disarm Mine";
            TextBox textBox381 = TextBox38;
            point1 = new Point(224, 504);
            Point point90 = point1;
            textBox381.Location = point90;
            TextBox38.Name = "TextBox38";
            TextBox38.ReadOnly = true;
            TextBox textBox382 = TextBox38;
            size1 = new Size(136, 20);
            Size size90 = size1;
            textBox382.Size = size90;
            TextBox38.TabIndex = 9;
            TextBox38.TabStop = false;
            TextBox38.Tag = "rr19";
            TextBox38.Text = "";
            TextBox38.TextAlign = HorizontalAlignment.Right;
            TextBox textBox391 = TextBox39;
            point1 = new Point(224, 536);
            Point point91 = point1;
            textBox391.Location = point91;
            TextBox39.Name = "TextBox39";
            TextBox39.ReadOnly = true;
            TextBox textBox392 = TextBox39;
            size1 = new Size(136, 20);
            Size size91 = size1;
            textBox392.Size = size91;
            TextBox39.TabIndex = 9;
            TextBox39.TabStop = false;
            TextBox39.Tag = "rr20";
            TextBox39.Text = "";
            TextBox39.TextAlign = HorizontalAlignment.Right;
            Label label211 = Label21;
            point1 = new Point(16, 560);
            Point point92 = point1;
            label211.Location = point92;
            Label21.Name = "Label21";
            Label label212 = Label21;
            size1 = new Size(80, 16);
            Size size92 = size1;
            label212.Size = size92;
            Label21.TabIndex = 13;
            Label21.Text = "Begin Search";
            TextBox textBox401 = TextBox40;
            point1 = new Point(224, 560);
            Point point93 = point1;
            textBox401.Location = point93;
            TextBox40.Name = "TextBox40";
            TextBox40.ReadOnly = true;
            TextBox textBox402 = TextBox40;
            size1 = new Size(136, 20);
            Size size93 = size1;
            textBox402.Size = size93;
            TextBox40.TabIndex = 9;
            TextBox40.TabStop = false;
            TextBox40.Tag = "rr21";
            TextBox40.Text = "";
            TextBox40.TextAlign = HorizontalAlignment.Right;
            Label label221 = Label22;
            point1 = new Point(16, 536);
            Point point94 = point1;
            label221.Location = point94;
            Label22.Name = "Label22";
            Label label222 = Label22;
            size1 = new Size(80, 16);
            Size size94 = size1;
            label222.Size = size94;
            Label22.TabIndex = 13;
            Label22.Text = "Begin Stealth";
            TextBox41.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox411 = TextBox41;
            point1 = new Point(368, 536);
            Point point95 = point1;
            textBox411.Location = point95;
            TextBox41.Name = "TextBox41";
            TextBox41.ReadOnly = true;
            TextBox textBox412 = TextBox41;
            size1 = new Size(272, 20);
            Size size95 = size1;
            textBox412.Size = size95;
            TextBox41.TabIndex = 11;
            TextBox41.TabStop = false;
            TextBox41.Tag = "d20";
            TextBox41.Text = "";
            NudStlh.Enabled = false;
            NumericUpDown nudStlh1 = NudStlh;
            point1 = new Point(152, 536);
            Point point96 = point1;
            nudStlh1.Location = point96;
            NumericUpDown nudStlh2 = NudStlh;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num46 = num1;
            nudStlh2.Maximum = num46;
            NumericUpDown nudStlh3 = NudStlh;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num47 = num1;
            nudStlh3.Minimum = num47;
            NudStlh.Name = "nudStlh";
            NumericUpDown nudStlh4 = NudStlh;
            size1 = new Size(64, 20);
            Size size96 = size1;
            nudStlh4.Size = size96;
            NudStlh.TabIndex = 20;
            NudStlh.Tag = "20";
            NudStlh.TextAlign = HorizontalAlignment.Right;
            NudSrch.Enabled = false;
            NumericUpDown nudSrch1 = NudSrch;
            point1 = new Point(152, 560);
            Point point97 = point1;
            nudSrch1.Location = point97;
            NumericUpDown nudSrch2 = NudSrch;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num48 = num1;
            nudSrch2.Maximum = num48;
            NumericUpDown nudSrch3 = NudSrch;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num49 = num1;
            nudSrch3.Minimum = num49;
            NudSrch.Name = "nudSrch";
            NumericUpDown nudSrch4 = NudSrch;
            size1 = new Size(64, 20);
            Size size97 = size1;
            nudSrch4.Size = size97;
            NudSrch.TabIndex = 21;
            NudSrch.Tag = "21";
            NudSrch.TextAlign = HorizontalAlignment.Right;
            TextBox42.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox421 = TextBox42;
            point1 = new Point(368, 560);
            Point point98 = point1;
            textBox421.Location = point98;
            TextBox42.Name = "TextBox42";
            TextBox42.ReadOnly = true;
            TextBox textBox422 = TextBox42;
            size1 = new Size(272, 20);
            Size size98 = size1;
            textBox422.Size = size98;
            TextBox42.TabIndex = 11;
            TextBox42.TabStop = false;
            TextBox42.Tag = "d21";
            TextBox42.Text = "";
            TextBox47.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox471 = TextBox47;
            point1 = new Point(368, 640);
            Point point99 = point1;
            textBox471.Location = point99;
            TextBox47.Name = "TextBox47";
            TextBox47.ReadOnly = true;
            TextBox textBox472 = TextBox47;
            size1 = new Size(272, 20);
            Size size99 = size1;
            textBox472.Size = size99;
            TextBox47.TabIndex = 18;
            TextBox47.TabStop = false;
            TextBox47.Tag = "d24";
            TextBox47.Text = "";
            NudSucceedUnlock.Enabled = false;
            NumericUpDown nudSucceedUnlock1 = NudSucceedUnlock;
            point1 = new Point(152, 640);
            Point point100 = point1;
            nudSucceedUnlock1.Location = point100;
            NumericUpDown nudSucceedUnlock2 = NudSucceedUnlock;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num50 = num1;
            nudSucceedUnlock2.Maximum = num50;
            NumericUpDown nudSucceedUnlock3 = NudSucceedUnlock;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num51 = num1;
            nudSucceedUnlock3.Minimum = num51;
            NudSucceedUnlock.Name = "nudSucceedUnlock";
            NumericUpDown nudSucceedUnlock4 = NudSucceedUnlock;
            size1 = new Size(64, 20);
            Size size100 = size1;
            nudSucceedUnlock4.Size = size100;
            NudSucceedUnlock.TabIndex = 24;
            NudSucceedUnlock.Tag = "24";
            NudSucceedUnlock.TextAlign = HorizontalAlignment.Right;
            NudLeaveParty.Enabled = false;
            NumericUpDown nudLeaveParty1 = NudLeaveParty;
            point1 = new Point(152, 664);
            Point point101 = point1;
            nudLeaveParty1.Location = point101;
            NumericUpDown nudLeaveParty2 = NudLeaveParty;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num52 = num1;
            nudLeaveParty2.Maximum = num52;
            NumericUpDown nudLeaveParty3 = NudLeaveParty;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num53 = num1;
            nudLeaveParty3.Minimum = num53;
            NudLeaveParty.Name = "nudLeaveParty";
            NumericUpDown nudLeaveParty4 = NudLeaveParty;
            size1 = new Size(64, 20);
            Size size101 = size1;
            nudLeaveParty4.Size = size101;
            NudLeaveParty.TabIndex = 25;
            NudLeaveParty.Tag = "25";
            NudLeaveParty.TextAlign = HorizontalAlignment.Right;
            TextBox48.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox481 = TextBox48;
            point1 = new Point(368, 664);
            Point point102 = point1;
            textBox481.Location = point102;
            TextBox48.Name = "TextBox48";
            TextBox48.ReadOnly = true;
            TextBox textBox482 = TextBox48;
            size1 = new Size(272, 20);
            Size size102 = size1;
            textBox482.Size = size102;
            TextBox48.TabIndex = 19;
            TextBox48.TabStop = false;
            TextBox48.Tag = "d25";
            TextBox48.Text = "";
            TextBox textBox491 = TextBox49;
            point1 = new Point(224, 664);
            Point point103 = point1;
            textBox491.Location = point103;
            TextBox49.Name = "TextBox49";
            TextBox49.ReadOnly = true;
            TextBox textBox492 = TextBox49;
            size1 = new Size(136, 20);
            Size size103 = size1;
            textBox492.Size = size103;
            TextBox49.TabIndex = 16;
            TextBox49.TabStop = false;
            TextBox49.Tag = "rr25";
            TextBox49.Text = "";
            TextBox49.TextAlign = HorizontalAlignment.Right;
            TextBox textBox501 = TextBox50;
            point1 = new Point(224, 640);
            Point point104 = point1;
            textBox501.Location = point104;
            TextBox50.Name = "TextBox50";
            TextBox50.ReadOnly = true;
            TextBox textBox502 = TextBox50;
            size1 = new Size(136, 20);
            Size size104 = size1;
            textBox502.Size = size104;
            TextBox50.TabIndex = 17;
            TextBox50.TabStop = false;
            TextBox50.Tag = "rr24";
            TextBox50.Text = "";
            TextBox50.TextAlign = HorizontalAlignment.Right;
            Label label251 = Label25;
            point1 = new Point(16, 712);
            Point point105 = point1;
            label251.Location = point105;
            Label25.Name = "Label25";
            Label label252 = Label25;
            size1 = new Size(80, 16);
            Size size105 = size1;
            label252.Size = size105;
            Label25.TabIndex = 20;
            Label25.Text = "Poisoned";
            Label label261 = Label26;
            point1 = new Point(16, 640);
            Point point106 = point1;
            label261.Location = point106;
            Label26.Name = "Label26";
            Label label262 = Label26;
            size1 = new Size(88, 16);
            Size size106 = size1;
            label262.Size = size106;
            Label26.TabIndex = 21;
            Label26.Text = "Unlock Success";
            TextBox51.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox511 = TextBox51;
            point1 = new Point(368, 688);
            Point point107 = point1;
            textBox511.Location = point107;
            TextBox51.Name = "TextBox51";
            TextBox51.ReadOnly = true;
            TextBox textBox512 = TextBox51;
            size1 = new Size(272, 20);
            Size size107 = size1;
            textBox512.Size = size107;
            TextBox51.TabIndex = 18;
            TextBox51.TabStop = false;
            TextBox51.Tag = "d26";
            TextBox51.Text = "";
            NudRejoinParty.Enabled = false;
            NumericUpDown nudRejoinParty1 = NudRejoinParty;
            point1 = new Point(152, 688);
            Point point108 = point1;
            nudRejoinParty1.Location = point108;
            NumericUpDown nudRejoinParty2 = NudRejoinParty;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num54 = num1;
            nudRejoinParty2.Maximum = num54;
            NumericUpDown nudRejoinParty3 = NudRejoinParty;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num55 = num1;
            nudRejoinParty3.Minimum = num55;
            NudRejoinParty.Name = "nudRejoinParty";
            NumericUpDown nudRejoinParty4 = NudRejoinParty;
            size1 = new Size(64, 20);
            Size size108 = size1;
            nudRejoinParty4.Size = size108;
            NudRejoinParty.TabIndex = 26;
            NudRejoinParty.Tag = "26";
            NudRejoinParty.TextAlign = HorizontalAlignment.Right;
            NudPoisoned.Enabled = false;
            NumericUpDown nudPoisoned1 = NudPoisoned;
            point1 = new Point(152, 712);
            Point point109 = point1;
            nudPoisoned1.Location = point109;
            NumericUpDown nudPoisoned2 = NudPoisoned;
            num1 = new Decimal(new int[4] {300000, 0, 0, 0});
            Decimal num56 = num1;
            nudPoisoned2.Maximum = num56;
            NumericUpDown nudPoisoned3 = NudPoisoned;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num57 = num1;
            nudPoisoned3.Minimum = num57;
            NudPoisoned.Name = "nudPoisoned";
            NumericUpDown nudPoisoned4 = NudPoisoned;
            size1 = new Size(64, 20);
            Size size109 = size1;
            nudPoisoned4.Size = size109;
            NudPoisoned.TabIndex = 27;
            NudPoisoned.Tag = "27";
            NudPoisoned.TextAlign = HorizontalAlignment.Right;
            TextBox52.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox textBox521 = TextBox52;
            point1 = new Point(368, 712);
            Point point110 = point1;
            textBox521.Location = point110;
            TextBox52.Name = "TextBox52";
            TextBox52.ReadOnly = true;
            TextBox textBox522 = TextBox52;
            size1 = new Size(272, 20);
            Size size110 = size1;
            textBox522.Size = size110;
            TextBox52.TabIndex = 19;
            TextBox52.TabStop = false;
            TextBox52.Tag = "d27";
            TextBox52.Text = "";
            TextBox textBox531 = TextBox53;
            point1 = new Point(224, 712);
            Point point111 = point1;
            textBox531.Location = point111;
            TextBox53.Name = "TextBox53";
            TextBox53.ReadOnly = true;
            TextBox textBox532 = TextBox53;
            size1 = new Size(136, 20);
            Size size111 = size1;
            textBox532.Size = size111;
            TextBox53.TabIndex = 16;
            TextBox53.TabStop = false;
            TextBox53.Tag = "rr27";
            TextBox53.Text = "";
            TextBox53.TextAlign = HorizontalAlignment.Right;
            TextBox textBox541 = TextBox54;
            point1 = new Point(224, 688);
            Point point112 = point1;
            textBox541.Location = point112;
            TextBox54.Name = "TextBox54";
            TextBox54.ReadOnly = true;
            TextBox textBox542 = TextBox54;
            size1 = new Size(136, 20);
            Size size112 = size1;
            textBox542.Size = size112;
            TextBox54.TabIndex = 17;
            TextBox54.TabStop = false;
            TextBox54.Tag = "rr26";
            TextBox54.Text = "";
            TextBox54.TextAlign = HorizontalAlignment.Right;
            Label label1111 = Label111;
            point1 = new Point(16, 688);
            Point point113 = point1;
            label1111.Location = point113;
            Label111.Name = "label111";
            Label label1112 = Label111;
            size1 = new Size(80, 16);
            Size size113 = size1;
            label1112.Size = size113;
            Label111.TabIndex = 20;
            Label111.Text = "Rejoin Party";
            Label label281 = Label28;
            point1 = new Point(16, 664);
            Point point114 = point1;
            label281.Location = point114;
            Label28.Name = "Label28";
            Label label282 = Label28;
            size1 = new Size(112, 16);
            Size size114 = size1;
            label282.Size = size114;
            Label28.TabIndex = 21;
            Label28.Text = "Separate from Party";
            MainMenu1.MenuItems.AddRange(new MenuItem[2]
            {
                MenuItem1,
                MenuItem2
            });
            MenuItem1.Index = 0;
            MenuItem1.MenuItems.AddRange(new MenuItem[6]
            {
                MiNew,
                MiOpen,
                MiSave,
                MiSaveAs,
                MenuItem5,
                MiQuit
            });
            MenuItem1.Text = "&File";
            MiNew.Index = 0;
            MiNew.Shortcut = Shortcut.CtrlN;
            MiNew.Text = "&New";
            MiOpen.Index = 1;
            MiOpen.Shortcut = Shortcut.CtrlO;
            MiOpen.Text = "&Open...";
            MiSave.Enabled = false;
            MiSave.Index = 2;
            MiSave.Shortcut = Shortcut.CtrlS;
            MiSave.Text = "&Save";
            MiSaveAs.Enabled = false;
            MiSaveAs.Index = 3;
            MiSaveAs.Text = "Save &As...";
            MenuItem5.Index = 4;
            MenuItem5.Text = "-";
            MiQuit.Index = 5;
            MiQuit.Text = "E&xit";
            MenuItem2.Index = 1;
            MenuItem2.MenuItems.AddRange(new MenuItem[4]
            {
                MiUseK1DialogTlk,
                MiUseK2DialogTlk,
                MiUseExtDialogTlk,
                MiAskDialogTlk
            });
            MenuItem2.Text = "ConfigOptions";
            MiUseK1DialogTlk.Index = 0;
            MiUseK1DialogTlk.Text = "Use KotOR I Dialog.Tlk";
            MiUseK2DialogTlk.Index = 1;
            MiUseK2DialogTlk.Text = "Use KotOR II Dialog.Tlk";
            MiUseExtDialogTlk.Index = 2;
            MiUseExtDialogTlk.Text = "Use External Dialog.Tlk";
            MiAskDialogTlk.Checked = true;
            MiAskDialogTlk.Index = 3;
            MiAskDialogTlk.Text = "Ask which Dialog.Tlk for each file";
            StatusBar statusBar11 = StatusBar1;
            point1 = new Point(0, 363);
            Point point115 = point1;
            statusBar11.Location = point115;
            StatusBar1.Name = "StatusBar1";
            StatusBar statusBar12 = StatusBar1;
            size1 = new Size(688, 22);
            Size size115 = size1;
            statusBar12.Size = size115;
            StatusBar1.TabIndex = 7;
            StatusBar1.Text = "StatusBar1";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(688, 385);
            ClientSize = size1;
            Controls.Add(StatusBar1);
            Controls.Add(Panel1);
            Menu = MainMenu1;
            Name = "FrmSsfEditor";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "SSF Editor";
            NudBat1.EndInit();
            NudBat2.EndInit();
            NudBat3.EndInit();
            NudBat4.EndInit();
            Panel1.ResumeLayout(false);
            NudTryUnlock.EndInit();
            NudFailUnlock.EndInit();
            NudBat5.EndInit();
            NudBat6.EndInit();
            NudSel1.EndInit();
            NudSel3.EndInit();
            NudSel2.EndInit();
            NudAtk2.EndInit();
            NudAtk1.EndInit();
            NudAtk3.EndInit();
            NudHit2.EndInit();
            NudHit1.EndInit();
            NudDead.EndInit();
            NudLowHlth.EndInit();
            NudCrit.EndInit();
            NudTia.EndInit();
            NudLMin.EndInit();
            NudDMin.EndInit();
            NudStlh.EndInit();
            NudSrch.EndInit();
            NudSucceedUnlock.EndInit();
            NudLeaveParty.EndInit();
            NudRejoinParty.EndInit();
            NudPoisoned.EndInit();
            ResumeLayout(false);
        }

        private int KotorVersion()
        {
            FrmSpecifyKotorVersion specifyKotorVersion = new FrmSpecifyKotorVersion();
            specifyKotorVersion.btnCancel.Visible = false;
            if (specifyKotorVersion.ShowDialog(this) == DialogResult.OK) return specifyKotorVersion.KotorVerIndexSelected;
            return -1;
        }

        private void ParseSsf()
        {
            int num = 0;
            do
            {
                Control controlAndSetValue1 = FindControlAndSetValue(Convert.ToString(num), StringType.FromInteger(_ssf.GetRefArray(num)));
                FindControlAndSetValue("rr" + StringType.FromInteger(num), _ssf.GetRefArraySoundResRef(num));
                Control controlAndSetValue2 = FindControlAndSetValue("d" + StringType.FromInteger(num), _ssf.GetRefArrayString(num));
                ((NumericUpDown) controlAndSetValue1).ValueChanged += nud_ValueChanged;
                controlAndSetValue2.MouseEnter += tbDesc_MouseEnter;
                controlAndSetValue1.Enabled = true;
                checked
                {
                    ++num;
                }
            } while (num <= 27);
        }

        private void LoadDialogTlk(bool promptForVersion = true)
        {
            bool flag = false;
            string path = "";
            if (MiUseK1DialogTlk.Checked && (KotorVersionIndex == 1 || KotorVersionIndex == -1))
            {
                path = Path.Combine(ConfigOptions.Paths.KotorLocation(0), "dialog.tlk");
                KotorVersionIndex = 0;
                flag = true;
            }

            if (MiUseK2DialogTlk.Checked && (KotorVersionIndex == 0 || KotorVersionIndex == -1))
            {
                path = Path.Combine(ConfigOptions.Paths.KotorLocation(1), "dialog.tlk");
                KotorVersionIndex = 1;
                flag = true;
            }

            if (MiAskDialogTlk.Checked && promptForVersion)
            {
                int num = KotorVersion();
                if (num == -1) return;
                if (KotorVersionIndex != num)
                {
                    KotorVersionIndex = num;
                    path = Path.Combine(ConfigOptions.Paths.KotorLocation(KotorVersionIndex), "dialog.tlk");
                    flag = true;
                }
            }

            if (MiUseExtDialogTlk.Checked && (KotorVersionIndex > -1 || _gDialogtlk == null))
            {
                _gDialogtlk = null;
                GetExternalDialogTlk();
                KotorVersionIndex = -1;
            }
            else
            {
                if (!flag) return;
                _gDialogtlk = new ClsDialogTlk(path, true);
                StatusBar1.Text = "Dialog.Tlk: " + path + " (KotOR I";
                if (KotorVersionIndex == 0)
                {
                    StatusBar statusBar1 = StatusBar1;
                    statusBar1.Text = statusBar1.Text + ")";
                }
                else
                {
                    StatusBar statusBar1 = StatusBar1;
                    statusBar1.Text = statusBar1.Text + "I)";
                }
            }
        }

        private void GetExternalDialogTlk()
        {
            string startPath = "";
            if (MainFormState.IsOnly1KotOrInstalled())
            {
                if (MainFormState.HasKotor1()) startPath = ConfigOptions.Paths.KotorLocation(0);
                if (MainFormState.HasKotor2()) startPath = ConfigOptions.Paths.KotorLocation(1);
            }
            else startPath = ConfigOptions.Paths.DefaultImportLocation;

            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", startPath, "*.tlk", "Open Dialog.Tlk file...", "tlk"));
            if (objectValue.GetType() != typeof(string) || ObjectType.ObjTst(objectValue, "", false) == 0) return;
            string path = StringType.FromObject(objectValue);
            if (!path.ToLower().EndsWith(".tlk") && Interaction.MsgBox("The file you selected does not have a .TLK extension; do you want to open it?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Questionable file extension") == MsgBoxResult.No) return;
            _gDialogtlk = new ClsDialogTlk(path, true);
            StatusBar1.Text = "Dialog.Tlk: " + path + " (External)";
        }

        public void SetFormName(string name)
        {
            Text = "SSF Editor - " + name;
        }

        private Control FindControlAndSetValue(string tagStr, string value)
        {
            Control control1 = null;

            foreach (Control control2 in Panel1.Controls)
            {
                if (control2.Tag != null && StringType.StrCmp(control2.Tag.ToString(), tagStr, false) == 0)
                {
                    if (StringType.StrCmp(control2.GetType().Name, "NumericUpDown", false) == 0) ((NumericUpDown) control2).Value = new Decimal(Convert.ToDouble(value));
                    else control2.Text = value;
                    control1 = control2;
                    break;
                }
            }


            return control1;
        }

        public void EnableControls()
        {
            MiSave.Enabled = true;
            MiSaveAs.Enabled = true;
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            int kotorVerIndex = KotorVersion();
            if (kotorVerIndex <= -1) return;
            _ssf = new ClsSsf(kotorVerIndex);
            int num = 0;
            do
            {
                _ssf.SetRefArray(num, -1);
                ++num;
                
            } while (num <= 39);

            ParseSsf();
            EnableControls();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("load", ConfigOptions.Paths.DefaultSaveLocation, "", "Load SSF file...", "ssf"));
            if (StringType.StrCmp(str, "", false) == 0) return;
            LoadDialogTlk();
            if (_gDialogtlk != null)
            {
                _ssf = new ClsSsf(new FileStream(str, FileMode.Open), _gDialogtlk);
                ParseSsf();
                SetFormName(str);
                EnableControls();
            }
            else
            {
                Interaction.MsgBox("Dialog.Tlk not loaded; opening of file aborted!", MsgBoxStyle.Exclamation);
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (StringType.StrCmp(_gFilepath, "", false) != 0) _ssf.WriteFile(_gFilepath);
            else miSaveAs_Click(RuntimeHelpers.GetObjectValue(sender), e);
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, "", "Save SSF file as...", "ssf"));
            if (StringType.StrCmp(str, "", false) == 0) return;
            _ssf.WriteFile(str);
            _gFilepath = str;
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UseDialogTlk_Click(object sender, EventArgs e)
        {
            MiUseK1DialogTlk.Checked = false;
            MiUseK2DialogTlk.Checked = false;
            MiUseExtDialogTlk.Checked = false;
            MiAskDialogTlk.Checked = false;
            ((MenuItem) sender).Checked = true;
            LoadDialogTlk(false);
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, null, "tag", new object[0], null, null)));
            _ssf.SetRefArray(int32, IntegerType.FromObject(LateBinding.LateGet(sender, null, "Value", new object[0], null, null)));
            FindControlAndSetValue("rr" + StringType.FromInteger(int32), _ssf.GetRefArraySoundResRef(int32));
            FindControlAndSetValue("d" + StringType.FromInteger(int32), _ssf.GetRefArrayString(int32));
        }

        private void OnLoad(object sender, EventArgs e)
        {
            MiUseK1DialogTlk.Visible = MainFormState.HasKotor1();
            MiUseK2DialogTlk.Visible = MainFormState.HasKotor2();
        }

        private void tbDesc_MouseEnter(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip((Control) sender, ((TextBox) sender).Text);
        }
    }
}