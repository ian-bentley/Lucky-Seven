using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayButton : MonoBehaviour
{
    [SerializeField] TableController tableController;

    public void CallReplay()
    {
        StartCoroutine(Replay());
    }

    IEnumerator Replay()
    {
        AudioSource replayButtonAudio = GetComponent<AudioSource>();
        replayButtonAudio.Play();
        yield return new WaitUntil(() => replayButtonAudio.isPlaying == false);
        tableController.StartGame();
    }
}
