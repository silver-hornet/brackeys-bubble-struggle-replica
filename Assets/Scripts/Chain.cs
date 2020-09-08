using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    [SerializeField] Transform player;
    public static bool isFired;
    public float speed = 2f;

    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isFired = true;
        }

        if (isFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
