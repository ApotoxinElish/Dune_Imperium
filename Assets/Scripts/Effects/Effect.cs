using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
#endif

namespace Dune
{
    /// <summary>
    /// The base type of all the card effects available in the kit. As with most of the
    /// configuration elements in the codebase, effect templates are scriptable objects.
    /// </summary>
    public abstract class Effect : ScriptableObject
    {
        public abstract string GetName();

#if UNITY_EDITOR
#endif
    }
}
