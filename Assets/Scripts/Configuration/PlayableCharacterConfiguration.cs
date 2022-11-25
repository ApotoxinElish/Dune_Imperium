using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dune
{
    [CreateAssetMenu(
        menuName = "Dune/Configuration/Player character",
        fileName = "PCConfiguration",
        order = 0)]
    public class PlayableCharacterConfiguration : ScriptableObject
    {
        public IntVariable Hp;
        public IntVariable Shield;

        public IntVariable Mana;

        // public StatusVariable Status;

        public GameObject HpWidget;
        public GameObject StatusWidget;
    }
}
