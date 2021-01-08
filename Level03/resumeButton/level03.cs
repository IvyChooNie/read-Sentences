using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level03 : MonoBehaviour
{
    public void load()
    {
        switch (this.gameObject.name)
        {
            case "rsb00":
                SceneManager.LoadScene("q001");
                break;

            case "rsb01":
                SceneManager.LoadScene("q002");
                break;

            case "rsb02":
                SceneManager.LoadScene("q003");
                break;

            case "rsb03":
                SceneManager.LoadScene("q004");
                break;

            case "rsb04":
                SceneManager.LoadScene("q005");
                break;

            case "rsb05":
                SceneManager.LoadScene("q006");
                break;

            case "rsb06":
                SceneManager.LoadScene("q007");
                break;
        }
    }
}
