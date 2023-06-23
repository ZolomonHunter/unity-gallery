using UnityEngine;

public class OrientationBlock : MonoBehaviour
{
    void Start()
    {
        // disable rotation to landscape
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        if (Screen.orientation != ScreenOrientation.Portrait)
            Screen.orientation = ScreenOrientation.Portrait;
    }
}
