using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableController : MonoBehaviour
{
    [SerializeField] CardController card1;
    [SerializeField] CardController card2;
    [SerializeField] CardController card3;
    [SerializeField] CardController card4;
    [SerializeField] CardController card5;
    [SerializeField] CardController card6;
    [SerializeField] CardController card7;
    [SerializeField] Dealer dealer;

    CardController nextCard;
    bool firstCardWasFlipped = false;

    void Start()
    {
        LockAllCards();
        dealer.Shuffle();
        UnlockAllCards();
    }

    public void LockAllCards()
    {
        card1.GetComponent<Button>().interactable = false;
        card2.GetComponent<Button>().interactable = false;
        card3.GetComponent<Button>().interactable = false;
        card4.GetComponent<Button>().interactable = false;
        card5.GetComponent<Button>().interactable = false;
        card6.GetComponent<Button>().interactable = false;
        card7.GetComponent<Button>().interactable = false;
    }

    public void UnlockAllCards()
    {
        card1.GetComponent<Button>().interactable = true;
        card2.GetComponent<Button>().interactable = true;
        card3.GetComponent<Button>().interactable = true;
        card4.GetComponent<Button>().interactable = true;
        card5.GetComponent<Button>().interactable = true;
        card6.GetComponent<Button>().interactable = true;
        card7.GetComponent<Button>().interactable = true;
    }

    public void SetNextCard(int nextCardPosition)
    {
        switch (nextCardPosition)
        {
            case 1:
                nextCard = card1;
                break;
            case 2:
                nextCard = card2;
                break;
            case 3:
                nextCard = card3;
                break;
            case 4:
                nextCard = card4;
                break;
            case 5:
                nextCard = card5;
                break;
            case 6:
                nextCard = card6;
                break;
            case 7:
                nextCard = card7;
                break;
        }
    }

    public void UnlockNextCard()
    {
        nextCard.GetComponent<Button>().interactable = true;
    }

    public void SelectCard1()
    {
        if (card1.IsFlipped)
        {

        }
        else
        {
            card1.Flip();
            LockAllCards();
            if (firstCardWasFlipped)
            {
                SetNextCard(nextCard.Card.Number);
            }
            else
            {
                SetNextCard(card1.Card.Number);
                firstCardWasFlipped = true;
            }
            UnlockNextCard();
        }
    }

    public void SelectCard2()
    {
        if (card2.IsFlipped)
        {

        }
        else
        {
            card2.Flip();
            LockAllCards();
            if (firstCardWasFlipped)
            {
                SetNextCard(nextCard.Card.Number);
            }
            else
            {
                SetNextCard(card2.Card.Number);
                firstCardWasFlipped = true;
            }
            UnlockNextCard();
        }
    }

    public void SelectCard3()
    {
        if (card3.IsFlipped)
        {

        }
        else
        {
            card3.Flip();
            LockAllCards();
            if (firstCardWasFlipped)
            {
                SetNextCard(nextCard.Card.Number);
            }
            else
            {
                SetNextCard(card3.Card.Number);
                firstCardWasFlipped = true;
            }
            UnlockNextCard();
        }
    }

    public void SelectCard4()
    {
        if (card4.IsFlipped)
        {

        }
        else
        {
            card4.Flip();
            LockAllCards();
            if (firstCardWasFlipped)
            {
                SetNextCard(nextCard.Card.Number);
            }
            else
            {
                SetNextCard(card4.Card.Number);
                firstCardWasFlipped = true;
            }
            UnlockNextCard();
        }
    }

    public void SelectCard5()
    {
        if (card5.IsFlipped)
        {

        }
        else
        {
            card5.Flip();
            LockAllCards();
            if (firstCardWasFlipped)
            {
                SetNextCard(nextCard.Card.Number);
            }
            else
            {
                SetNextCard(card5.Card.Number);
                firstCardWasFlipped = true;
            }
            UnlockNextCard();
        }
    }

    public void SelectCard6()
    {
        if (card6.IsFlipped)
        {

        }
        else
        {
            card6.Flip();
            LockAllCards();
            if (firstCardWasFlipped)
            {
                SetNextCard(nextCard.Card.Number);
            }
            else
            {
                SetNextCard(card6.Card.Number);
                firstCardWasFlipped = true;
            }
            UnlockNextCard();
        }
    }

    public void SelectCard7()
    {
        if (card7.IsFlipped)
        {

        }
        else
        {
            card7.Flip();
            LockAllCards();
            if (firstCardWasFlipped)
            {
                SetNextCard(nextCard.Card.Number);
            }
            else
            {
                SetNextCard(card7.Card.Number);
                firstCardWasFlipped = true;
            }
            UnlockNextCard();
        }
    }
}
