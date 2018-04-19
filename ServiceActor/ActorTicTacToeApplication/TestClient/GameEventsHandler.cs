using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class GameEventsHandler: IGameEvents
    {
        public void NewChallengeHasArrived(string playerName)
        {
            Console.WriteLine($"A new challenger has arrived {playerName}");
        }
    }
}
