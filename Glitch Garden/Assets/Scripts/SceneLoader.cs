using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int currentScene;
    float timeToWait = 10F;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentScene == 0) {
            StartCoroutine(WaitAndLoadNextScene());
        }   
    }

    IEnumerator WaitAndLoadNextScene() {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(currentScene + 1);
    }
}
