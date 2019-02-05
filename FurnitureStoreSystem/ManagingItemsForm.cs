using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FurnitureStoreSystem
{
    public partial class ManagingItemsForm : Form
    {
        public ManagingMenuForm mmf;
        private string connectionDB = ConfigurationManager.ConnectionStrings["Furnituredb"].ConnectionString;
        private string currentID;

        public ManagingItemsForm()
        {
            InitializeComponent();
            SelectItemsFromTable();
        }

        public ManagingItemsForm(ManagingMenuForm mmf)
        {
            InitializeComponent();
            this.mmf = mmf;
            SelectItemsFromTable();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            InsertItemToTable();
            SelectItemsFromTable();
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            EditItemToTable();
            SelectItemsFromTable();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            DeleteItemFromTable();
            SelectItemsFromTable();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            mmf.Visible = true;
        }

        private void ManagingItemsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mmf.Visible = true;
        }

        private void SelectItemsFromTable()
        {
            // Configure connection
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();

            // Select items
            SqlCommand select = new SqlCommand("SELECT ID, Name, Price, Quantity FROM FurnitureTable", conn);
            DataTable dt = new DataTable();
            SqlDataReader rdr = select.ExecuteReader();
            if (rdr.HasRows)
            {
                dt.Load(rdr);
                ItemsTable.DataSource = dt;
                ItemsTable.Visible = true;
            }
            else
            {
                ItemsTable.Visible = false;
            }

            // Refresh ID and hide ID row
            ItemsTable.Columns[0].Visible = false;
            currentID = "1";
            for (int i = 1; i < ItemsTable.Columns.Count; i++)
                ItemsTable.Columns[i].Width = 77;

            // Close the connection
            conn.Close();
        }

        private void InsertItemToTable()
        {
            // Configure connection
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();

            // Insert an item
            SqlCommand insert = new SqlCommand("INSERT INTO FurnitureTable (Name, Price, Quantity) VALUES (@name, @price, @quantity)", conn);
            float price;
            int quantity;
            if (!String.IsNullOrEmpty(AddItemNameTextBox.Text) &&
                float.TryParse(AddItemPriceTextBox.Text, out price) &&
                int.TryParse(AddItemQuantityTextBox.Text, out quantity))
            {
                insert.Parameters.AddWithValue("@name", AddItemNameTextBox.Text);
                insert.Parameters.AddWithValue("@price", price);
                insert.Parameters.AddWithValue("@quantity", quantity);
            }
            insert.ExecuteNonQuery();

            // Close the connection
            conn.Close();
        }

        private void EditItemToTable()
        {
            // Configure connection
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();

            // Edit an item
            SqlCommand edit = new SqlCommand("UPDATE FurnitureTable SET Name = @name, Price = @price, Quantity = @quantity WHERE ID = '" + currentID + "'", conn);
            float price;
            int quantity;
            if (!String.IsNullOrEmpty(EditItemNameTextBox.Text) &&
                float.TryParse(EditItemPriceTextBox.Text, out price) &&
                int.TryParse(EditItemQuantityTextBox.Text, out quantity))
            {
                edit.Parameters.AddWithValue("@name", EditItemNameTextBox.Text);
                edit.Parameters.AddWithValue("@price", price);
                edit.Parameters.AddWithValue("@quantity", quantity);
            }
            edit.ExecuteNonQuery();

            // Close the connection
            conn.Close();
        }

        private void DeleteItemFromTable()
        {
            // Configure connection
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();

            // Delete an item
            SqlCommand delete = new SqlCommand("DELETE FROM FurnitureTable WHERE ID = '" + currentID + "'", conn);
            delete.ExecuteNonQuery();

            // Empty fields
            EditItemNameTextBox.Text = "";
            EditItemPriceTextBox.Text = "";
            EditItemQuantityTextBox.Text = "";

            // Close the connection
            conn.Close();
        }

        private void ItemsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = ItemsTable.CurrentRow;

            currentID = ItemsTable[0, row.Index].Value.ToString();
            EditItemNameTextBox.Text = ItemsTable[1, row.Index].Value.ToString();
            EditItemPriceTextBox.Text = ItemsTable[2, row.Index].Value.ToString();
            EditItemQuantityTextBox.Text = ItemsTable[3, row.Index].Value.ToString();
        }
    }
}
