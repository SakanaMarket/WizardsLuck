using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Self : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
}
