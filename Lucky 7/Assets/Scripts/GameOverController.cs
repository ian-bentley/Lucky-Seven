using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    [SerializeField] TableController tableController;
    [SerializeField] Image winPlaque;
    [SerializeField] Image losePlaque;
    [SerializeField] AudioClip winSFX;
    [SerializeField] AudioClip loseSFX;
    [SerializeField] AudioSource audioSource;

    public void GameOver()
    {
        winPlaque.enabled = false;
        losePlaque.enabled = false;
        if (tableController.GameState == GameState.Won)
        {
            audioSource.clip = winSFX;
        }
        else if (tableController.GameState == GameState.Lost)
        {
            audioSource.clip = loseSFX;
        }
        audioSource.Play();
        Invoke("DisplayGameOverScreen", 1f);
    }

    void DisplayGameOverScreen()
    {
        GetComponent<Canvas>().enabled = true;
        if (tableController.GameState == GameState.Won)
        {
            winPlaque.enabled = true;
        }
        else if (tableController.GameState == GameState.Lost)
        {
            losePlaque.enabled = true;
        }
    }
}
