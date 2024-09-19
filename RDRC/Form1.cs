using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//WORK IN PROGRESS
//USE AS IS AT YOUR OWN RISK
//COPYRIGHT: RONNIE BANERJEE

namespace RDRC
{
    public partial class Form1 : Form
    {
        bool isSuccesfull;
        int screenWidth;
        int ScreenHeight;
        int[] selectedResolution = new int[2];
        float startFreq;
        float selectedFreq;
        int[] heights = new int[60];
        int[] widths = new int[60];
        float[] freqs = new float[60];
        private bool processRunSucess;
        private bool isProcessRunning;
        IntPtr path;

        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool changeScreenResolution(int width, int height, float freq);
        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int getScreenHeight();
        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int getScreenWidth();
        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool getMonitorInfo(int[] width, int[] height, float[] freqs);

        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool startProcess(IntPtr path);

        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool LaunchWithResolution(int selectedWidth, int selectedHeight, float selectedFreq, int prevWidth, int prevHeight, float startFreq);
        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern float getScreenRefresh();

        public Form1()
        {
            InitializeComponent();
            this.screenWidth = getScreenWidth();
            this.ScreenHeight = getScreenHeight();
            this.startFreq = getScreenRefresh();
            label2.Text = getScreenHeight().ToString();
            label1.Text = getScreenWidth().ToString();
            label_startfreq_number.Text = getScreenRefresh().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            isSuccesfull = getMonitorInfo(widths, heights, freqs);
            listView1.Items.Clear();
            foreach (var (value, index) in widths.Select((value, index) => (value, index)))
            {
                ListViewItem LI = new ListViewItem();
                LI.Text = widths[index].ToString();
                LI.SubItems.Add(heights[index].ToString());
                LI.SubItems.Add(freqs[index].ToString());
                listView1.Items.Add(LI);

            }
            //Console.WriteLine(isSuccesfull);
            //Console.ReadKey();

            //isSuccesfull = changeScreenResolution(1280, 720);
            //Console.WriteLine(isSuccesfull);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (selectedResolution[0] != 0 && selectedResolution[1] != 0 && startFreq != 0)
            {
                isSuccesfull = changeScreenResolution(selectedResolution[0], selectedResolution[1], selectedFreq);
            }

            label2.Text = getScreenHeight().ToString();
            label1.Text = getScreenWidth().ToString();
            label_startfreq_number.Text = getScreenRefresh().ToString();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                selectedResolution[0] = Convert.ToInt32(item.SubItems[0].Text);
                selectedResolution[1] = Convert.ToInt32(item.SubItems[1].Text);
                selectedFreq = (float)Convert.ToDecimal(item.SubItems[2].Text);
                label_sw.Text = selectedResolution[0].ToString();
                label_sh.Text = selectedResolution[1].ToString();
                label_selectedfreq_number.Text = selectedFreq.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File";
            openFileDialog1.Filter = "Exe Files (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                this.path = Marshal.StringToHGlobalUni(openFileDialog1.FileName);
                label_file.Text = openFileDialog1.SafeFileName;
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {

            processRunSucess = startProcess(path);
            if (processRunSucess && selectedResolution[0] != 0 && selectedResolution[1] != 0)
            {
                isProcessRunning = LaunchWithResolution(selectedResolution[0], selectedResolution[1], selectedFreq, screenWidth, ScreenHeight, startFreq);
                if (isProcessRunning)
                {
                    label5.Text = isProcessRunning.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
