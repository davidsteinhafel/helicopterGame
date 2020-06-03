using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite dead1;
    public bool isDead = false;
    void FixedUpdate()
    {
        float horizontal = 2;
        float vertical;
        if (Input.GetMouseButton(0) && isDead == false)
        {
            vertical = 5;

        }
        else
        {
            vertical = -5;
        }
        
        Vector3 movement = new Vector3(horizontal, vertical, .5f);
        GetComponent<Rigidbody2D>().velocity = movement;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
        if(isDead == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = dead1;
            
        }
    }
}
