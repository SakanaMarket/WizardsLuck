using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
    public void back_to_instructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
