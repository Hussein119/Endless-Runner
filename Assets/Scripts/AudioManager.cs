﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;
	void Start () {
		foreach (Sound s in sounds) {
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

		}
		PlaySound("MainTheme");
	}
	public void PlaySound(string name)
    {
		foreach (Sound s in sounds)
		{
			if(s.name == name)
            {
				s.source.Play();
            }

		}
	}
   // Update is called once per frame

    void Update()
    {
        if (PlayerManager.gameOver)
        {
            // stop the sounds
            StopAllSounds("MainTheme");
        }
    }

    private void StopAllSounds(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == name)
                s.source.Stop();
        }
    }

}