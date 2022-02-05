using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void CallStartGame()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        AudioSource startButtonAudio = GetComponent<AudioSource>();
        startButtonAudio.Play();
        yield return new WaitUntil(() => startButtonAudio.isPlaying == false);
        SceneManager.LoadScene("Game");
    }
}
