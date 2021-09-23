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
            GameObject child = other.transform.parent.gameObject.transform.GetChild(1).gameObject;//get sibling which is face
          if (child.GetComponentInChildren<Renderer>().enabled == true) child.GetComponentInChildren<Renderer>().enabled = false; //Make building face invisible
          
        }

       
    }

    private void OnTriggerExit(Collider other)
    {
         if (other.gameObject.tag == "House")
            {
                GameObject child = other.transform.parent.gameObject.transform.GetChild(1).gameObject;//Get sibling which is face
                if (child.GetComponentInChildren<Renderer>().enabled == false) child.GetComponentInChildren<Renderer>().enabled = true;//Make building face visible

            }
    }

}
