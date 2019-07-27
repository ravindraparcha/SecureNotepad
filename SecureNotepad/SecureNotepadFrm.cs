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
        private string _fileToOpen = string.Empty;
        #endregion
        public SecureNotepadFrm()
        {
            InitializeComponent();
            this.Text = Constants.appTitle;
        }

        private void WordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notepadTxtBox.SelectAll();
            this.notepadTxtBox.Focus();
        }

        private void OpenFileDlg_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
        private void setOpenDialogConfiguration(OpenFileDialog openFileDialog)
        {
            openFileDialog.Title = Constants.browseFiles;
            openFileDialog.DefaultExt = Constants.defaultExtension;
            openFileDialog.Filter = Constants.openDlgFilter;
            openFileDlg.FileName = "";
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setOpenDialogConfiguration(openFileDlg);
            DialogResult dialogResult = openFileDlg.ShowDialog();
            if (dialogResult.Equals(DialogResult.OK))
            {
                _fileToOpen = openFileDlg.FileName;
                try
                {
                    var sr = new StreamReader(openFileDlg.FileName);
                    notepadTxtBox.Text = sr.ReadToEnd();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
