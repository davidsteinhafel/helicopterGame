using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log("hi");
        GameObject.Find("Player").GetComponent<Player>().isDead = true;

    }
}
