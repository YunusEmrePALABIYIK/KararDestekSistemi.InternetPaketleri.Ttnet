﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Hizonemlimidir Hizonemlimidirsec = new Hizonemlimidir ();
                Hizonemlimidirsec.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dakikaonemlimidir Dakikaonemlimidirsec = new Dakikaonemlimidir();
            Dakikaonemlimidirsec.Show();
        }
    }
}
