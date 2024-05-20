using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;
    public AudioClip clip;
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("PlayerProximity");
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("PlayerProximity");
    }

    
}
