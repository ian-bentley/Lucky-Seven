using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Image image;

    public int PositionNumber { set; get; }
    public bool Flipped { private set; get; }

    public void Flip()
    {
        image.sprite = card.faceImage;
        Flipped = true;
    }
}
