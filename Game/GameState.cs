using Game.Jobs;
using Game.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class GameState
    {
        public Resource[] PlayerResources { get; } =
            Enum.GetValues(typeof(RType))
                .Cast<RType>()
                .Select(x => new Resource(x))
                .ToArray();
        public GameState() {}

    }
}
