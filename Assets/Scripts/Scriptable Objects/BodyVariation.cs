using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Variation/Body", order = 1)]
public class BodyVariation : ScriptableObject {

    [SerializeField] public Sprite[] walkAnimation;

}