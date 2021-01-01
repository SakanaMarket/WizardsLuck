using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Resolution : MonoBehaviour
{
    public void FullScreen()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public void Windowed()
    {
        Screen.SetResolution(1440, 900, false);
    }
}
