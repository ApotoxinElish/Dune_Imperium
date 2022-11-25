using System.Collections.Generic;
using UnityEngine;

namespace Dune
{
    [CreateAssetMenu(
        menuName = "Dune/Architecture/Events/Game event (int)",
        fileName = "GameEvent",
        order = 1)]
    public class GameEventInt : ScriptableObject
    {
        public void Raise(int value)
        { }
    }
}
