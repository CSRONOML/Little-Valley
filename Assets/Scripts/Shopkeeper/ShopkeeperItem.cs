using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ShopkeeperItem : MonoBehaviour {

    [Header("Settings")]
    [SerializeField] public bool purchased;
    [SerializeField] public bool equipped;

    [Header("References")]
    [SerializeField] private ShopkeeperItemScriptableObject shopkeeperItem;
    [SerializeField] private RawImage image;
    [SerializeField] private TextMeshProUGUI text;

    #if UNITY_EDITOR
    private void Update() {
        UpdateItemDetails();
    }
    #else
    private void Awake() {
        UpdateItemDetails();
    }
    #endif

    private void UpdateItemDetails() {
        image.texture = shopkeeperItem.texture;
        text.text = shopkeeperItem.name + "\n$" + shopkeeperItem.price;
    }

    public ShopkeeperItemScriptableObject GetScriptableObject() {
        return shopkeeperItem;
    }

}
