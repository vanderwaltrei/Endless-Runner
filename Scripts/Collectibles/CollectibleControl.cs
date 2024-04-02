using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Allow using value to text objects

public class CollectibleControl : MonoBehaviour
{
    public static int coinCount; //static makes it dissappear in Unity
    public GameObject coinCountDisplay;
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount; //Display number
    }
}
