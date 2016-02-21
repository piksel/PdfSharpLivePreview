using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfSharpLivePreview
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start((sender as LinkLabel).Text);
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            var _v = Assembly.GetExecutingAssembly().GetName().Version;
            lVersion.Text = $"Version {_v.Major}.{_v.Minor}.{_v.Revision} build {_v.Build}";
        }
    }
}
