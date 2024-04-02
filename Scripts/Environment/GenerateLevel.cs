using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 12; //Section Length
    public bool creatingSection = false; 
    public int secNum;
    void Update()
    {
       if (creatingSection == false) //Asking
        {
            creatingSection = true;
            StartCoroutine(GenerateSection()); //To add Time Delay
        }
    }

    IEnumerator GenerateSection() //Generate Object (Section)
    {
        secNum = Random.Range(0, 3); //Array is not expecting 3 (Therefore it's 0, 1 or 2)
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity); //Generate whatever is in the array list
        zPos += 12;
        yield return new WaitForSeconds(2); //Wait
        creatingSection = false;
    }
}
