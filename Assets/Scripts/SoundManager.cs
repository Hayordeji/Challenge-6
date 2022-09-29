using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
  public AudioSource[] sounds;

    // Start is called before the first frame update
    void Start()
    {
      sounds[0].Play();  
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
