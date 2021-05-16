using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_4
{
    public partial class Form1 : Form
    {
        private LFSR LFSR;
        public Form1 form;


        public Form1()
        {
            InitializeComponent();
            form = this;
            LFSR = new LFSR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.LFSR.register = Convert.ToUInt32(form.textBox1.Text);
            OpenFileDialog Select = new OpenFileDialog();
            Select.ShowDialog();
            var src = Select.FileName;
            Select.ShowDialog();
            var dest = Select.FileName;
            form.LFSR.Crypt(src, dest);
            MessageBox.Show("Шифрация прошла успешно");


        }
    }
}
