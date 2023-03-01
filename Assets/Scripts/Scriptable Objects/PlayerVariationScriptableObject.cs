using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Body")]
public class PlayerVariationScriptableObject : ScriptableObject {
    
    [Header("Settings")]
    [SerializeField] public new string name;
    [SerializeField] public int price;

    [Header("References")]
    [SerializeField] public PlayerVariationType type;
    [SerializeField] public Sprite[] walkAnimation;
    [SerializeField] public Texture2D texture;

}

public enum PlayerVariationType {
    BODY,
    HAIR,
    PANTS,
    SHIRT,
    SHOES
}