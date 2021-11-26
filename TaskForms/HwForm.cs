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
    public partial class HwForm : Form
    {
        public HwForm()
        {
            InitializeComponent();
        }

        private void HwForm_Load(object sender, EventArgs e)
        {
            labelState.Text = Main.State;
        }

        private void task1Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT MN, ML, SQ
                                                     FROM (
                                                     SELECT Manager.ManagerName as MN, Manager.ManagerLastname as ML, SUM(Movement.NumberSold) as SQ
                                                     FROM Movement JOIN Manager ON Manager.Id=Movement.ManagerId
                                                     GROUP BY Manager.ManagerName, Manager.ManagerLastname
                                                     ) AS SomeTable
                                                     WHERE
                                                     SQ =
                                                     (SELECT MAX(SQ2) FROM
                                                     (
                                                     SELECT SUM(Movement.NumberSold) as SQ2
                                                     FROM Movement JOIN Manager ON Manager.Id=Movement.ManagerId
                                                     GROUP BY Manager.ManagerName, Manager.ManagerLastname
                                                     ) as SomeTable);");
        }

        private void task2Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT MN, ML, Total
                                                     FROM (
                                                     SELECT Manager.ManagerName as MN, Manager.ManagerLastname as ML, SUM(Movement.NumberSold*Movement.SellPrice) as Total
                                                     FROM Movement JOIN Manager ON Manager.Id=Movement.ManagerId
                                                     GROUP BY Manager.ManagerName, Manager.ManagerLastname
                                                     ) AS SomeTable
                                                     WHERE
                                                     Total =
                                                     (SELECT MAX(Total2) FROM
                                                     (
                                                     SELECT SUM(Movement.NumberSold*Movement.SellPrice) as Total2
                                                     FROM Movement JOIN Manager ON Manager.Id=Movement.ManagerId
                                                     GROUP BY Manager.ManagerName, Manager.ManagerLastname
                                                     ) as SomeTable);");
        }

        private void task3Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT 'None' as 'Skipped'");
        }

        private void task4Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT CN, Total
                                                     FROM (
                                                     SELECT Buyer.CompanyName as CN, SUM(Movement.NumberSold*Movement.SellPrice) as Total
                                                     FROM Movement JOIN Buyer ON Buyer.Id=Movement.BuyerId
                                                     GROUP BY Buyer.CompanyName
                                                     ) AS SomeTable
                                                     WHERE
                                                     Total =
                                                     (SELECT MAX(Total2) FROM
                                                     (
                                                     SELECT SUM(Movement.NumberSold*Movement.SellPrice) as Total2
                                                     FROM Movement JOIN Buyer ON Buyer.Id=Movement.BuyerId
                                                     GROUP BY Buyer.CompanyName
                                                     ) as SomeTable);");
        }

        private void task5Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT TN, sumQuant
                                                     FROM (
                                                     SELECT Types.TypeName as TN, SUM(Movement.NumberSold) as sumQuant
                                                     FROM Movement JOIN Stationery ON Stationery.Id=Movement.StationeryId
                                                     JOIN Types ON Types.Id = Stationery.TypeId
                                                     GROUP BY Types.TypeName
                                                     ) AS SomeTable
                                                     WHERE
                                                     sumQuant =
                                                     (SELECT MAX(sumQuant2) FROM
                                                     (
                                                     SELECT SUM(Movement.NumberSold) as sumQuant2
                                                     FROM Movement JOIN Stationery ON Stationery.Id=Movement.StationeryId
                                                     JOIN Types ON Types.Id = Stationery.TypeId
                                                     GROUP BY Types.TypeName
                                                     ) as SomeTable);");
        }

        private void task6Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT TN, Total
                                                     FROM (
                                                     SELECT Types.TypeName as TN, SUM(Movement.NumberSold*Movement.SellPrice) as Total
                                                     FROM Movement JOIN Stationery ON Stationery.Id=Movement.StationeryId
                                                     JOIN Types ON Types.Id = Stationery.TypeId
                                                     GROUP BY Types.TypeName
                                                     ) AS SomeTable
                                                     WHERE
                                                     Total =
                                                     (SELECT MAX(Total2) FROM
                                                     (
                                                     SELECT SUM(Movement.NumberSold*Movement.SellPrice) as Total2
                                                     FROM Movement JOIN Stationery ON Stationery.Id=Movement.StationeryId
                                                     JOIN Types ON Types.Id = Stationery.TypeId
                                                     GROUP BY Types.TypeName
                                                     ) as SomeTable);");
        }

        private void task7Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT SN, sumQuant
                                                     FROM (
                                                     SELECT Stationery.StationeryName as SN, SUM(Movement.NumberSold) as sumQuant
                                                     FROM Movement JOIN Stationery ON Stationery.Id=Movement.StationeryId
                                                     GROUP BY Stationery.StationeryName
                                                     ) AS SomeTable
                                                     WHERE
                                                     sumQuant =
                                                     (SELECT MAX(sumQuant2) FROM
                                                     (
                                                     SELECT Stationery.StationeryName as SN, SUM(Movement.NumberSold) as sumQuant2
                                                     FROM Movement JOIN Stationery ON Stationery.Id=Movement.StationeryId
                                                     GROUP BY Stationery.StationeryName
                                                     ) as SomeTable);");
        }

        private void task8Button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Query.Show($@"SELECT 'None' as 'Skipped'");
        }
    }
}
