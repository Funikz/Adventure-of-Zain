using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zain_Anim : MonoBehaviour
{
    Animator animasi;

    // Start is called before the first frame update
    void Start()
    {
        animasi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            animasi.SetBool("isMoving", true);
        }
        else
        {
            animasi.SetBool("isMoving", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animasi.SetBool("isJumping", true);
        }
        else
        {
            animasi.SetBool("isJumping", false);
        }
    }
}
