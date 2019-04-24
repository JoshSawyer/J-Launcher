using System;
using System.Windows.Forms;

namespace Launchpad
{
    public partial class infoEntry : Form
    {
        bool primaryFormInit;
        primaryForm initialForm;
        Main_2 initialForm2;
        int curGameId;

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
            primaryFormInit = true;
        }

        public infoEntry(Main_2 _initialForm, int _curGameId)
        {
            InitializeComponent();
            initialForm2 = _initialForm;
            curGameId = _curGameId;

            if (curGameId > -1)
            {
                nameInput.Text = primaryForm.GetGames()[curGameId].GetInfo()[0];
                dirInput.Text = primaryForm.GetGames()[curGameId].GetInfo()[1];
            }
            primaryFormInit = false;
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
                if (primaryFormInit)
                {
                    initialForm.AddGame(newGame, -1);
                }
                else
                {
                    initialForm2.AddGame(newGame, -1);
                }
            }
            else
            {
                if (primaryFormInit)
                {
                    initialForm.AddGame(newGame, curGameId);
                }
                else
                {
                    initialForm2.AddGame(newGame, curGameId);
                }
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
