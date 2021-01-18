using UnityExample.Contracts;

namespace UnityExample
{
    public class Table
    {
        private readonly IGame game;

        public Table(IGame game)
        {
            this.game = game;
        }

        public string GameStatus()
        {
            return game.Result();
        }

        public void AddPlayer()
        {
            game.AddPlayer();
        }

        public void RemovePlayer()
        {
            game.RemovePlayer();
        }

        public void Play()
        {
            game.Play();
        }
    }
}
