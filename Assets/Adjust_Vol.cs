using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adjust_Vol : MonoBehaviour
{
    [SerializeField] private AudioSource audio_source;
    [SerializeField] private float music_volume = 1f;
    [SerializeField] private Slider s;
    void Start()
    {
        audio_source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(music_volume);
        audio_source.volume = music_volume;
    }

    public void AdjustVolume()
    {
        float volume_level = s.value;
        music_volume = volume_level;
    }
}
