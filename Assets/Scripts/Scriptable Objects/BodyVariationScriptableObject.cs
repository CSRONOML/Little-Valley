using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Body")]
public class BodyVariationScriptableObject : ScriptableObject {

    [SerializeField] public Sprite[] walkAnimation;

}