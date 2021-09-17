using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Points _points;
    private void Awake()
    {
        _points = GameObject.Find("Text").GetComponent<Points>();
    }

    void OnTriggerExit2D(Collider2D col)
    {
        
        if (col.CompareTag("Map"))
        Destroy(gameObject);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemyguy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Points.points++;
        }
    }

}
