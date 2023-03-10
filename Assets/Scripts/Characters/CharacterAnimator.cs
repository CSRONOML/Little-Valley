using Mono.Cecil.Cil;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour {

    [Header("Settings")]
    [SerializeField] private float speed;

    [Header("References")]
    [SerializeField] private CharacterController2D characterController2D;

    [Header("Sprite Renderers")]
    [SerializeField] private SpriteRenderer bodyRenderer;
    [SerializeField] private SpriteRenderer hairRenderer;
    [SerializeField] private SpriteRenderer shirtRenderer;
    [SerializeField] private SpriteRenderer pantsRenderer;
    [SerializeField] private SpriteRenderer shoesRenderer;

    [Header("Animations")]
    [SerializeField] private PlayerVariationScriptableObject bodyVariation;
    [SerializeField] private PlayerVariationScriptableObject hairVariation;
    [SerializeField] private PlayerVariationScriptableObject pantsVariation;
    [SerializeField] private PlayerVariationScriptableObject shirtVariation;
    [SerializeField] private PlayerVariationScriptableObject shoesVariation;

    private float animationTime;
    private PlayerVariationScriptableObject defaultBodyVariation;
    private PlayerVariationScriptableObject defaultHairVariation;
    private PlayerVariationScriptableObject defaultPantsVariation;
    private PlayerVariationScriptableObject defaultShirtVariation;
    private PlayerVariationScriptableObject defaultShoesVariation;

    private void Awake() {
        defaultBodyVariation = bodyVariation;
        defaultHairVariation = hairVariation;
        defaultPantsVariation = pantsVariation;
        defaultShirtVariation = shirtVariation;
        defaultShoesVariation = shoesVariation;
    }

    private void Update() {
        if (characterController2D.Stopping) {
            animationTime = 0;
        } else {
            animationTime += speed * Time.deltaTime;
        }

        if (animationTime > bodyVariation.walkAnimation.Length) {
            animationTime -= bodyVariation.walkAnimation.Length;
        }

        SetAnimationsIndex((int) animationTime);
        UpdateSpritesDirection();
    }

    private void SetAnimationsIndex(int animationIndex) {
        bodyRenderer.sprite = bodyVariation.walkAnimation[animationIndex];
        hairRenderer.sprite = hairVariation.walkAnimation[animationIndex];
        shirtRenderer.sprite = shirtVariation.walkAnimation[animationIndex];
        pantsRenderer.sprite = pantsVariation.walkAnimation[animationIndex];
        shoesRenderer.sprite = shoesVariation.walkAnimation[animationIndex];
    }

    private void UpdateSpritesDirection() {
        bodyRenderer.flipX = characterController2D.LastVelocityWasNegative;
        hairRenderer.flipX = characterController2D.LastVelocityWasNegative;
        shirtRenderer.flipX = characterController2D.LastVelocityWasNegative;
        pantsRenderer.flipX = characterController2D.LastVelocityWasNegative;
        shoesRenderer.flipX = characterController2D.LastVelocityWasNegative;
    }

    public void SetPlayerVariation(PlayerVariationScriptableObject variation) {
        switch (variation.type) {
            case PlayerVariationType.PANTS:
                pantsVariation = variation;
                break;
            case PlayerVariationType.SHIRT:
                shirtVariation = variation;
                break;
            case PlayerVariationType.SHOES:
                shoesVariation = variation;
                break;
        }
    }

    public void ResetPlayerVariation(PlayerVariationScriptableObject variation) {
        switch (variation.type) {
            case PlayerVariationType.PANTS:
                if (pantsVariation == variation) pantsVariation = defaultPantsVariation;
                break;
            case PlayerVariationType.SHIRT:
                if (shirtVariation == variation) shirtVariation = defaultShirtVariation;
                break;
            case PlayerVariationType.SHOES:
                if (shoesVariation == variation) shoesVariation = defaultShoesVariation;
                break;
        }
    }

}
