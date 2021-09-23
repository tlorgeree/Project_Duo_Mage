using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Collision : MonoBehaviour
{
    public GameObject ignore;

    //Detect collisions between the GameObjects with Colliders attached
    void Start()
    {

        Physics.IgnoreCollision(ignore.GetComponent<Collider>(), GetComponent<Collider>());

    }
}
