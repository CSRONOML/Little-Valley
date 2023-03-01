using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Shopkeeper/Item")]
public class ShopkeeperItemScriptableObject : ScriptableObject {
    
    [Header("Settings")]
    [SerializeField] public new string name;
    [SerializeField] public int price;

    [Header("References")]
    [SerializeField] public Texture2D texture;

}