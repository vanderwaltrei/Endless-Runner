using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -0.75f ;
    public static float rightSide = 0.75f ;
    public float internalLeft;
    public float internalRight;

    private void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
