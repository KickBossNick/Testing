using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlpoint : MonoBehaviour
{

    public LineRenderer line;
    float xRotation = 0f;
    float yRotation = 0f;
    public float Rotationspeed = 5f;
    public Rigidbody BallsRb;
   // public float MinSHOOTPOWER;
    public float MaxSHOOTPOWER;
    // Update is called once per frame
    void Update()
    {
        transform.position = BallsRb.position;
        if (Input.GetMouseButton(0))
        {
            xRotation += Input.GetAxis("Mouse x") * Rotationspeed;
            yRotation += Input.GetAxis("Mouse y") * Rotationspeed;
            if (yRotation<15)
            {
               yRotation = 15;
           }
            transform.rotation = Quaternion.Euler(yRotation, xRotation, 0f);
            line.gameObject.SetActive(true);
            line.SetPosition(0, transform.position);
            line.SetPosition(1,  transform.position+transform.forward * 10f);
        }

       if (Input.GetMouseButtonUp(0))
        {
            BallsRb.velocity = transform.forward * MaxSHOOTPOWER;
            line.gameObject.SetActive(false);
        }
    }
   // private void OnMouseDrag()
   // {
   //     Vector3 Newposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
  //  BallsRb.position = Newposition;
   // }
}