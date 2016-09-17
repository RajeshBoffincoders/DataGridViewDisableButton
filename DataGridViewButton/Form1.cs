using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            dataGridView1.ColumnCount = 3;

            dataGridView1.Columns[0].Name = "Product ID";

            dataGridView1.Columns[1].Name = "Product Name";

            dataGridView1.Columns[2].Name = "Product Price";



            string[] row = new string[] { "1", "Product 1", "1000" };

            dataGridView1.Rows.Add(row);

            row = new string[] { "2", "Product 2", "2000" };

            dataGridView1.Rows.Add(row);

            row = new string[] { "3", "Product 3", "3000" };

            dataGridView1.Rows.Add(row);

            row = new string[] { "4", "Product 4", "4000" };

            dataGridView1.Rows.Add(row);



            DataGridViewDisableButtonColumn btn = new DataGridViewDisableButtonColumn();

            dataGridView1.Columns.Add(btn);

            btn.HeaderText = "Click Data";

            btn.Text = "Click Here";

            btn.Name = "btn";

            btn.UseColumnTextForButtonValue = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                DataGridViewDisableButtonCell btn = (DataGridViewDisableButtonCell) dataGridView1.Rows[i].Cells[3];
                //Put your value check here
                //if (btn.Value.ToString() == "ABC")
                btn.Enabled = false;
            }
        }
    }
}
