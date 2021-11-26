using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using ADO.NET_WinForm_HW1.ButtonForms;
using ADO.NET_WinForm_HW1.TaskForms;

namespace ADO.NET_WinForm_HW1
{
    public partial class Main : Form
    {
        public static string State { get; set; } = "State: Disconnected";
        public static string ConStr { get; set; }
        public static SqlConnection connection { get; set; }
        public Main()
        {
            ConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StationeryDB;Integrated Security = true;";
            connection = new SqlConnection(ConStr);
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connection.Open();
            labelState.Text = "State: " + connection.State.ToString();
            State = labelState.Text;
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            connection.Close();
            labelState.Text = "State: " + connection.State.ToString();
            State = labelState.Text;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            dataGV.DataSource = Query.Show(textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void addType_Click(object sender, EventArgs e)
        {
            AddType addType = new AddType();
            addType.ShowDialog();
        }

        private void addStationery_Click(object sender, EventArgs e)
        {
            AddStationery addStationery = new AddStationery();
            addStationery.ShowDialog();
        }

        private void addManager_Click(object sender, EventArgs e)
        {
            AddManager addManager = new AddManager();
            addManager.ShowDialog();
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            AddCompany addCompany = new AddCompany();
            addCompany.ShowDialog();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            MakeSell makeSell = new MakeSell();
            makeSell.ShowDialog();
        }

        private void hwButton_Click(object sender, EventArgs e)
        {
            HwForm hwForm = new HwForm();
            hwForm.ShowDialog();
        }

        private void pwButton_Click(object sender, EventArgs e)
        {
            PwForm pwForm = new PwForm();
            pwForm.ShowDialog();
        }
    }
}
