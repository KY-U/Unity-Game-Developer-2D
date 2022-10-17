using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    //sempre que colide com um objeto
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("puxa vida!");
    }

    //sempre que ativa um trigger
    void OnTriggerEnter2D(Collider2D other) {
       if(other.tag == "Package")
            Debug.Log("peguei a encomenda!");
       

       else if(other.tag == "Customer")
            Debug.Log("entreguei a encomenda");
    }
}