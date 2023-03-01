using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Shirt")]
public class ShirtVariationScriptableObject : ScriptableObject {
    
    [SerializeField] public Sprite[] walkAnimation;

}