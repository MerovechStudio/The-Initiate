using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxController : MonoBehaviour
{

    public void CastSound () {

        var audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
    
}
