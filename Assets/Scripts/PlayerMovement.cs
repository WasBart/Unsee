using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 50.0f;

    [SerializeField]private CharacterController playerChar;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown((KeyCode.A)))
        {
            transform.Translate(new Vector3(-1.0f,0,0));
        }
        else if(Input.GetKeyDown((KeyCode.D)))
        {
            transform.Translate(new Vector3(1.0f,0,0));
        }
        else if(Input.GetKeyDown((KeyCode.W)))
        {
            transform.Translate(new Vector3(0,0,1.0f));
        }
        else if(Input.GetKeyDown((KeyCode.S)))
        {
            transform.Translate(new Vector3(0,0,-1.0f));
        } */

        Vector3 tempVect = Vector3.zero;

        if (Input.GetKeyDown((KeyCode.W)))
        {
            tempVect = new Vector3(0, 0, 1);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            //rb.MovePosition(transform.position + tempVect);
            

        }
        else if (Input.GetKeyDown((KeyCode.S)))
        {
            tempVect = new Vector3(0, 0, -1);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            // rb.MovePosition(transform.position + tempVect);
  
        }
        else if (Input.GetKeyDown((KeyCode.A)))
        {
            tempVect = new Vector3(-1, 0, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            //rb.MovePosition(transform.position + tempVect);
        }
        else if (Input.GetKeyDown((KeyCode.D)))
        {
            tempVect = new Vector3(1, 0, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            //rb.MovePosition(transform.position + tempVect);
        }

        playerChar.Move(tempVect);
        
    }
}
