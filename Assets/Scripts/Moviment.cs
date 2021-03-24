using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
  public GameObject esfera;
  public Rigidbody rb;


 // Start is called before the first frame update
 void Start()
 {
     rb = gameObject.GetComponent<Rigidbody>();

 }

 // Update is called once per frame
 void Update()
 {
     Vector3 vel = Vector3.zero;
     int numV = 0;
     int direccio = 0;
     if (Input.GetKey(KeyCode.W)){
         numV = 1;
         direccio = 0;
         vel = vel +  new Vector3(direccio,0,numV);
     }
     if (Input.GetKey(KeyCode.S)){
         vel = vel + Vector3.back;
     }
     if (Input.GetKey(KeyCode.A)){
         direccio = 1;
         numV = 0;

         vel = vel - new Vector3(direccio,0,numV);
     }
     if (Input.GetKey(KeyCode.D)){
         direccio = -1;
         numV = 0;
         vel = vel - new Vector3(direccio,0,numV);
     }

      if(Input.GetKey(KeyCode.Space) ){
            
          rb.AddForce(Vector3.up*10); 
      } 

     gameObject.transform.position+=vel;

 }
}

