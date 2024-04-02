using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinSFX;
    private void OnTriggerEnter(Collider other)
    {
        coinSFX.Play();
        CollectibleControl.coinCount += 1; //Add 1 to currect coin count
        this.gameObject.SetActive(false); //Stops more coins
    }
}
