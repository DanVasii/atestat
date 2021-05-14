using System;
using System.Windows.Forms;

namespace atestat
{
	public class Class1 : Button
	{
		public Class1()
		{
			this.Text = "Dan e tare";
		}
		public String test
        {
			get;
			set;
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
			Console.WriteLine(this.test);
        }
    }

}
