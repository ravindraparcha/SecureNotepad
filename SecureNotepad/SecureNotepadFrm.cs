using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureNotePad.Core;

namespace SecureNotepad
{
    public partial class SecureNotepadFrm : Form
    {
        #region Variables        
        private ReadWriteOperation _readWriteOperation;
        private string _currentFilePath = string.Empty;
        #endregion
        public SecureNotepadFrm()
        {
            InitializeComponent();
            this.Text = string.Concat(Constants.appName, " - ", Constants.author);
            _readWriteOperation = new ReadWriteOperation();
        }

        private void WordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notepadTxtBox.SelectAll();
            this.notepadTxtBox.Focus();
        }

        
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadTxtBox.Text = string.Empty;
            this._currentFilePath = string.Empty;

        }
        private void setOpenDialogConfiguration(OpenFileDialog openFileDialog)
        {
            openFileDialog.Title = Constants.browseFile;
            openFileDialog.DefaultExt = Constants.defaultExtension;
            openFileDialog.Filter = Constants.filter;
            openFileDlg.FileName = "";            
        }
        private void setSaveFileDialogConfiguration(SaveFileDialog saveFileDialog)
        {
            saveFileDialog.Filter = Constants.filter;
            saveFileDialog.Title = Constants.saveFile;         
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setOpenDialogConfiguration(openFileDlg);
            DialogResult dialogResult = openFileDlg.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                _currentFilePath = openFileDlg.FileName;                
                try
                {
                    notepadTxtBox.Text =_readWriteOperation.ReadFile(openFileDlg.FileName);
                    notepadTxtBox.Select(notepadTxtBox.Text.Length - 1, 0);
                    notepadTxtBox.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    showMessageBox("Following error occurred\n" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSaveFileDialogConfiguration(saveFileDlg);
            saveFileDlg.ShowDialog();
            if (saveFileDlg.FileName != "")
            {
                _currentFilePath = saveFileDlg.FileName;
                try
                {
                    _readWriteOperation.WriteFile(_currentFilePath, notepadTxtBox.Text);
                }
                catch (Exception ex)
                {
                    showMessageBox(string.Concat("Following error occurred","\n" , ex.Message), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        private void showMessageBox(string msg, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(msg, Constants.appName, buttons, icon);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(notepadTxtBox.Text.Trim()))
                {
                    showMessageBox(Constants.noDataToSave, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(_currentFilePath))
                {
                    SaveAsToolStripMenuItem_Click(sender, e);
                    return;
                }
                _readWriteOperation.WriteFile(_currentFilePath, notepadTxtBox.Text);
            }
            catch (Exception ex)
            {
                showMessageBox(string.Concat("Following error occurred", "\n", ex.Message), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
