using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLetter : MonoBehaviour
{
    public string LevelToLoad;


    private void Update()

    {
        PlayGame();

    }

    public void PlayGame()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene(LevelToLoad);

        }
    }

}

