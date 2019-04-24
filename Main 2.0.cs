using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Launchpad
{
    public partial class Main_2 : Form
    {
        string curItem = null;

        public Main_2()
        {
            InitializeComponent();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                curItem = listBox.SelectedItem.ToString();
            }
            catch { }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            new infoEntry(this, -1).ShowDialog();
        }
        public bool AddGame(Game newGame)
        {
            listBox.Items.Add(new object[] {
                Icon.ExtractAssociatedIcon(newGame.GetInfo()[1]).ToBitmap(),
                newGame.GetInfo()[0] + ", " + newGame.GetInfo()[1]
            });
            return true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (curItem == null) return;

            int comIndex = curItem.IndexOf(", ") + 2;
            Process.Start(curItem.Substring(comIndex, curItem.Length - comIndex));
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (curItem == null) return;

            dataGridView1.Items.Remove(curItem);
            curItem = null;
        }

        private void Main_2_Load(object sender, EventArgs e) { }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
