﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Chain.isFired = false;

        if (collision.tag == "Ball")
        {
            collision.GetComponent<Ball>().Split();
        }
    }
}
    