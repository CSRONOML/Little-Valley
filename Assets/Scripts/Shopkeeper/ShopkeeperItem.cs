using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ShopkeeperItem : MonoBehaviour {

    [SerializeField] private ShopkeeperItemScriptableObject shopkeeperItem;
    [SerializeField] private RawImage image;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private bool purchased;
    [SerializeField] private bool equipped;

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

}
