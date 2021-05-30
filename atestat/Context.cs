using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace atestat
{
    public class Context
    {
        public Panel parent;

        public int logged_id = -1;

        public void set_logged(int id)
        {
            logged_id = id;
        }

        public void show()
        {
            System.Diagnostics.Debug.WriteLine(logged_id);

        }

        public int get()
        {
            return logged_id;
        }

        public void set(Panel p)
        {
            parent = p;
        }

        public Panel get_p()
        {
            return parent;
        }

    }
}
