using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Golds : MonoBehaviour

{
 
    public ParticleSystem catchcoin;

   private void OnTriggerEnter(Collider other)
    {
       Playerstore.scoretext += 50;
       if (other.CompareTag("ball"))
       {
            DestroyCoin();
        }
    }

    //private void OnCollisionEnter(Collision collision)
   // {
       ///if (collision.collider.name=="ball")
       // {

          //  DestroyCoin();
       // }
       // Playerstore.scoretext += 50;
   // }

    public void DestroyCoin()
    {
        Instantiate(catchcoin, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
