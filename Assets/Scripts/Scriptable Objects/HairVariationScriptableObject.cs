using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Hair")]
public class HairVariationScriptableObject : ScriptableObject {
    
    [SerializeField] public Sprite[] walkAnimation;

}