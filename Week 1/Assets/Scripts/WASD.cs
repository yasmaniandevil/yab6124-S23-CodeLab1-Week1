using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class WASD : MonoBehaviour
{
    //make a public float for speed of player
    public float forceAmount = 0;
    
    //make a variable for rigidbody
    Rigidbody rb;
    
    //initial position of player
    private Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
        //gets rigidbody from the component and assigning it to the rb variable i made
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            //take the variable rb (rigidbody) and add force to it
            rb.AddForce(0, 0, -forceAmount);
            Debug.Log(transform.position.z);
            Debug.Log("W was pressed");
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0,0,forceAmount);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(forceAmount, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-forceAmount, 0, 0);
        }
        
    }
}
