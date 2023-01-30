using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{
    //create text mesh pro public variable
    public TextMeshProUGUI scoreText;
    //score starts at 0
    private int score = 0;

    public AudioClip clip;
    
    //create a function for when the player collides with coins
    void OnTriggerEnter(Collider other)
    {
        //when it enters the trigger of the coins destroy the coins and add +1 to the score
        Destroy(other.gameObject);
        score++;
        //change text
        scoreText.text = "Score: " + score.ToString();
        AudioSource.PlayClipAtPoint(clip,transform.position);
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
