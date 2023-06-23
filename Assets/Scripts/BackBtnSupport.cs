using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtnSupport : MonoBehaviour
{
    public string sceneName = "GalleryScene";

    void Update()
    {
        // esc on keyboard / back btn on android/ios
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
