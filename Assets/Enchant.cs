using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enchant : MonoBehaviour
{
    public void start_enchant()
    {
        SceneManager.LoadScene("scroll");
    }

    public void quit()
    {
        Application.Quit();
    }
}
