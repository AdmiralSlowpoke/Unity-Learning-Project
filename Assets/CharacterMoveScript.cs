using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    private GameObject player;
    private Rigidbody2D playerRigidBody2D;
    void Start()
    {
        player = this.gameObject;
        playerRigidBody2D = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.Play("MoveRight");
            player.transform.position += new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.Play("MoveLeft");
            player.transform.position -= new Vector3(0.1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.transform.position += new Vector3(0, 3f, 0);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            animator.Play("Idle");
        }
    }
}
