using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollisions : MonoBehaviour
{
    public GameObject thePlayer;
    //Animation on player model
    public GameObject charModel;

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
    }
}
