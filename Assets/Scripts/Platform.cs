using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

private Transform BackPoint;
    void Start()
    {
       BackPoint = GameObject.Find("BackPoint").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < BackPoint.position.x)
        {
            Destroy(gameObject);
        }
    }
}
