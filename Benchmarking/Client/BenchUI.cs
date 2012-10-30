using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;
using SchedulingBenchmarking;

namespace Client
{
    public partial class BenchUI : Form
    {
        public BenchUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                label2.Text ="Requesting status";
                int status = client.RequestStatus();
                label2.Text = ""+status+ " Cores available";
               
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            using (Service1Client client = new Service1Client())
            {
                if (nameBox.Text.Length == 0) label7.Text = "Error";
                bool status = client.ReceiveJob(int.Parse(CpuBox.Text), int.Parse(RuntimeBox.Text), nameBox.Text);
                if (status) label7.Text = "Succes";
                reFresh();
            }
        }

        private void reFresh()
        {
            listBox1.Items.Clear(); 
            using (Service1Client client = new Service1Client())
            {
                listBox1.Items.AddRange(client.GetJobsList(nameBox.Text));
                listBox1.Refresh();
            }
             
        }

        public static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BenchUI());
        }

      
    }
}
