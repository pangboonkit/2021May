using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    private Animator anim=null;
   [SerializeField] private AudioSource soundSource;
   [SerializeField] private AudioClip DoorSound;
 
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim.SetBool("touch", true);
            soundSource.PlayOneShot(DoorSound);
        }   
          
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim.SetBool("touch", false);
            soundSource.PlayOneShot(DoorSound);
        }  
    }
}
