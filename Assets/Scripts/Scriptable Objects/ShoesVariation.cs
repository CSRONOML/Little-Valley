using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Shoes", order = 1)]
public class ShoesVariation : ScriptableObject {
    
    [SerializeField] public Sprite[] walkAnimation;

}