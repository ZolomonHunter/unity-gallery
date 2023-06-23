using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationEnabler : MonoBehaviour
{
    void Start()
    {
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
    }
}
