using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNotePad.Core
{
    public sealed class Constants
    {
        public const string appName = "Secure Notepad";
        public const string author = "Ravindra Parcha";
        public const string browseFile = "Browse File";
        public const string filter = "Secure txt files(*.stxt)| *.txt | All files(*.*) | *.*";
        public const string defaultExtension = "stxt";
        public const string saveFile = "Save File";
        
        // Messages
        public const string noDataToSave = "You have no data to save.";

        //Action
        public const string search = "Search";
        public const string replace = "Replace";
    }
}
