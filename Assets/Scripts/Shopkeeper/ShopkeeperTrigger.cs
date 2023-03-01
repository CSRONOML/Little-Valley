using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShopkeeperTrigger : MonoBehaviour {
    
    [Header("Settings")]
    [SerializeField] private float speed;
    
    [Header("References")]
    [SerializeField] private Texture buttonUp;
    [SerializeField] private Texture buttonDown;
    [SerializeField] private RawImage shopkeeperImage;
    [SerializeField] private CanvasGroup shopkeeperOverlay;

    private void Update() {
        if (Input.GetKey(KeyCode.E)) {
            shopkeeperImage.texture = buttonDown;
        } else {
            shopkeeperImage.texture = buttonUp;
        }
    }

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