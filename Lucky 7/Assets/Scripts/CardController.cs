using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    [SerializeField] Card card;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TableController tableController;
    [SerializeField] Sprite backImage;

    bool isFlipped;
    bool isClickable;

    public bool IsClickable
    {
        get => isClickable;
        set => isClickable = value;
    }

    public Card Card
    {
        get => card;
        set => card = value;
    }

    public bool IsFlipped
    {
        get => isFlipped;
    }

    public void Flip()
    {
        spriteRenderer.sprite = card.FaceImage;
        audioSource.Play();
        isFlipped = true;
    }

    void OnMouseDown()
    {
        if (isClickable) tableController.SelectCard(this);
    }

    public void Reset()
    {
        isFlipped = false;
        isClickable = false;
        card = null;
        spriteRenderer.sprite = backImage;
    }
}
