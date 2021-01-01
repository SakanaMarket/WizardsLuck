using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField] private GameObject main_canvas;
    [SerializeField] private GameObject credit_canvas;

    public void credit_to_main()
    {
        credit_canvas.SetActive(false);
        main_canvas.SetActive(true);
    }
    public void main_to_credit()
    {
        main_canvas.SetActive(false);
        credit_canvas.SetActive(true);
    }

}
