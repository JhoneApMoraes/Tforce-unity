using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    public GameObject Platform; 
    public Transform point;
    public float minDistance;
    public float maxDistance;
    private float plataforWidth;

    void Start()
    {
        if (Platform.GetComponent<BoxCollider2D>())
        {
            plataforWidth = Platform.GetComponent<BoxCollider2D>().size.x;
        }
        else
        {
            plataforWidth = Platform.GetComponent<PolygonCollider2D>().bounds.size.x;

        }
    }

    void Update()
    {
        //logica para gerar plataformas 
        if (transform.position.x < point.position.x)
        {

            float Distance = Random.Range(minDistance, maxDistance);

            transform.position = new Vector3(transform.position.x + plataforWidth + Distance, transform.position.y, 0);
            Instantiate(Platform, transform.position, transform.rotation);
        }
    }
}
