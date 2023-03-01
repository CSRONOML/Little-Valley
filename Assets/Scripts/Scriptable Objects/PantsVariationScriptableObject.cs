using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Pants")]
public class PantsVariationScriptableObject : ScriptableObject {
    
    [SerializeField] public Sprite[] walkAnimation;

}