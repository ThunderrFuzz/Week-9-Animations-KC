using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Animator anim;
   
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("SunDown");
      
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("SunUp");
    }


}
