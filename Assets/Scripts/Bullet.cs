﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speedBullet;

   
    void Update()
    {
        transform.Translate(Vector3.right * speedBullet * Time.deltaTime);
    }
}
