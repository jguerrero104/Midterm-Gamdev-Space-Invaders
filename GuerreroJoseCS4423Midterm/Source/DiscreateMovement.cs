using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreateMovement : MonoBehaviour
{
    [SerializeField] Creature playerCreature;
    [SerializeField] float speed = 1.0f;
    

    public void Move(Vector3 direction){

        playerCreature.MoveCreature(direction * speed);
    }
}
