using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dealer : MonoBehaviour
{
    [SerializeField] Card oneCard;
    [SerializeField] Card twoCard;
    [SerializeField] Card threeCard;
    [SerializeField] Card fourCard;
    [SerializeField] Card fiveCard;
    [SerializeField] Card sixCard;
    [SerializeField] Card sevenCard;
    [SerializeField] CardController card1;
    [SerializeField] CardController card2;
    [SerializeField] CardController card3;
    [SerializeField] CardController card4;
    [SerializeField] CardController card5;
    [SerializeField] CardController card6;
    [SerializeField] CardController card7;

    public void Shuffle()
    {
        List<int> cardNumbers = new List<int>();
        cardNumbers.Add(1);
        cardNumbers.Add(2);
        cardNumbers.Add(3);
        cardNumbers.Add(4);
        cardNumbers.Add(5);
        cardNumbers.Add(6);
        cardNumbers.Add(7);

        int randIndex = Random.Range(0, cardNumbers.Count);
        card1.Card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card2.Card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card3.Card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card4.Card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card5.Card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card6.Card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card7.Card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);
    }

    Card GetCard(int value)
    {
        switch (value)
        {
            case 1:
                return oneCard;
            case 2:
                return twoCard;
            case 3:
                return threeCard;
            case 4:
                return fourCard;
            case 5:
                return fiveCard;
            case 6:
                return sixCard;
            case 7:
                return sevenCard;
            default:
                return null;
        }
    }
}
