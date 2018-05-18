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
using Task3_BL;

namespace Task3_Form
{
    public partial class Form3 : Form
    {
        InOut3 io = new InOut3();
        public Form3()
        {
            InitializeComponent();
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            if (inputSerializeFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputSerializeFileDialog.FileName);
                    io.students = io.ReadFromFile(inputSerializeFileDialog.FileName);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
            StudentsBox.Text = io.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            inputOpenFileDialog.InitialDirectory = IOUtils.ExeDir;
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            io.Text = io.BelowTheAverageGroups(io.students);
            GroupsBox.Text = io.Text;
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputOpenFileDialog.FileName);
                    io.WriteForSerialization(inputOpenFileDialog.FileName);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }
    }
}
