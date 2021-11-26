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
    public partial class AddStationery : Form
    {
        private string getTable = "SELECT Stationery.Id, TypeName, StationeryName, Stationery.Quantity, StockPrice FROM Stationery JOIN [Types] ON [Types].Id = Stationery.TypeId;";

        public AddStationery()
        {
            InitializeComponent();
        }
        private void AddStationery_Load(object sender, EventArgs e)
        {
            labelState.Text = Main.State;
            dataGridView1.DataSource = Query.Show(getTable);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].ReadOnly = true;

            DataTable types = Query.Show("SELECT TypeName FROM [Types];");
            foreach (DataRow row in types.Rows)
            {
                comboBox1.Items.Add(row[0].ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string query = $@"INSERT INTO [Stationery] (TypeId,StationeryName,Quantity,StockPrice)
                              SELECT Types.Id,'{stationeryTB.Text}','{quantityTB.Text}','{stockpriceTB.Text}' FROM Types WHERE Types.TypeName = '{comboBox1.SelectedItem}';";
            SqlCommand command = new SqlCommand(query, Main.connection);
            command.ExecuteNonQuery();

            string oldQuantity = $@"SELECT Types.Quantity FROM Types WHERE Types.TypeName = '{comboBox1.SelectedItem}';";
            SqlCommand command2 = new SqlCommand(oldQuantity, Main.connection);
            int oldvalue = Convert.ToInt32(command2.ExecuteScalar());

            string newQuantity = $@"UPDATE Types
                                       SET Types.Quantity = {oldvalue + Convert.ToInt32(quantityTB.Text)}
                                       WHERE Types.TypeName = '{comboBox1.SelectedItem}';";
            SqlCommand command3 = new SqlCommand(newQuantity, Main.connection);
            command3.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name == "Quantity")
            {
                string oldProductQuantity = $@"SELECT Stationery.Quantity FROM Stationery WHERE Stationery.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
                SqlCommand commandOldProductQuantity = new SqlCommand(oldProductQuantity, Main.connection);
                int oldProductValue = Convert.ToInt32(commandOldProductQuantity.ExecuteScalar());

                string oldTypeQuantity = $@"SELECT Types.Quantity FROM Types WHERE Types.TypeName = '{dataGridView1.CurrentRow.Cells["TypeName"].Value}';";
                SqlCommand commandOldTypeQuantity = new SqlCommand(oldTypeQuantity, Main.connection);
                int oldTypeValue = Convert.ToInt32(commandOldTypeQuantity.ExecuteScalar());

                string newTypeQuantity = $@"UPDATE Types
                                        SET Types.Quantity = {oldTypeValue + (Convert.ToInt32(dataGridView1.CurrentCell.Value) - oldProductValue)}
                                        WHERE Types.TypeName = '{dataGridView1.CurrentRow.Cells["TypeName"].Value}';";
                SqlCommand commandNewTypeQuantity = new SqlCommand(newTypeQuantity, Main.connection);
                commandNewTypeQuantity.ExecuteNonQuery();
            }

            string queryUpdate = $@"UPDATE Stationery
                                    SET Stationery.{dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name} = '{dataGridView1.CurrentCell.Value}'
                                    WHERE Stationery.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandUpdate = new SqlCommand(queryUpdate, Main.connection);
            commandUpdate.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string oldTypeQuantity = $@"SELECT Types.Quantity FROM Types WHERE Types.TypeName = '{dataGridView1.CurrentRow.Cells["TypeName"].Value}';";
            SqlCommand commandOldTypeQuantity = new SqlCommand(oldTypeQuantity, Main.connection);
            int oldTypeValue = Convert.ToInt32(commandOldTypeQuantity.ExecuteScalar());

            string newTypeQuantity = $@"UPDATE Types
                                        SET Types.Quantity = {oldTypeValue - Convert.ToInt32(dataGridView1.CurrentRow.Cells["Quantity"].Value)}
                                        WHERE Types.TypeName = '{dataGridView1.CurrentRow.Cells["TypeName"].Value}';";
            SqlCommand commandNewTypeQuantity = new SqlCommand(newTypeQuantity, Main.connection);
            commandNewTypeQuantity.ExecuteNonQuery();

            string queryDeleteConstr = $@"DELETE FROM Movement WHERE Movement.StationeryId = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDeleteConstr = new SqlCommand(queryDeleteConstr, Main.connection);
            commandDeleteConstr.ExecuteNonQuery();

            string queryDelete = $@"DELETE FROM Stationery WHERE Stationery.Id = {dataGridView1.CurrentRow.Cells["Id"].Value};";
            SqlCommand commandDelete = new SqlCommand(queryDelete, Main.connection);
            commandDelete.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }
    }
}
