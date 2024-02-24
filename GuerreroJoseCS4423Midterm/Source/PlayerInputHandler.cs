using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] Creature playerCreature;
    [SerializeField] DiscreateMovement movementScript;

    ProjectileThrower projectileThrower;

    void Start()
    {
        projectileThrower = playerCreature.GetComponent<ProjectileThrower>();

    }



    // Update is called once per frame
    void Update()
    {

        Vector3 input = Vector3.zero;

        if(Input.GetKey(KeyCode.W)){
            input.y += 1;
        }

        if(Input.GetKey(KeyCode.S)){
            input.y += -1;

        }

        if(Input.GetKey(KeyCode.A)){
            input.x += -1;
        }

        if(Input.GetKey(KeyCode.D)){
            input.x += 1;
        }
        
        if(input != Vector3.zero){
            movementScript.Move(input);
        }

        if(Input.GetKeyDown(KeyCode.E)){
            projectileThrower.Launch(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
      

        // if(Input.GetKeyDown(KeyCode.Q)){

           //playerCreature.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));

        //} 

        
    }
}
