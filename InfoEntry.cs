using System;
using System.Windows.Forms;

namespace Launchpad
{
    public partial class infoEntry : Form
    {
        primaryForm initialForm;
        int curGameId;

        string nameMemory;
        string dirMemory;

        public infoEntry(primaryForm _initialForm, int _curGameId)
        {
            InitializeComponent();
            initialForm = _initialForm;
            curGameId = _curGameId;

            if (curGameId > -1)
            {
                nameInput.Text = primaryForm.GetGames()[curGameId].GetInfo()[0];
                dirInput.Text = primaryForm.GetGames()[curGameId].GetInfo()[1];
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            Game newGame = new Game(name, dirInput.Text);

            if (!newGame.ValidateGameInfo())
            {
                MessageBox.Show("Input(s) not valid!", "Error");
                return;
            }

            if (curGameId < 0)
            {
                foreach (Game curGame in primaryForm.GetGames())
                {
                    if (curGame != null)
                    {
                        if (curGame.GetInfo()[0] == name)
                        {
                            MessageBox.Show("Input(s) not valid!", "Error");
                            return;
                        }
                    }
                }
            }

            if (curGameId < 0)
            {
                initialForm.AddGame(newGame, -1);
            }
            else
            {
                initialForm.AddGame(newGame, curGameId);
            }

            Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = getFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                dirInput.Text = getFile.FileName;
            }
        }

        private void InfoEntry_Load(object sender, EventArgs e) { }
        private void Label1_Click(object sender, EventArgs e) { }
        private void NameInput_TextChanged(object sender, EventArgs e) { }
    }
}
