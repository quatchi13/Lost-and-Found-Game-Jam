﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class isometricMovement : MonoBehaviour
{

    public Animator animator;
    public GameObject SHHHHNOTSUS;

    public float moveSpeed = 10f;
    public Rigidbody2D rigid;
    

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", movement.x);
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() 
    {
      rigid.MovePosition(rigid.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            FindObjectOfType<AudioManager>().Play("pickup");
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("mission1"))
        {
            FindObjectOfType<AudioManager>().Play("mission 1");
            Destroy(other.gameObject);
            GameObject item = SHHHHNOTSUS.transform.Find("Item1").gameObject;
            item.SetActive(true);
            if (other.gameObject.CompareTag("pickup"))
            {
                FindObjectOfType<AudioManager>().Play("pickup");
                Destroy(other.gameObject);
                GameObject missionT = SHHHHNOTSUS.transform.Find("missionT2").gameObject;
                missionT.SetActive(true);
            }
        }

        if (other.gameObject.CompareTag("mission2"))
        {
            FindObjectOfType<AudioManager>().Play("mission 2");
            Destroy(other.gameObject);
            GameObject item = SHHHHNOTSUS.transform.Find("Item2").gameObject;
            item.SetActive(true);
            if (other.gameObject.CompareTag("pickup"))
            {
                FindObjectOfType<AudioManager>().Play("pickup");
                Destroy(other.gameObject);
                GameObject missionT = SHHHHNOTSUS.transform.Find("missionT3").gameObject;
                missionT.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("mission3"))
        {
            FindObjectOfType<AudioManager>().Play("mission 3");
            Destroy(other.gameObject);
            GameObject item = SHHHHNOTSUS.transform.Find("Item3").gameObject;
            item.SetActive(true);
            if (other.gameObject.CompareTag("pickup"))
            {
                FindObjectOfType<AudioManager>().Play("pickup");
                Destroy(other.gameObject);
                GameObject missionT = SHHHHNOTSUS.transform.Find("missionT4").gameObject;
                missionT.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("mission4"))
        {
            FindObjectOfType<AudioManager>().Play("mission 4");
            Destroy(other.gameObject);
            GameObject item = SHHHHNOTSUS.transform.Find("Item4").gameObject;
            item.SetActive(true);
            if (other.gameObject.CompareTag("pickup"))
            {
                FindObjectOfType<AudioManager>().Play("pickup");
                Destroy(other.gameObject);
                GameObject missionT = SHHHHNOTSUS.transform.Find("missionT5").gameObject;
                missionT.SetActive(true);
            }
        }



    }

}

