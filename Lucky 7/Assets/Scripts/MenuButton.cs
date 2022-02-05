using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void CallLoadMainMenu()
    {
        StartCoroutine(LoadMainMenu());
    }

    IEnumerator LoadMainMenu()
    {
        AudioSource menuButtonAudio = GetComponent<AudioSource>();
        menuButtonAudio.Play();
        yield return new WaitUntil(() => menuButtonAudio.isPlaying == false);
        SceneManager.LoadScene("Main Menu");
    }
}
