using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Body")]
public class PlayerVariationScriptableObject : ScriptableObject {
    
    [SerializeField] public PlayerVariationType type;
    [SerializeField] public Sprite[] walkAnimation;

}

public enum PlayerVariationType {
    BODY,
    HAIR,
    PANTS,
    SHIRT,
    SHOES
}