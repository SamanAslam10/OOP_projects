using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._3._0
{
    internal class FormHelper
    {
        public static Panel MasterPanel;

        public static void PopulateScreen(Form form) 
        {
            if (MasterPanel != null) 
            {
                MasterPanel.Controls.Clear();
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            MasterPanel.Controls.Add(form);
            form.Show();
        }
    }
}
