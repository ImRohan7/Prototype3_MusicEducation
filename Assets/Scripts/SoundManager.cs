﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioClip clip_C4, clip_D4, clip_E4, clip_F4, clip_G4, clip_A4, clip_B4, clip_C5;

    public AudioSource S1, S2;

    GameSession s1;

    // Use this for initialization
    void Start () {
        s1 = FindObjectOfType<GameSession>();
     
    }

	// Update is called once per frame
	void Update () {
		
	}

   public void PlaySingleKey(string key)
    {
        string keyCode = key;

        switch (keyCode)
        {
            case "C4":
                S1.clip = clip_C4;
                break;
            case "D4":
                S1.clip = clip_D4;
                break;
            case "E4":
                S1.clip = clip_E4;
                break;
            case "F4":
                S1.clip = clip_F4;
                break;
            case "G4":
                S1.clip = clip_G4;
                break;
            case "A4":
                S1.clip = clip_A4;
                break;
            case "B4":
                S1.clip = clip_B4;
                break;
            case "C5":
                S1.clip = clip_C5;
                break;

        }
      //  StartCoroutine(playEngineSound());
     
        S1.Play();


    }

    public void PlayOriginal() {
        //Check level here
        Debug.Log(s1.level);
        if (s1.level == 1)
        {
            S1.clip = clip_C4;
            S2.clip = clip_C4;
          
            S1.Play();
            S2.PlayDelayed(S1.clip.length - 1);
        }
    }

    IEnumerator playEngineSound() {
        
            S1.Play();

            yield return new WaitForSeconds(S1.clip.length);
            S1.clip = clip_D4;
            S1.Play();
        }
    }

