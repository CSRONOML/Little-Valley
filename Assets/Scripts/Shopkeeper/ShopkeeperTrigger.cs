using System.Collections;
using UnityEngine;

public class ShopkeeperTrigger : MonoBehaviour {
    
    [Header("Settings")]
    [SerializeField] private float speed;
    
    [Header("References")]
    [SerializeField] private CanvasGroup shopkeeperOverlay;

    private void OnTriggerEnter2D(Collider2D collision) {
        StartCoroutine(buttonTransitionRoutiune(1));
    }

    private void OnTriggerExit2D(Collider2D collision) {
        StartCoroutine(buttonTransitionRoutiune(0));
    }

    private IEnumerator buttonTransitionRoutiune(float target) {
        for (var time = 1 - target; time != target; time = Mathf.MoveTowards(time, target, speed * Time.deltaTime)) {
            shopkeeperOverlay.alpha = time;
            yield return null;
        }

        shopkeeperOverlay.alpha = target;
    }

}
