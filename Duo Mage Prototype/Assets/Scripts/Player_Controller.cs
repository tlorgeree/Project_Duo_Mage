using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody rigid_body;
    public float move_speed;
    private int move_left;

    private int move_right;
    private int move_up; //Up and down on the 2D axis
    private int move_down;

    private float move_hor;
    private float move_ver;
    private Vector2 move_input;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move_right = Input.GetKey(KeyCode.D) ? 1 : 0;
        
        move_left = Input.GetKey(KeyCode.A) ? 1 : 0;
        move_up = Input.GetKey(KeyCode.W) ? 1 : 0;
        move_down = Input.GetKey(KeyCode.S) ? 1 : 0;
        move_hor = (move_right - move_left);
        move_ver = (move_up - move_down);
        
        move_input.x = move_hor;
        move_input.y = move_ver;
        move_input.Normalize();
        rigid_body.velocity = new Vector3(move_input.x * move_speed, rigid_body.velocity.y, move_input.y* move_speed);

    }
}
