using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    //To turn off the live statistics
    public GameObject liveCoins;
    public GameObject liveDis;

    public GameObject endScreen;
    public GameObject fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence()); //Start the Game Over Sequence
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(2); //Wait 2 seconds before playing the sequence
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        fadeOut.SetActive(true);
    }
}
