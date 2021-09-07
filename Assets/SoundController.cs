using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sounds;
    public GameObject GOCubo; 
       
    
    public void reproducirClips (){
      AudioSource sonido = GOCubo.GetComponent<AudioSource>();
      sonido.clip = sounds;
      sonido.Play ();
    }
}
