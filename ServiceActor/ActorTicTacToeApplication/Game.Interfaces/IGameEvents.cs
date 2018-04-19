using Microsoft.ServiceFabric.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    public interface IGameEvents :IActorEvents
    {
        void NewChallengeHasArrived(string playerName);
    }
}
