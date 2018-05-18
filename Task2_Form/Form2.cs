using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Task2_BL;

namespace Task2_Form
{
    public partial class Form2 : Form
    {
        InOut2 io = new InOut2();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InDGV, 30, false, true, true, true, true);
            DataGridViewUtils.InitGridForArr(OutDGV, 30, true, true, true, true, true);
            inputOpenFileDialog.InitialDirectory = Task2_BL.IOUtils.ExeDir;
            inputSaveFileDialog.InitialDirectory = Task2_BL.IOUtils.ExeDir;
            outputSaveFileDialog.InitialDirectory = Task2_BL.IOUtils.ExeDir;
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            if (outputSaveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    outputSaveFileDialog.InitialDirectory = Path.GetDirectoryName(outputSaveFileDialog.FileName);
                    int size = Convert.ToInt32(SizeBox.Text);
                    io.WriteToFile(outputSaveFileDialog.FileName, size);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    io.Text = io.ReadFromFile(inputOpenFileDialog.FileName);
                    DataGridViewUtils.ArrayToGrid(InDGV, io.Text);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            int[] arr = DataGridViewUtils.GridToArray<int>(InDGV);
            int[] sorted = io.CompressSort(arr);
            DataGridViewUtils.ArrayToGrid(OutDGV, sorted);
        }
    }
}
