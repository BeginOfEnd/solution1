using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task4_BL;

namespace Task4
{
    public partial class Form4 : Form
    {
        InOut4 io = new InOut4();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            inputOpenFileDialog.InitialDirectory = Task2_BL.IOUtils.ExeDir;
            inputSaveFileDialog.InitialDirectory = Task2_BL.IOUtils.ExeDir;
            outputSaveFileDialog.InitialDirectory = Task2_BL.IOUtils.ExeDir;
        }

        private void TurnsButton_Click(object sender, EventArgs e)
        {
            io.Cells = null;
            NTurns.Text = io.Cells;
            io.ReadFromBox(StartPositionText.Text);
            int vertical = Convert.ToInt32(VerticalMoveText.Text);
            int horizontal = Convert.ToInt32(HorizontalMoveText.Text);            
            int n = Convert.ToInt32(TurnsText.Text);
            io.Cells = io.Turns(horizontal, vertical, n);
            NTurns.Text = io.Cells;
        }
    }
}
