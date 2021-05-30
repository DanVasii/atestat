using System;
using System.Collections.Generic;
using System.Text;

namespace atestat
{
    public class Context
    {
        public int logged_id = -1;

        public void set_logged(int id)
        {
            logged_id = id;
        }

        public void show()
        {
            System.Diagnostics.Debug.WriteLine(logged_id);

        }

    }
}
