using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Animator PacStudent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Will turn player to the upwards position
        if (Input.GetKeyDown(KeyCode.UpArrow)) 
            PacStudent.SetTrigger("RotateUp");

        //Will turn player to the Downwards position
        if (Input.GetKeyDown(KeyCode.DownArrow)) 
            PacStudent.SetTrigger("RotateDown");

        //Will turn player to the Right position
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
            PacStudent.SetTrigger("RotateRight");

        //Will turn player to the Left position
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
            PacStudent.SetTrigger("RotateLeft");

        //Simulate Death animation by pressing F
        if (Input.GetKeyDown(KeyCode.F)) 
            PacStudent.SetBool("isDead", true);
    }
}
