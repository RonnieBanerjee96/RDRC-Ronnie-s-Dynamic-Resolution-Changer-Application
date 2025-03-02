using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
        bool isProcessFound = false;
        Form2 WaitingWindow = new Form2();


        IntPtr path;
        IntPtr name;
        

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
        public static extern bool checkProcessRunningStatus(int selectedWidth, int selectedHeight, float selectedFreq, int prevWidth, int prevHeight, float startFreq, IntPtr name, IntPtr path);
        
        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern float getScreenRefresh();

        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool getIsProcessFound();
        [DllImport("reschange.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool findProcess(IntPtr name);


        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Array.Clear(freqs, 0, freqs.Length);
            Array.Clear(heights, 0, heights.Length);
            Array.Clear(widths, 0, widths.Length);
            listView1.Items.Clear();
            isSuccesfull = getMonitorInfo(widths, heights, freqs);
            foreach (var (value, index) in widths.Select((value, index) => (value, index)))
            {
                ListViewItem LI = new ListViewItem();
                LI.Text = widths[index].ToString();
                LI.SubItems.Add(heights[index].ToString());
                LI.SubItems.Add(freqs[index].ToString());
                listView1.Items.Add(LI);

            }
         

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
                this.name = Marshal.StringToHGlobalUni(Path.GetFileName(openFileDialog1.FileName));
                label_file.Text = openFileDialog1.SafeFileName;
            }
        }

        private void button_launch_Click(object sender, EventArgs e)
        {
            bool isProcessStartSuccessFull = startProcess(path);
            if (isProcessStartSuccessFull && (selectedResolution[0] != 0 && selectedResolution[1] != 0))
            {
                WaitingWindow.StartPosition = FormStartPosition.CenterParent;
                
                WaitingWindow.Show();
                findProcess(name);
                Timer_isProcessFound.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.screenWidth = getScreenWidth();
            this.ScreenHeight = getScreenHeight();
            this.startFreq = getScreenRefresh();
            label2.Text = getScreenHeight().ToString();
            label1.Text = getScreenWidth().ToString();
            label_startfreq_number.Text = getScreenRefresh().ToString();
        }

        private void Timer_isProcessFound_Tick(object sender, EventArgs e)
        {
            isProcessFound = getIsProcessFound();
            if (isProcessFound)
            {
                WaitingWindow.Hide();
                checkProcessRunningStatus(selectedResolution[0], selectedResolution[1], selectedFreq, screenWidth, ScreenHeight, startFreq, name, path);
                Timer_isProcessFound.Stop();
            }

        }
    }
}
