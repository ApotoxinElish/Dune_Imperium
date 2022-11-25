using UnityEngine;

namespace Dune
{
    [CreateAssetMenu(
        menuName = "Dune/Architecture/Variables/Integer",
        fileName = "Variable",
        order = 0)]
    public class IntVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = string.Empty;
#endif

        public int Value;

        public GameEventInt ValueChangedEvent;

        public void SetValue(int value)
        {
            Value = value;
            ValueChangedEvent?.Raise(value);
        }
    }
}
