using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AselsanSegmentGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string segments = "ABCDEFGHIJKLMNOPQ";
            string acikSegmentler = String.Concat(txtAcikSegmentler.Text.OrderBy(c => c)).ToUpper();
            foreach (var segment in acikSegmentler)
            {
                segments = segments.Replace(segment, '1');
            }
            segments = Regex.Replace(segments, "[^0-9]", "0");
            txtSegmentResult.Text = segments;
        }
    }
}
