using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET_WinForm_HW1.ButtonForms
{
    public partial class AddType : Form
    {
        private string getTable = "SELECT Id, TypeName, Quantity FROM [Types];";

        public AddType()
        {
            InitializeComponent();
        }

        private void addType_Load(object sender, EventArgs e)
        {
            labelState.Text = Main.State;
            dataGridView1.DataSource = Query.Show(getTable);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].ReadOnly = true;
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO [Types] (TypeName)
                              VALUES ('{textBox1.Text}');";
            SqlCommand command = new SqlCommand(query, Main.connection);
            command.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string queryUpdate = $@"UPDATE [Types]
                                    SET [Types].{dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name} = '{dataGridView1.CurrentCell.Value}'
                                    WHERE [Types].Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandUpdate = new SqlCommand(queryUpdate, Main.connection);
            commandUpdate.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string queryDeleteMovement = $@"DELETE Movement FROM Movement JOIN Stationery ON Movement.StationeryId=Stationery.Id
                                            WHERE Stationery.TypeId = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDeleteMovement = new SqlCommand(queryDeleteMovement, Main.connection);
            commandDeleteMovement.ExecuteNonQuery();

            string queryDeleteStationery = $@"DELETE FROM Stationery WHERE Stationery.TypeId = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDeleteStationery = new SqlCommand(queryDeleteStationery, Main.connection);
            commandDeleteStationery.ExecuteNonQuery();

            string queryDelete = $@"DELETE FROM Types WHERE Types.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDelete = new SqlCommand(queryDelete, Main.connection);
            commandDelete.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }
    }
}
