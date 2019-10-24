using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {
    private Animator ani;

    // Use this for initialization
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ani.SetTrigger("Dancing");
        }

        ani.SetBool("Run", Input.GetKey(KeyCode.R));
    }
}
