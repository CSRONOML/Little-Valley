using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Shoes")]
public class ShoesVariationScriptableObject : ScriptableObject {
    
    [SerializeField] public Sprite[] walkAnimation;

}