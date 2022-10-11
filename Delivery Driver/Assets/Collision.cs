using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //sempre que colide com um objeto
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("puxa vida!");
    }

    //sempre que ativa um trigger
    void OnTriggerEnter2D(Collider2D other) {
       Debug.Log("eita glória!"); 
    }
}