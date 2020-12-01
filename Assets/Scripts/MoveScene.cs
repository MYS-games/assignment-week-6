using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    string level1 = "Level1";
    string level2 = "Level2";
    string level3 = "Level3";
    string level4 = "Level4";



    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Pig").Length == 0)
        {
            if (SceneManager.GetActiveScene().name == level1)
            {
                    SceneManager.LoadSceneAsync(level2);
            }
            else if (SceneManager.GetActiveScene().name == level2)
            {
                    SceneManager.LoadSceneAsync(level3);
            }
            else if (SceneManager.GetActiveScene().name == level3)
            {
                    SceneManager.LoadSceneAsync(level4);
            }
        }
    }


}
