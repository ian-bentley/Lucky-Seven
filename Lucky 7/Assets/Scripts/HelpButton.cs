using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButton : MonoBehaviour
{
    public void CallLoadHelpScreen()
    {
        StartCoroutine(LoadHelpScreen());
    }

    IEnumerator LoadHelpScreen()
    {
        AudioSource helpButtonAudio = GetComponent<AudioSource>();
        helpButtonAudio.Play();
        yield return new WaitUntil(() => helpButtonAudio.isPlaying == false);
        SceneManager.LoadScene("Help Screen");
    }
}
