﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Music : MonoBehaviour
{
    // code by Judge Russell 11 28 2020
    public GameObject katamari;
    private AudioSource[] tracks;
    private float old_size;
    // Start is called before the first frame update
    void Start()
    {
        old_size = 0.0f;
        tracks = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(katamari.transform.localScale.x >= 1 && old_size < 1)
        {
            FadeIn(1);
        }
        if(katamari.transform.localScale.x >= 10 && old_size < 10)
        {
            FadeIn(2);
        }
        if(katamari.transform.localScale.x >= 25 && old_size < 25)
        {
            FadeIn(3);
        }
        if(katamari.transform.localScale.x >= 100 && old_size < 100)
        {
            for(int i = 0; i < 4; i++)
            {
                FadeOut(i);
            }
            FadeIn(4);
        }
    
        old_size = katamari.transform.localScale.x;
    }

    public void FadeIn(int track)
    {
        StartCoroutine(Fade(tracks[track], 5.0f, 1.0f));
    }

    public void FadeOut(int track)
    {
        StartCoroutine(Fade(tracks[track], 5.0f, 0.0f));
    }

    IEnumerator Fade(AudioSource track, float duration, float level)
    {
        float currentTime = 0;
        float start = track.volume;

        while(currentTime < duration)
        {
            currentTime += Time.deltaTime;
            track.volume = Mathf.Lerp(start, level, currentTime / duration);
            yield return null;
        }
        yield break;
    }
}
