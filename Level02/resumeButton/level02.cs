using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level02 : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "resume00":
                SceneManager.LoadScene("q01");
                break;

            case "resume01":
                SceneManager.LoadScene("q02");
                break;

            case "resume02":
                SceneManager.LoadScene("q03");
                break;

            case "resume03":
                SceneManager.LoadScene("q04");
                break;

            case "resume04":
                SceneManager.LoadScene("q05");
                break;

            case "resume05":
                SceneManager.LoadScene("q6");
                break;
        }
    }
}
