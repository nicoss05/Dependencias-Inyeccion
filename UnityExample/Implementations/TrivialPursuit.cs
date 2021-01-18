using UnityExample.Contracts;

namespace UnityExample.Implementations
{
    public class TrivialPursuit : IGame
    {
        private string _status;

        public TrivialPursuit()
        {
            Name = "Trivial Pursuit";
            CurrentPlayers = 0;
            MinPlayers = 2;
            MaxPlayers = 8;
            _status = "No active games";
        }

        #region IGame Members

        public string Name { get; set; }
        
        public int CurrentPlayers { get; set; }

        public int MinPlayers { get; set; }

        public int MaxPlayers { get; set;  }
        
        public void AddPlayer()
        {
            CurrentPlayers++;
        }

        public void RemovePlayer()
        {
            CurrentPlayers--;
        }

        public void Play()
        {
            if ((CurrentPlayers > MaxPlayers) || (CurrentPlayers < MinPlayers))
                _status = string.Format("{0}: No se puede jugar con {1} jugador.", Name, CurrentPlayers);
            else
                _status = string.Format("{0}: jugando con{1} jugadores.", Name, CurrentPlayers);
        }

        public string Result()
        {
            return _status;
        }

        #endregion
    }
}
