using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class hit : MonoBehaviour
{
   

    public Animator  animator;
    void Start()
    {
        animator.enabled = false;
  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name=="ball")
        {
           animator.enabled = true;
    
        }
   }
   private void OnCollisionExit (Collision collision)
   {
        if (collision.collider.name == "ball")
       {
          animator.enabled = false;
          
      }
    }
}
