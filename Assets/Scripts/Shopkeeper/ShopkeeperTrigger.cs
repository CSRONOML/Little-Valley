using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShopkeeperTrigger : MonoBehaviour {
    
    [Header("Settings")]
    [SerializeField] private float animationSpeed;
    
    [Header("References")]
    [SerializeField] private Texture buttonUp;
    [SerializeField] private Texture buttonDown;
    [SerializeField] private SpriteRenderer[] shopkeeperSpriteRenderers;
    [SerializeField] private RawImage hintImage;
    [SerializeField] private CanvasGroup hintOverlay;
    [SerializeField] private CanvasGroup shopOverlay;

    public bool IsShopping { private set; get; }

    private void Update() {
        if (Input.GetKey(KeyCode.E)) {
            hintImage.texture = buttonDown;
        } else {
            hintImage.texture = buttonUp;
        }

        if (Input.GetKeyUp(KeyCode.E) && hintOverlay.alpha == 1) {
            if (shopOverlay.alpha == 0) {
                StartCoroutine(TransitionRoutine(shopOverlay, 1));
                IsShopping = true;
            } else if (shopOverlay.alpha == 1) {
                StartCoroutine(TransitionRoutine(shopOverlay, 0));
                IsShopping = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        StartCoroutine(TransitionRoutine(hintOverlay, 1));
    }

    private void OnTriggerStay2D(Collider2D collision) {
        var flipShopkeeper = transform.position.x > collision.transform.position.x;

        foreach (var shopkeeperSpriteRenderer in shopkeeperSpriteRenderers) {
            shopkeeperSpriteRenderer.flipX = flipShopkeeper;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        StartCoroutine(TransitionRoutine(hintOverlay, 0));
    }

    private IEnumerator TransitionRoutine(CanvasGroup canvasGroup, float target) {
        for (var time = 1 - target; time != target; time = Mathf.MoveTowards(time, target, animationSpeed * Time.deltaTime)) {
            canvasGroup.alpha = time;
            yield return null;
        }

        canvasGroup.alpha = target;
    }

}
