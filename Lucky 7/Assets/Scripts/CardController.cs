using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    [SerializeField] Card card;
    [SerializeField] Image image;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] AudioSource audioSource;
    [SerializeField] TableController tableController;

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

    public Image Image
    {
        get => image;
        set => image = value;
    }

    public bool IsFlipped
    {
        get => isFlipped;
    }

    public void Flip()
    {
        //image.sprite = card.FaceImage;
        spriteRenderer.sprite = card.FaceImage;
        audioSource.Play();
        isFlipped = true;
    }

    void OnMouseDown()
    {
        if (isClickable) tableController.SelectCard(this);
    }
}
