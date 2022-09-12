using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Version : Form {
        public Version() {
            InitializeComponent();
        }

        private void Version_Load(object sender, EventArgs e) {
            var asm = Assembly.GetExecutingAssembly();
            var ver = asm.GetName().Version;
            string version = ver.Major + "." + ver.Minor + "." + ver.Build + "." + ver.Revision;
            lbVersion.Text = version;
        }
    }
}
