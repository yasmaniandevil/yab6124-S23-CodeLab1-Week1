using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    //void doesnt return anything
    //changescene is the name of the function, building a function
    //will take a variable that is a string
    //use this script on any button
    //newScene is the variable
    
    public void ChangeScene(string newScene)
    {
        Debug.Log("ChangeScene Called with: + newScene");

        SceneManager.LoadScene(newScene);
    }
    
}
