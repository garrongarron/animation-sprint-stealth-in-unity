using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    [Header("Coordinates")]
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private int mode =0;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        anim.SetFloat("X", x);
        anim.SetFloat("Y", y);
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            anim.SetInteger("Mode", 1);
            mode = 1;
            Debug.Log(1);
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            anim.SetInteger("Mode", 0);
            mode = 0;
            Debug.Log(0);
        }

        if(Input.GetKey(KeyCode.LeftControl)){
            anim.SetInteger("Mode", 2);
            mode = 1;
            Debug.Log(1);
        }
        if(Input.GetKeyUp(KeyCode.LeftControl)){
            anim.SetInteger("Mode", 0);
            mode = 0;
            Debug.Log(0);
        }
        
    }
}
