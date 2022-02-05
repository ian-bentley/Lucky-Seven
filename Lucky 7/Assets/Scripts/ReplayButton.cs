using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayButton : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] TableController tableController;

    public void Replay()
    {
        audioSource.Play();
        tableController.StartGame();
    }
}
