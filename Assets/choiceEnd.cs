using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choiceEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public void killJohn()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Mort");
    }

    public void saveJohnn()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Pardon");
    }
}
