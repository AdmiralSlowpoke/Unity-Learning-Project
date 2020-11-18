using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.Play("Door_Open");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.Play("Door_Close");
        }
    }
}
