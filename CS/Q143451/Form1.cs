using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Q143451 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            myPivotGridControl1.BestFit();
            myPivotGridControl2.BestFit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

        }
    }
}