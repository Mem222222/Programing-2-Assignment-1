using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public float timer = 0;
    public float interval;

    private AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        interval = Random.Range(5f, 12.0f);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= interval)
        {
            audioSource.PlayOneShot(clip);
            interval = Random.Range(5f, 12.0f);
            timer = 0;
        }
    }
}
