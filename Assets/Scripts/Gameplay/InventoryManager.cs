using System.Collections;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
    
    [Header("Settings")]
    [SerializeField] private float animationSpeed;
    
    [Header("References")]
    [SerializeField] private CanvasGroup inventoryOverlay;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (inventoryOverlay.alpha == 0) {
                StartCoroutine(InventoryTransitionRoutine(1));
            } else if (inventoryOverlay.alpha == 1) {
                StartCoroutine(InventoryTransitionRoutine(0));
            }
        }
    }

    private IEnumerator InventoryTransitionRoutine(float target) {
        for (var time = 1 - target; time != target; time = Mathf.MoveTowards(time, target, animationSpeed * Time.deltaTime)) {
            inventoryOverlay.alpha = time;
            yield return null;
        }

        inventoryOverlay.alpha = target;
    }

}
