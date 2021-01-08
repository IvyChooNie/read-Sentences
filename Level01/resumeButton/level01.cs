using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level01 : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "rb00":
                SceneManager.LoadScene("tutorial01");
                break;

            case "rb01":
                SceneManager.LoadScene("tutorial2");
                break;

            case "rb02":
                SceneManager.LoadScene("tutorial3");
                break;

            case "rb03":
                SceneManager.LoadScene("tutorial4");
                break;

            case "rb04":
                SceneManager.LoadScene("tutorial5");
                break;

            case "rb05":
                SceneManager.LoadScene("tutorial6");
                break;

            case "rb06":
                SceneManager.LoadScene("tutorial7");
                break;

            case "rb07":
                SceneManager.LoadScene("tutorial8");
                break;

            case "rb08":
                SceneManager.LoadScene("tutorial9");
                break;

            case "rb09":
                SceneManager.LoadScene("tutorial10");
                break;

            case "level01":
                SceneManager.LoadScene("montage01");
                break;

            case "level02":
                SceneManager.LoadScene("montage02");
                break;

            case "level03":
                SceneManager.LoadScene("montage03");
                break;
        }
    }
}
