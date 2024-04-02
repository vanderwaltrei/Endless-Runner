using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Allow using value to text objects

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay; //Text DIsplay
    public int disRun; //Count the Distance
    public bool addingDis = false; //Adding to DIstance or not
    public float disDelay = 0.5f;
    void Update()
    {
      if(addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }  
    }

    //Coroutine
    IEnumerator AddingDis()
    {
        disRun += 1; //Adds 1 distance
        disDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay); //Wait
        addingDis = false;
    }

}
