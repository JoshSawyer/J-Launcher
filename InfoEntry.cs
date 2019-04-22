using System;
using System.Windows.Forms;

namespace Launchpad
{
    public partial class infoEntry : Form
    {
        primaryForm initialForm;

        public infoEntry(primaryForm _initialForm)
        {
            InitializeComponent();
            initialForm = _initialForm;
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
            initialForm.AddGame(newGame);

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
    }
}
