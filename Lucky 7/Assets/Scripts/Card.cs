using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    [SerializeField] int number;
    [SerializeField] Sprite faceImage;

    public int Number { get => number;}
    public Sprite FaceImage { get => faceImage; }
}
