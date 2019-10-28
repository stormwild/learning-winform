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
    }
}
