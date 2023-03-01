using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Shopkeeper/Item")]
public class ShopkeeperItemScriptableObject : ScriptableObject {
    
    [SerializeField] public Texture2D texture;
    [SerializeField] public new string name;
    [SerializeField] public int price;

}