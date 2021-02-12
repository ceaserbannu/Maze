using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float hMove = 2f;
    float vMove = 2f;
    float speed = 1f;
    public CharacterController aController;

    // Start is called before the first frame update
    void Start()
    {
        aController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Move Forward
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            vMove = 2f;
        }
        //Move Down
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            vMove = -2f;
        }
        //Move Left
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -90.0f, 0, 0f);
        }
        //Move Right
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.Rotate(0, 90.0f, 0, 0f);
        }
        Vector3 aMove = transform.forward * vMove + transform.right * hMove;
        aController.Move(aMove * speed);
        hMove = 0.0f;
        vMove = 0.0f;
    }
}
