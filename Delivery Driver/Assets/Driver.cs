using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] int steerSpeed = 325; 
    [SerializeField] int moveSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input de direção e sentido
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

       //ajustes de direção
       if(moveAmount >= 0)
            steerAmount = -steerAmount;
        transform.Rotate(0, 0, steerAmount);

        //translação vertical
        transform.Translate(0, moveAmount, 0);
    }
}
