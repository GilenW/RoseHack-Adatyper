using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip rightSound, wrongSound;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rightSound = Resources.Load<AudioClip>("rightSound");
        wrongSound = Resources.Load<AudioClip>("wrongSound");

        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void playSound (string clip)
    {
        switch(clip){
            case "right":
                audioSource.PlayOneShot(rightSound);
                break;
            case "wrong":
                audioSource.PlayOneShot(wrongSound);
                break;
        }
    }
}
