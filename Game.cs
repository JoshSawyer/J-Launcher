using System.IO;

namespace Launchpad
{
    public class Game
    {
        public static int gameCount = 0;

        private static string cwd;

        private string gameName;
        private string gameDir;

        public Game(string _gameName, string _gameDir)
        {
            cwd = Directory.GetCurrentDirectory();
            cwd += @"\gamesinfo\";

            if (!Directory.Exists(cwd))
            {
                Directory.CreateDirectory(cwd);
            }

            if (gameCount < 1)
            {
                foreach (string file in Directory.GetFiles(cwd))
                {
                    if (file.IndexOf("g~~~") > -1)
                    {
                        gameCount++;
                    }
                }
            }
            gameName = _gameName;
            gameDir = _gameDir;
        }

        public void Nullify()
        {
            cwd = "";
            gameName = "";
            gameDir = "";
            gameCount--;
        }

        public bool ValidateGameInfo()
        {
            if (!File.Exists(gameDir))
            {
                return false;
            }
            if (File.Exists(cwd + "g~~~" + gameName + ".txt"))
            {
                return false;
            }
            return true;
        }

        public string[] GetInfo()
        {
            string[] gameInfo = { gameName, gameDir };
            return gameInfo;
        }

        public string ConvertForStorage()
        {
            return gameName + "║;║" + gameDir;
        }

        public bool Store()
        {
            string gameFile = "g~~~" + gameName + ".txt";

            if (File.Exists(cwd + gameFile))
            {
                return false;
            }

            try
            {
                File.WriteAllText(cwd + gameFile, ConvertForStorage());
                gameCount++;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool WipeGames()
        {
            try
            {
                foreach (string file in Directory.GetFiles(cwd, "g~~~*"))
                {
                    File.Delete(file);
                }
                gameCount = 0;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Game LoadGame(string dir)
        {
            string contents = File.ReadAllText(dir);

            int i = contents.IndexOf("║;║");
            if (i < 0)
            {
                return null;
            }

            string _gameName = contents.Substring(0, i);
            string _gameDir = contents.Substring(i, contents.Length - i);

            _gameDir = _gameDir.Replace("║;║", "");

            return new Game(_gameName, _gameDir);
        }
    }
}
