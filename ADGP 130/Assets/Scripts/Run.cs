﻿using UnityEngine;
using System.Collections;
public class Run : MonoBehaviour
{
    public Vector2 begin;
    public Vector2 end;
    public float time_for_move;
    Animator anim;
    int stop = Animator.StringToHash("stand");
    float timer;
    // Use this for initialization
    void Start()
    {
        transform.position = begin;
        timer = time_for_move;
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer > 0)
        {
            gameObject.GetComponent<Animator>().SetBool("IsWalking", true);
            //anim.SetBool("IsWalking", true);
            Vector2 distance = end - begin;
            float degree_of_movement = (time_for_move - timer) / time_for_move;
            transform.position = new Vector2(begin.x + (distance.x * degree_of_movement), begin.y + (distance.y * degree_of_movement));
    
        }
        

    }
}