using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dealer : MonoBehaviour
{
    public Card oneCard;
    public Card twoCard;
    public Card threeCard;
    public Card fourCard;
    public Card fiveCard;
    public Card sixCard;
    public Card sevenCard;
    public CardDisplay card1;
    public CardDisplay card2;
    public CardDisplay card3;
    public CardDisplay card4;
    public CardDisplay card5;
    public CardDisplay card6;
    public CardDisplay card7;

    void Start()
    {
        Shuffle();
    }

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
        card1.card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card2.card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card3.card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card4.card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card5.card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card6.card = GetCard(cardNumbers[randIndex]);
        cardNumbers.RemoveAt(randIndex);

        randIndex = Random.Range(0, cardNumbers.Count);
        card7.card = GetCard(cardNumbers[randIndex]);
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
