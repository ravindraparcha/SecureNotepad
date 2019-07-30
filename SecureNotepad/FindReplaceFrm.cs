using SecureNotePad.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureNotepad
{
    public partial class FindReplaceFrm : Form
    {
        public string operationText = string.Empty;
        public ActionEnum actionEnum;
        private string _actionName = string.Empty;
        public FindReplaceFrm(string actionName)
        {
            InitializeComponent();
            actionBtn.Text = actionName;
            _actionName = actionName;
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            operationText = actionTxt.Text;
            if(_actionName == ActionEnum.Search.ToString())
            {
                actionEnum = ActionEnum.Search;
            }
            this.Close();
        }

        private void ReplaceAllBtn_Click(object sender, EventArgs e)
        {
            operationText = actionTxt.Text;
            if (_actionName == ActionEnum.Search.ToString())
            {
                actionEnum = ActionEnum.ReplaceAll;
            }
           
        }
    }
}
