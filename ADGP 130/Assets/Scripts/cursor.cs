﻿using UnityEngine;
using System.Collections;


public class Cursor : MonoBehaviour

   



{
    //Run Death;



    // Use this for initialization
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Input.mousePosition, 10);

        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, +10));
        if (Input.GetMouseButtonDown(0) == true)
        {
            GetComponent<AudioSource>().Play();
            if (hit != null && hit.collider != null)
            {
                //gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
                Destroy(hit.collider.gameObject);
                //hit.collider.GetComponent<Health>().hp -= 1;
            }

        }
    }

    public void Shoot()
    {
       Debug.Log("do it");
    }
}

