using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    [SerializeField] Card card;
    [SerializeField] Image image;

    bool isFlipped;

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
        image.sprite = card.FaceImage;
        isFlipped = true;
    }
}
