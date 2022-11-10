using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalBehavior : MonoBehaviour
{
    public GameObject player;
    public GameObject endParticles;
    public GameObject levelManager;
    private LoadLevel2 ll2;
    // Start is called before the first frame update
    void Start()
    {
        endParticles.SetActive(false);
        if(levelManager != null)
        {
            ll2 = levelManager.GetComponent<LoadLevel2>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //player.SetActive(false);
        player.GetComponent<Renderer>().enabled = false;
        this.gameObject.SetActive(false);
        endParticles.SetActive(true);
        if(levelManager != null)
        {
            ll2.LoadLevel();
        }
    }
}
