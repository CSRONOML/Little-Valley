using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Shirt", order = 1)]
public class ShirtVariation : ScriptableObject {
    
    [SerializeField] public Sprite[] walkAnimation;

}