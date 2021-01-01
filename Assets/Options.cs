using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    [SerializeField] private GameObject main_canvas;
    [SerializeField] private GameObject menu_canvas;
    public void main_to_options()
    {
        main_canvas.SetActive(false);
        menu_canvas.SetActive(true);
    }
    public void options_to_main()
    {
        main_canvas.SetActive(true);
        menu_canvas.SetActive(false);

    }
}
