using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementZ : MonoBehaviour
{

    public float speed = 2;
    
    //the initial position
    private Vector3 initialPos;
    
    //the current position
    private Transform cachedTransform;

    public int resetPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        cachedTransform = transform;
        initialPos = cachedTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        newPos.z += speed * Time.deltaTime;

        transform.position = newPos;

        if (cachedTransform.position.z >= resetPosition)
        {
            cachedTransform.position = initialPos;
        }
    }
}
