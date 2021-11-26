using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_WinForm_HW1.TaskForms
{
    public partial class PwForm : Form
    {
        public PwForm()
        {
            InitializeComponent();
        }

        private void PwForm_Load(object sender, EventArgs e)
        {
            labelState.Text = Main.State;
        }

        private void task3Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Stationery;");
        }

        private void task3Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Types;");
        }

        private void task3Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Manager;");
        }

        private void task3Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Stationery WHERE Stationery.Quantity = (SELECT MAX(Quantity) FROM Stationery);");
        }

        private void task3Button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Stationery WHERE Stationery.Quantity = (SELECT MIN(Quantity) FROM Stationery);");
        }

        private void task3Button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Stationery WHERE Stationery.StockPrice = (SELECT MIN(StockPrice) FROM Stationery);");
        }

        private void task3Button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Stationery WHERE Stationery.StockPrice = (SELECT MAX(StockPrice) FROM Stationery);");
        }

        private void task4Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Stationery JOIN Types ON Types.Id=Stationery.TypeId
                                                     WHERE Types.TypeName='Knives'");
        }

        private void task4Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Movement JOIN Manager ON Manager.Id=Movement.ManagerId
                                                     WHERE Manager.ManagerName='David' AND Manager.ManagerLastname='Vice'");
        }

        private void task4Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT * FROM Movement JOIN Buyer ON Buyer.Id=Movement.BuyerId
                                                     WHERE Buyer.CompanyName='Lukoil'");
        }

        private void task4Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT 'None' as 'Skipped';");
        }

        private void task4Button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT Types.TypeName, AVG(Stationery.Quantity) 
                                                     FROM Types 
                                                     JOIN Stationery ON Stationery.TypeId=Types.Id
                                                     GROUP BY Types.TypeName;");
        }
    }
}
