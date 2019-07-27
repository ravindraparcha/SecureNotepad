using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureNotePad.Core;

namespace SecureNotepad
{
    public partial class SecureNotepadFrm : Form
    {
        public SecureNotepadFrm()
        {
            InitializeComponent();
            this.Text = Constants.appTitle;
        }

        private void WordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
