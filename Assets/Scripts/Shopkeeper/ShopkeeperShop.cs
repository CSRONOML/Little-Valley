using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ShopkeeperShop : MonoBehaviour {
    
    [Header("References")]
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Button buyButton;
    [SerializeField] private Button sellButton;
    [SerializeField] private Button equipButton;
    [SerializeField] private ShopkeeperItem selectedItem;
    [SerializeField] private CharacterAnimator characterAnimator;

    [Header("Settings")]
    [SerializeField] private int balance;

    #if UNITY_EDITOR
    private void Update() {
        SetBalance(balance);
    }
    #else
    private void Awake() {
        SetBalance(balance);
    }
    #endif

    private void SetBalance(int balance) {
        this.balance = balance;
        text.text = balance.ToString();
    }

    private void UpdateButtons() {
        buyButton.interactable = !selectedItem.purchased && balance >= selectedItem.GetScriptableObject().price;
        sellButton.interactable = selectedItem.purchased;
        equipButton.interactable = selectedItem.purchased;
    }

    public void Buy() {
        SetBalance(balance - selectedItem.GetScriptableObject().price);
        selectedItem.purchased = true;
        UpdateButtons();
    }

    public void Sell() {
        SetBalance(balance + selectedItem.GetScriptableObject().price);
        characterAnimator.ResetPlayerVariation(selectedItem.GetScriptableObject());
        selectedItem.purchased = false;
        UpdateButtons();
    }

    public void Equip() {
        characterAnimator.SetPlayerVariation(selectedItem.GetScriptableObject());
    }

    public void SetSelectedItem(ShopkeeperItem selectedItem) {
        this.selectedItem = selectedItem;
        UpdateButtons();
    }

}
