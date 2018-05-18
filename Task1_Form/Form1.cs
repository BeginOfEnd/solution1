using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Task1_BL;

namespace Task1_Form
{
    public partial class Form1 : Form
    {
        InOut1 solution = new InOut1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputOpenFileDialog.InitialDirectory = IOUtils.ExeDir;
            inputSaveFileDialog.InitialDirectory = IOUtils.ExeDir;
            outputSaveFileDialog.InitialDirectory = IOUtils.ExeDir;
        }

        private void InputButon_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputOpenFileDialog.FileName);
                    InputText.Lines = File.ReadAllLines(inputOpenFileDialog.FileName);
                }
                catch (Exception except)
                {
                    Utils.FormsUtils.ErrorMessageBox(except);
                }
        }

        private void SaveInput_Click(object sender, EventArgs e)
        {
            if (inputSaveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputSaveFileDialog.InitialDirectory = Path.GetDirectoryName(inputSaveFileDialog.FileName);
                    string lines = InputText.Text;
                    File.WriteAllText(inputSaveFileDialog.FileName, lines);
                }
                catch (Exception except)
                {
                    Utils.FormsUtils.ErrorMessageBox(except);
                }
        }

        private void InputText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            string text = InputText.Text;
            OutputText.Text = MyFunctions.DeleteNParagraph(text, Convert.ToUInt32(Number.Text));
        }
    }
}
