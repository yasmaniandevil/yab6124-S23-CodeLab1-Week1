using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementX : MonoBehaviour
{
    //how fast the obj moves
    public float speed = 2;
    
    //the initial position
    private Vector3 initialPos;
    
    
    private Transform cachedTransform;
    
    //create a public var i can change in inspector to reset the position
    public int resetPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        /*i worked on this script winter break and
        am adding to it for homework but I am not sure if i get this entirely, 
        i did like a month ago?*/
        cachedTransform = transform;
        initialPos = cachedTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        newPos.x += speed * Time.deltaTime;

        transform.position = newPos;

        if (cachedTransform.position.x >= resetPosition)
        {
            cachedTransform.position = initialPos;
        }
    }
}
