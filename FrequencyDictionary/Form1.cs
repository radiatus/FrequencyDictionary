using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequencyDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Logic.LoadFile(openFileDialog.FileName);
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Logic.stringToList();
            Logic.listSortic();

            Logic.getWords.PrinterDgr(dataGridView);
        }
    }
}
