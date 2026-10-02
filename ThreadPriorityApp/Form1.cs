using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadPriorityApp
{
    public partial class frmTrackThread : Form
    {

        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            lblThreadStatus.Text = "-Thread Starts-";

            // Initialize threads
            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1)) { Name = "Thread A" };
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2)) { Name = "Thread B" };
            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread1)) { Name = "Thread C" };
            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2)) { Name = "Thread D" };

            // Assign priorities specified in the table
            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            // Start threads
            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            // Block form thread until sub-threads finish
            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
            lblThreadStatus.Text = "-End of Thread-";
        }
    }
}