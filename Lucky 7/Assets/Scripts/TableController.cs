using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState { Playing, Won, Lost }

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
    [SerializeField] GameOverController gameOverController;
    [SerializeField] GameObject discardSlot;

    CardController nextCard;
    bool firstCardWasFlipped;
    GameState gameState;
    int discardPileSize;

    public GameState GameState
    {
        get => gameState;
    }

    void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        firstCardWasFlipped = false;
        gameState = GameState.Playing;
        discardPileSize = 0;

        gameOverController.GetComponent<Canvas>().enabled = false;
        LockAllCards();
        StartCoroutine(dealer.SetBoard());
        UnlockAllCards();
    }

    public void LockAllCards()
    {
        card1.IsClickable = false;
        card2.IsClickable = false;
        card3.IsClickable = false;
        card4.IsClickable = false;
        card5.IsClickable = false;
        card6.IsClickable = false;
        card7.IsClickable = false;
    }

    public void UnlockAllCards()
    {
        card1.IsClickable = true;
        card2.IsClickable = true;
        card3.IsClickable = true;
        card4.IsClickable = true;
        card5.IsClickable = true;
        card6.IsClickable = true;
        card7.IsClickable = true;
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

        if (nextCard.IsFlipped)
        {
            if (AllCardsAreFlipped())
            {
                gameState = GameState.Won;
            }
            else
            {
                gameState = GameState.Lost;
            }
            gameOverController.GameOver();
        }
        else
        {
            UnlockNextCard();
        }
    }

    public void UnlockNextCard()
    {
        nextCard.IsClickable = true;
    }
    
    public void SelectCard(CardController selectedCard)
    {
        selectedCard.Flip();
        Discard(selectedCard);
        LockAllCards();
        if (firstCardWasFlipped)
        {
            SetNextCard(nextCard.Card.Number);
        }
        else
        {
            SetNextCard(selectedCard.Card.Number);
            firstCardWasFlipped = true;
        }
    }

    bool AllCardsAreFlipped()
    {
        if (card1.IsFlipped && card2.IsFlipped && card3.IsFlipped && card4.IsFlipped && card5.IsFlipped && card6.IsFlipped && card7.IsFlipped)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Discard(CardController card)
    {
        card.transform.position = discardSlot.transform.position;
        discardPileSize++;
        card.GetComponent<SpriteRenderer>().sortingOrder = discardPileSize;
    }
}
