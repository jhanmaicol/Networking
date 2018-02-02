using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : Photon.MonoBehaviour {

    public Animator Anim;
    public float WalkSpeed;

    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            if (photonView.isMine)
            {
                Anim.SetBool("Walk", true);
                transform.Translate(Vector3.forward * WalkSpeed * Time.deltaTime);
            }
        }
        else
        {
            
                Anim.SetBool("Walk", false);
            
        }        
        
    }
   /* void FixedUpdate () {

         float h = Input.GetAxis("Vertical");

         if (photonView.isMine)
         {

            
            Anim.SetFloat("Walk", h);
         }

     } */
}
