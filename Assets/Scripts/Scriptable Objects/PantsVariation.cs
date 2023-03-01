using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Pants", order = 1)]
public class PantsVariation : ScriptableObject {
    
    [SerializeField] public Sprite[] walkAnimation;

}