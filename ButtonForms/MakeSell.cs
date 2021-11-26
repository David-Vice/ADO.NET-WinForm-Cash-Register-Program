using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_WinForm_HW1.ButtonForms
{
    public partial class MakeSell : Form
    {
        private string getTable = $@"SELECT Types.TypeName, Stationery.StationeryName, Movement.NumberSold, Movement.SellPrice, CONCAT(Manager.ManagerName,' ',Manager.ManagerLastname) as Manager, Buyer.CompanyName, Movement.MovementDate, Movement.NumberSold*Movement.SellPrice as Total
                                     FROM [Movement]
                                     JOIN [Stationery] ON Stationery.Id = Movement.StationeryId
                                     JOIN [Types] ON [Types].Id = Stationery.TypeId
                                     JOIN [Manager] ON Manager.Id = Movement.ManagerId
                                     JOIN [Buyer] ON Buyer.Id = Movement.BuyerId";

        public MakeSell()
        {
            InitializeComponent();
        }

        private void MakeSell_Load(object sender, EventArgs e)
        {
            labelState.Text = Main.State;
            dataGridView1.DataSource = Query.Show(getTable);

            DataTable types = Query.Show("SELECT TypeName FROM [Types];");
            foreach (DataRow row in types.Rows)
            {
                typeCB.Items.Add(row[0].ToString());
            }

            DataTable managers = Query.Show("SELECT CONCAT(Manager.ManagerName,' ',Manager.ManagerLastname) as Manager FROM Manager");
            foreach (DataRow row in managers.Rows)
            {
                sellerCB.Items.Add(row[0].ToString());
            }

            DataTable buyers = Query.Show("SELECT CompanyName FROM Buyer;");
            foreach (DataRow row in buyers.Rows)
            {
                buyerCB.Items.Add(row[0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!productCB.Enabled) productCB.Enabled = true;

            DataTable products = Query.Show($@"SELECT Stationery.StationeryName FROM Stationery 
                                               JOIN [Types] ON [Types].Id = Stationery.TypeId
                                               WHERE [Types].Id = (SELECT [Types].Id FROM [Types] WHERE [Types].TypeName = '{typeCB.SelectedItem}');");
            productCB.Items.Clear();
            foreach (DataRow row in products.Rows)
            {
                productCB.Items.Add(row[0].ToString());
            }
            stockNumLabel.Text = "0";
            quantNumLabel.Text = "0";
        }

        private void productCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string findPrice = $@"SELECT Stationery.StockPrice FROM Stationery WHERE Stationery.StationeryName = '{productCB.SelectedItem}';";
            SqlCommand command1 = new SqlCommand(findPrice, Main.connection);
            stockNumLabel.Text = Convert.ToString(command1.ExecuteScalar());

            string findQuantity = $@"SELECT Stationery.Quantity FROM Stationery WHERE Stationery.StationeryName = '{productCB.SelectedItem}';";
            SqlCommand command2 = new SqlCommand(findQuantity, Main.connection);
            quantNumLabel.Text = Convert.ToString(command2.ExecuteScalar());
        }

        private void priceTB_TextChanged(object sender, EventArgs e)
        {
            if(priceTB.Text != string.Empty && quantTB.Text != string.Empty)
            totalNumLabel.Text = Convert.ToString(Convert.ToInt32(priceTB.Text) * Convert.ToInt32(quantTB.Text));
        }
        private void quantTB_TextChanged(object sender, EventArgs e)
        {
            if (priceTB.Text != string.Empty && quantTB.Text != string.Empty)
            totalNumLabel.Text = Convert.ToString(Convert.ToInt32(priceTB.Text) * Convert.ToInt32(quantTB.Text));
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            string insertQuery = $@"INSERT INTO [Movement] (StationeryId,ManagerId,BuyerId,NumberSold,SellPrice,MovementDate)
                                    SELECT Stationery.Id,Manager.Id,Buyer.Id,{quantTB.Text},{priceTB.Text}, CAST( GETDATE() AS Date )
                                    FROM [Stationery],[Manager],[Buyer]
                                    WHERE
                                    Stationery.StationeryName = '{productCB.SelectedItem}' 
                                    AND
                                    CONCAT(Manager.ManagerName,' ',Manager.ManagerLastname) = '{sellerCB.SelectedItem}' 
                                    AND
                                    Buyer.CompanyName = '{buyerCB.SelectedItem}'";
            SqlCommand insertCommand = new SqlCommand(insertQuery, Main.connection);
            insertCommand.ExecuteNonQuery();

            string oldTypeQuantity = $@"SELECT Types.Quantity FROM Types WHERE Types.TypeName = '{typeCB.SelectedItem}';";
            SqlCommand commandOldTypeQuantity = new SqlCommand(oldTypeQuantity, Main.connection);
            int oldTypeValue = Convert.ToInt32(commandOldTypeQuantity.ExecuteScalar());

            string newTypeQuantity = $@"UPDATE Types
                                        SET Types.Quantity = {oldTypeValue - Convert.ToInt32(quantTB.Text)}
                                        WHERE Types.TypeName = '{typeCB.SelectedItem}';";
            SqlCommand commandNewTypeQuantity = new SqlCommand(newTypeQuantity, Main.connection);
            commandNewTypeQuantity.ExecuteNonQuery();

            string oldProductQuantity = $@"SELECT Stationery.Quantity FROM Stationery WHERE Stationery.StationeryName = '{productCB.SelectedItem}';";
            SqlCommand commandOldProductQuantity = new SqlCommand(oldProductQuantity, Main.connection);
            int oldProductValue = Convert.ToInt32(commandOldProductQuantity.ExecuteScalar());

            string newProductQuantity = $@"UPDATE Stationery
                                        SET Stationery.Quantity = {oldProductValue - Convert.ToInt32(quantTB.Text)}
                                        WHERE Stationery.StationeryName = '{productCB.SelectedItem}';";
            SqlCommand commandNewProductQuantity = new SqlCommand(newProductQuantity, Main.connection);
            commandNewProductQuantity.ExecuteNonQuery();

            dataGridView1.DataSource = Query.Show(getTable);
        }
    }
}
