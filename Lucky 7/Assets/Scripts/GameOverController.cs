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

    void Start()
    {
        winPlaque.enabled = false;
        losePlaque.enabled = false;
        this.gameObject.SetActive(false);
    }

    void OnEnable()
    {
        if (tableController.GameState == GameState.Won)
        {
            winPlaque.enabled = true;
            audioSource.clip = winSFX;
        }
        else if (tableController.GameState == GameState.Lost)
        {
            losePlaque.enabled = true;
            audioSource.clip = loseSFX;
        }
        audioSource.Play();
    }
}
