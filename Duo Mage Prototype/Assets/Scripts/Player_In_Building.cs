using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_In_Building : MonoBehaviour
{
    //This Player collision script detects the base of a building,
    //and if in contact with it, makes the fac eof the building transparent.
    void OnTriggerEnter(Collider other)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "House")
        {
            GameObject child_door = other.transform.parent.gameObject.transform.GetChild(1).gameObject;//get sibling which is door
            if (child_door.GetComponentInChildren<Renderer>().enabled == true) child_door.GetComponentInChildren<Renderer>().enabled = false; // make door invisible
            GameObject child_face = other.transform.parent.gameObject.transform.GetChild(2).gameObject;//get sibling which is face
            if (child_face.GetComponentInChildren<Renderer>().enabled == true) child_face.GetComponentInChildren<Renderer>().enabled = false; //Make building face invisible
          
        }

       
    }

    private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.tag == "House")
            {
                GameObject child_door = other.transform.parent.gameObject.transform.GetChild(1).gameObject;//Get sibling which is Door
                if (child_door.GetComponentInChildren<Renderer>().enabled == false) child_door.GetComponentInChildren<Renderer>().enabled = true;//Make building door visible
                GameObject child_face = other.transform.parent.gameObject.transform.GetChild(2).gameObject;//Get sibling which is face
                if (child_face.GetComponentInChildren<Renderer>().enabled == false) child_face.GetComponentInChildren<Renderer>().enabled = true;//Make building face visible

            }
    }

}
