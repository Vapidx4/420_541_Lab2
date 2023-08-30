using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag == "Player"){
            Debug.Log("You Win!");
        }
    }
}
