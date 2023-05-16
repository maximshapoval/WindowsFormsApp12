using System;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    using System;
    using System.Windows.Forms;

    
        public partial class Form1 : Form
        {
            private Timer timer;
            private int secondsPassed = 0;

            public Form1()
            {
                InitializeComponent();

                timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(Timer_Tick);
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                secondsPassed++;
                string message = "Прошло " + secondsPassed + " сек";
                listBox1.Items.Add(message);
            }
        }
}
