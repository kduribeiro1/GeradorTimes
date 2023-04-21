using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorTimes
{
    partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
            this.Text = String.Format("{0} | Sobre", Program.AssemblyTitle);
            this.labelProductName.Text = Program.AssemblyProduct;
            this.labelVersion.Text = String.Format("Versão {0}", Program.AssemblyVersion);
            this.labelCopyright.Text = Program.AssemblyCopyright;
            this.labelCompanyName.Text = Program.AssemblyCompany;
            this.textBoxDescription.Text = Program.AssemblyDescription;
        }

    }
}
