using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ShopkeeperItem : MonoBehaviour {

    [Header("Settings")]
    [SerializeField] public bool purchased;

    [Header("References")]
    [SerializeField] private PlayerVariationScriptableObject playerVariation;
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
        image.texture = playerVariation.texture;
        text.text = playerVariation.name + "\n$" + playerVariation.price;
    }

    public PlayerVariationScriptableObject GetScriptableObject() {
        return playerVariation;
    }

}
