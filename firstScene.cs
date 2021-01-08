using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstScene : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "Back":
                SceneManager.LoadScene("a-zScene");
                break;
        }

        switch (this.gameObject.name)
        {
            case "Back01":
                SceneManager.LoadScene("firstScene");
                break;

            case "consonants":
                SceneManager.LoadScene("consonant");
                break;

            case "vowels":
                SceneManager.LoadScene("vowel");
                break;

            case "ResumeToAbc":
                SceneManager.LoadScene("a-zScene");
                break;

            case "goToQue":
                SceneManager.LoadScene("MainMenu");
                break;

            case "backToFirstScene":
                SceneManager.LoadScene("firstScene");
                break;
        }
    }
}
