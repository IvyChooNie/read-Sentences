using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "level01":
                SceneManager.LoadScene("tutorial01");
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
