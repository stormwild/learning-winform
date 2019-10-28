using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDICSharp
{
    public partial class DocForm : Form
    {
        private static int _counter = 0;

        public DocForm()
        {
            InitializeComponent();
        }

        public static DocForm CreateForm()
        {
            var form = new DocForm
            {
                Text = "New Document " + ++_counter
            };
            SdiApplication.Instance.ApplicationContext.MainForm = form;
            form.Show();
            return form;
        }

        private void WindowToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (WindowToolStripMenuItem.DropDownItems.Count > 0)
            {
                WindowToolStripMenuItem.DropDown.Dispose();
            }

            WindowToolStripMenuItem.DropDown = new ToolStripDropDown();
            foreach (Form openForm in SdiApplication.Instance.OpenForms)
            {
                var childItem = new ToolStripMenuItem
                {
                    Text = openForm.Text,
                    Tag = openForm
                };
                WindowToolStripMenuItem.DropDownItems.Add(childItem);
                childItem.Click += OnWindowMenuItemClick;
            }
        }

        private void OnWindowMenuItemClick(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var form = menuItem.Tag as Form;
            form.Activate();
        }
    }
}
