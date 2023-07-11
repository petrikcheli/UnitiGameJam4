using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValue : MonoBehaviour
{
    private AudioSource audioSource;
    private float volume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = volume;
    }
    public void SetVolume(float volume)
    {
        this.volume = volume;
    }
}
