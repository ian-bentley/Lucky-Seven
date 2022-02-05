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
    [SerializeField] GameObject deckSlot;
    [SerializeField] GameObject card1Slot;
    [SerializeField] GameObject card2Slot;
    [SerializeField] GameObject card3Slot;
    [SerializeField] GameObject card4Slot;
    [SerializeField] GameObject card5Slot;
    [SerializeField] GameObject card6Slot;
    [SerializeField] GameObject card7Slot;
    [SerializeField] AudioSource deckAudio;
    [SerializeField] AudioClip shuffleSFX;

    bool isBoardSet;

    public bool IsBoardSet
    {
        get => isBoardSet;
    }

    public IEnumerator SetBoard()
    {
        CreateDeck();
        Shuffle();
        yield return new WaitUntil(() => deckAudio.isPlaying == false);
        StartCoroutine(Deal());
    }

    void CreateDeck()
    {
        isBoardSet = false;

        card1.Reset();
        card2.Reset();
        card3.Reset();
        card4.Reset();
        card5.Reset();
        card6.Reset();
        card7.Reset();

        card1.transform.position = deckSlot.transform.position;
        card2.transform.position = deckSlot.transform.position;
        card3.transform.position = deckSlot.transform.position;
        card4.transform.position = deckSlot.transform.position;
        card5.transform.position = deckSlot.transform.position;
        card6.transform.position = deckSlot.transform.position;
        card7.transform.position = deckSlot.transform.position;
    }

    void Shuffle()
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

        deckAudio.clip = shuffleSFX;
        deckAudio.Play();
    }

    IEnumerator Deal()
    {
        yield return new WaitForSeconds(0.1f);
        card1.transform.position = card1Slot.transform.position;
        card1.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.1f);
        card2.transform.position = card2Slot.transform.position;
        card2.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.1f);
        card3.transform.position = card3Slot.transform.position;
        card3.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.1f);
        card4.transform.position = card4Slot.transform.position;
        card4.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.1f);
        card5.transform.position = card5Slot.transform.position;
        card5.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.1f);
        card6.transform.position = card6Slot.transform.position;
        card6.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.1f);
        card7.transform.position = card7Slot.transform.position;
        card7.GetComponent<AudioSource>().Play();

        isBoardSet = true;
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
