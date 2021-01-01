using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_path : MonoBehaviour
{
    [SerializeField] RectTransform clouds;
    [SerializeField] float cloud_speed = 50;

    void FixedUpdate()
    {
        if (clouds.localPosition.x < -1835)
        {
            clouds.localPosition = new Vector3(1836f, clouds.localPosition.y, clouds.localPosition.z);
        }
        clouds.localPosition += new Vector3(-cloud_speed * Time.deltaTime, 0f, 0f);
        //Debug.Log(clouds.localPosition);
    }
}
