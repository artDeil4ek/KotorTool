using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Forms;

using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.TextEditor;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Utils
{
    public static class Utils
    {
        public static Control FindControl(Control parentCtrl, string ctrlName)
        {
            foreach (Control control1 in parentCtrl.Controls)
            {
                if (StringType.StrCmp(control1.Name, ctrlName, false) == 0) return control1;
                if (control1.Controls.Count > 0)
                {
                    Control control2 = FindControl(control1, ctrlName);
                    if (control2 != null) return control2;
                }
            }

            return null;
        }

        public static void EditScriptForTextBox(Button editButton, string editingFilePath, int kotorVersionIndex)
        {
            string ctrlName = editButton.Name.Replace("btnEdit", "tb");
            TextBox control = (TextBox) FindControl(editButton.Parent, ctrlName);
            Hashtable bifFileHash = ChitinKey.KxChitinKey(kotorVersionIndex).GetBifFileHash("scripts");
            string str1 = control.Text.Trim();
            if (StringType.StrCmp(str1, "", false) == 0) return;
            string str2 = Path.Combine(Path.GetDirectoryName(editingFilePath) ?? throw new InvalidOperationException(), str1 + ".nss");
            frmTextEditor frmTextEditor = null;
            if (File.Exists(str2))
                frmTextEditor = new frmTextEditor(str2, kotorVersionIndex, true);
            else if (bifFileHash.ContainsKey(str1 + ".nss"))
            {
                frmTextEditor = new frmTextEditor();
                ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                frmTextEditor.tbGeneric.Text = asciiEncoding.GetString(BiffFunctions.GetBiffResourceData(kotorVersionIndex, str1, ResourceIdentification.GetIdForRsrcType("nss")));
                frmTextEditor.tbGeneric.SelectionLength = 0;
                frmTextEditor.KotorVersionIndex = kotorVersionIndex;
                frmTextEditor.EditingFilePath = str2;
                frmTextEditor.DirectEdit = true;
                Interaction.MsgBox("The file " + str1 + ".nss already exists as a standard game resource." + "\n" + "If you save it, this module will use your modified version instead of the global one.", MsgBoxStyle.Information, "Notice");
            }
            else
            {
                Interaction.MsgBox("The file " + str1 + ".nss does not exist in the same directory as this file nor as a standard game resource.", MsgBoxStyle.Critical, "File not found");
            }

            if (frmTextEditor == null) return;
            frmTextEditor.Filename = str1 + ".nss";
            frmTextEditor.ShowDialog(editButton.TopLevelControl);
            control.Text = Path.GetFileNameWithoutExtension(frmTextEditor.Filename);
        }
    }
}