using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qundiocontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cubo; 
    public AudioClip audioclip;

    public void activarsonido () {
     
     AudioSource sonido = cubo.GetComponent<AudioSource> ();
     sonido.clip = audioclip;
     sonido.Play ();
    }
}
