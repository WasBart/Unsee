using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{
    public bool levelCleared = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown((KeyCode.W)))
        {
            if(levelCleared)
            {
                SceneManager.LoadScene("PenguinScene");
            }
        }       
    }

    public void LoadLevel()
    {
        StartCoroutine(DelayLevelLoading());
    }

    IEnumerator DelayLevelLoading()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("PenguinScene");
    }
}
