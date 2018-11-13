using System;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
    public class ClsProjectManager
    {
        private string _mProjectFilePath;
        private ClsProject _mProject;

        public ClsProject Project
        {
            get => _mProject;
            set => _mProject = value;
        }

        public string ProjectFilePath
        {
            get => _mProjectFilePath;
            set => _mProjectFilePath = value;
        }

        public int ProjectKotorVersionIndex
        {
            get => _mProject.KotorVersionIndex;
            set => _mProject.KotorVersionIndex = value;
        }

        public ClsProjectManager(string projectFilePath)
        {
            _mProjectFilePath = projectFilePath;
            if (File.Exists(projectFilePath))
                _mProject = LoadProject();
            if (_mProject != null)
                return;
            int num = (int) Interaction.MsgBox("Couldn't load project file", MsgBoxStyle.Critical, "clsProjectManager");
        }

        public ClsProjectManager(string projectFilePath, string newProjectName)
        {
            _mProjectFilePath = projectFilePath;
            _mProject = new ClsProject();
            _mProject.Name = newProjectName;
        }

        public ArrayList GetProjectOverrideFiles()
        {
            return _mProject.OverrideFiles;
        }

        public int GetProjectModuleCount()
        {
            return _mProject.Modules.Count;
        }

        public ArrayList GetProjectModuleFiles(int fileNum)
        {
            return (ArrayList) _mProject.Modules[fileNum];
        }

        public ClsProject LoadProject()
        {
            return LoadProject(_mProjectFilePath);
        }

        public ClsProject LoadProject(string projectPath)
        {
            ClsProject clsProject;
            try
            {
                if (File.Exists(projectPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClsProject));
                    FileStream fileStream = new FileStream(projectPath, FileMode.Open, FileAccess.Read);
                    _mProject = (ClsProject) xmlSerializer.Deserialize(fileStream);
                    fileStream.Close();
                }

                clsProject = _mProject;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "");
                clsProject = null;
                ProjectData.ClearProjectError();
            }

            return clsProject;
        }

        public void SaveProject()
        {
            SaveProject(_mProjectFilePath, _mProject);
        }

        public void SaveProject(string projectFilePath, ClsProject project)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClsProject));
                FileStream fileStream = new FileStream(projectFilePath, FileMode.Create, FileAccess.ReadWrite);
                xmlSerializer.Serialize(fileStream, project);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString());
                ProjectData.ClearProjectError();
            }
        }
    }
}