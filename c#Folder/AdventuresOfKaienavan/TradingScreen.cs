using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace AdventuresOfKaienavan
{
    public partial class TradingScreen : Form
    {
        private Player _currentPlayer;
        public TradingScreen(Player player)
        {
            _currentPlayer = player;
            InitializeComponent();


            DataGridViewCellStyle rightAlignedCellStyle = new DataGridViewCellStyle();
            rightAlignedCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dgvMyItems.RowHeadersVisible = false;
            dgvMyItems.AutoGenerateColumns = false;


            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemID",
                Visible = false
            });

            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 100,
                DataPropertyName = "Description"
            });

            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Qty",
                Width = 30,
                DefaultCellStyle = rightAlignedCellStyle,
                DataPropertyName = "Quantity"
            });

            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Width = 35,
                DefaultCellStyle = rightAlignedCellStyle,
                DataPropertyName = "Price"
            });

            dgvMyItems.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Sell 1",
                UseColumnTextForButtonValue = true,
                Width = 50,
                DataPropertyName = "ItemID"
            });


            dgvMyItems.DataSource = _currentPlayer.Inventory;

            dgvMyItems.CellClick += dgvMyItems_CellClick;



            dgvOrindaeItems.RowHeadersVisible = false;
            dgvOrindaeItems.AutoGenerateColumns = false;


            dgvOrindaeItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemID",
                Visible = false
            });

            dgvOrindaeItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 100,
                DataPropertyName = "Description"
            });

            dgvOrindaeItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Width = 35,
                DefaultCellStyle = rightAlignedCellStyle,
                DataPropertyName = "Price"
            });

            dgvOrindaeItems.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Buy 1",
                UseColumnTextForButtonValue = true,
                Width = 50,
                DataPropertyName = "ItemID"
            });


            dgvOrindaeItems.DataSource = _currentPlayer.CurrentLocation.VendorWorkingHere.Inventory;


            dgvOrindaeItems.CellClick += dgvOrindaeItems_CellClick;
        }

        private void dgvMyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {

                var itemID = dgvMyItems.Rows[e.RowIndex].Cells[0].Value;


                Item itemBeingSold = World.ItemByID(Convert.ToInt32(itemID));


                _currentPlayer.RemoveItemFromInventory(itemBeingSold);

                _currentPlayer.Gold += itemBeingSold.Price;
                
            }
        }

        private void dgvOrindaeItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {

                var itemID = dgvOrindaeItems.Rows[e.RowIndex].Cells[0].Value;


                Item itemBeingBought = World.ItemByID(Convert.ToInt32(itemID));


                if (_currentPlayer.Gold >= itemBeingBought.Price)
                {
                    _currentPlayer.AddItemToInventory(itemBeingBought);

                    _currentPlayer.Gold -= itemBeingBought.Price;
                }
                else
                {
                    MessageBox.Show("You do not have enough gold to buy the " + itemBeingBought.Name);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
