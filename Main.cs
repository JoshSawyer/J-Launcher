using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Launchpad
{
    public partial class primaryForm : Form
    {
        private static GroupBox[] gameBoxes = new GroupBox[4];
        private static Game[] games = new Game[4];

        public primaryForm()
        {
            InitializeComponent();
            gameBoxes[0] = group1;
            gameBoxes[1] = group2;
            gameBoxes[2] = group3;
            gameBoxes[3] = group4;

            GetGamesFromStorage();
        }

        public static Game[] GetGames()
        {
            return games;
        }

        public void GetGamesFromStorage()
        {
            try
            {
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\gamesinfo\", "g~~~*");

                if (files.Length < 1)
                {
                    return;
                }

                int successfulLoads = 0;
                foreach (string file in files)
                {
                    try
                    {
                        AddGame(Game.LoadGame(file), -1);
                        successfulLoads++;
                    }
                    catch
                    {
                        MessageBox.Show(Game.LoadGame(file).GetInfo()[0] + ";" + file, "File Error");
                    }
                }

                if (successfulLoads == 0)
                {
                    return;
                }
                clearStorage.Visible = true;
            }
            catch
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\gamesinfo\");
            }
        }

        public bool AddGame(Game newGame, int idToReset)
        {
            if (newGame == null)
            {
                return false;
            }

            int space;
            if (idToReset < 0)
            {
                space = -1;
                for (int i = 0; i <= 3; i++)
                {
                    if (gameBoxes[i].Tag.ToString() == "undefined")
                    {
                        space = i;
                        break;
                    }
                }
                if (space == -1)
                {
                    return false;
                }
                else if (space == 3)
                {
                    newGameBtn.Enabled = false;
                }
            }
            else
            {
                space = idToReset;
            }

            gameBoxes[space].Enabled = true;
            gameBoxes[space].Tag = "defined";

            string title = newGame.GetInfo()[0] + ", " + newGame.GetInfo()[1];

            switch (space)
            {
                case 0:
                    group1tb.Text = title;

                    pictureBox1.Image =  System.Drawing.Icon.ExtractAssociatedIcon(newGame.GetInfo()[1]).ToBitmap();
                    var size = pictureBox1.Image.Size;
                    pictureBox1.Location = new System.Drawing.Point(187 - size.Width / 2, 75 - size.Height);
                    pictureBox1.Size = size;
                    break;
                case 1:
                    group2tb.Text = title;

                    pictureBox2.Image = System.Drawing.Icon.ExtractAssociatedIcon(newGame.GetInfo()[1]).ToBitmap();
                    var size2 = pictureBox2.Image.Size;
                    pictureBox2.Location = new System.Drawing.Point(187 - size2.Width / 2, 75 - size2.Height);
                    pictureBox2.Size = size2;
                    break;
                case 2:
                    group3tb.Text = title;

                    pictureBox3.Image = System.Drawing.Icon.ExtractAssociatedIcon(newGame.GetInfo()[1]).ToBitmap();
                    var size3 = pictureBox3.Image.Size;
                    pictureBox3.Location = new System.Drawing.Point(187 - size3.Width / 2, 75 - size3.Height);
                    pictureBox3.Size = size3;
                    break;
                case 3:
                    group4tb.Text = title;

                    pictureBox4.Image = System.Drawing.Icon.ExtractAssociatedIcon(newGame.GetInfo()[1]).ToBitmap();
                    var size4 = pictureBox4.Image.Size;
                    pictureBox4.Location = new System.Drawing.Point(187 - size4.Width / 2, 75 - size4.Height);
                    pictureBox4.Size = size4;
                    break;
            }
            games[space] = newGame;

            return true;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            new infoEntry(this, -1).ShowDialog();
        }
        private void StoreBtn_Click(object sender, EventArgs e)
        {
            bool success = false;

            foreach(Game curGame in games)
            {
                if (curGame != null)
                {
                    if (curGame.GetInfo()[0] != "")
                    {
                        curGame.Store();
                        success = true;
                    }
                }
            }
            if (!success)
            {
                MessageBox.Show("No games can be saved!", "Save Error");
                return;
            }

            clearStorage.Visible = true;
        }

        private void ClearStorage_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to clear all?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.No)
            {
                return;
            }

            Game.WipeGames();
            clearStorage.Visible = false;
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to clear all?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo);

            if (confirmDelete == DialogResult.No)
            {
                return;
            }

            for (int i = 0; i <= 3; i++)
            {
                ClearClick(i, false);
            }

            newGameBtn.Enabled = true;
        }

        private void StartClick(int id)
        {
            Process.Start(games[id].GetInfo()[1]);
        }
        private void EditClick(int id)
        {
            new infoEntry(this, id).ShowDialog();
        }
        private void ClearClick(int id, bool showMsg)
        {
            if (showMsg)
            {
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to clear this?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo);


                if (confirmDelete == DialogResult.No)
                {
                    return;
                }
            }

            if (games[id] != null)
            {
                games[id].Nullify();
            }

            switch (id)
            {
                case 0:
                    group1tb.Text = "";

                    pictureBox1.Image = null;
                    pictureBox1.Location = new System.Drawing.Point(6, 19);
                    pictureBox1.Size = new System.Drawing.Size(362, 67);
                    break;
                case 1:
                    group2tb.Text = "";

                    pictureBox2.Image = null;
                    pictureBox2.Location = new System.Drawing.Point(6, 19);
                    pictureBox2.Size = new System.Drawing.Size(362, 67);
                    break;
                case 2:
                    group3tb.Text = "";

                    pictureBox3.Image = null;
                    pictureBox3.Location = new System.Drawing.Point(6, 19);
                    pictureBox3.Size = new System.Drawing.Size(362, 67);
                    break;
                case 3:
                    group4tb.Text = "";

                    pictureBox4.Image = null;
                    pictureBox4.Location = new System.Drawing.Point(6, 19);
                    pictureBox4.Size = new System.Drawing.Size(362, 67);
                    break;
            }

            gameBoxes[id].Enabled = false;
            gameBoxes[id].Tag = "undefined";

            newGameBtn.Enabled = true;
        }

        private void TrayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            trayIcon.Visible = false;
        }
        private void ToTray_Click(object sender, EventArgs e)
        {
            Hide();
            trayIcon.Visible = true;
        }

        private void G1b1_Click(object sender, EventArgs e)
        {
            StartClick(0);
        }
        private void G1b2_Click(object sender, EventArgs e)
        {
            EditClick(0);
        }
        private void G1b3_Click(object sender, EventArgs e)
        {
            ClearClick(0, true);
        }

        private void G2b1_Click(object sender, EventArgs e)
        {
            StartClick(1);
        }
        private void G2b2_Click(object sender, EventArgs e)
        {
            EditClick(1);
        }
        private void G2b3_Click(object sender, EventArgs e)
        {
            ClearClick(1, true);
        }

        private void G3b1_Click(object sender, EventArgs e)
        {
            StartClick(2);
        }
        private void G3b2_Click(object sender, EventArgs e)
        {
            EditClick(2);
        }
        private void G3b3_Click(object sender, EventArgs e)
        {
            ClearClick(2, true);
        }

        private void G4b1_Click(object sender, EventArgs e)
        {
            StartClick(3);
        }
        private void G4b2_Click(object sender, EventArgs e)
        {
            EditClick(3);
        }
        private void G4b3_Click(object sender, EventArgs e)
        {
            ClearClick(3, true);
        }

        private void PrimaryForm_Load(object sender, EventArgs e) { }
        private void Group1_Enter(object sender, EventArgs e) { }
        private void Group2_Enter(object sender, EventArgs e) { }
        private void Group3_Enter_1(object sender, EventArgs e) { }
        private void Group4_Enter(object sender, EventArgs e) { }
        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void PictureBox1_Click(object sender, EventArgs e) { }
        private void PictureBox2_Click(object sender, EventArgs e) { }
        private void PictureBox3_Click(object sender, EventArgs e) { }
        private void PictureBox4_Click(object sender, EventArgs e) { }
        private void TrayIcon_DoubleClick(object sender, EventArgs e) { }
        private void PrimaryForm_KeyDown(object sender, KeyEventArgs e) { }
        private void PrimaryForm_FormClosing(object sender, FormClosingEventArgs e) { }
        private void PrimaryForm_Scroll(object sender, ScrollEventArgs e) { }

        private void Group1tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Group3tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Group4tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
