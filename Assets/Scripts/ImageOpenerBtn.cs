using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImageOpenerBtn : MonoBehaviour
{
    public OpenedImageData imageData;
    public GameObject sceneManager;

    public void saveAndOpen()
    {
        Image image = GetComponent<Image>();
        // save image we need to open
        imageData.imageNumber = image.name[5..];

        // open image viewer
        OpenScenes openScenes = sceneManager.GetComponent<OpenScenes>();
        openScenes.OpenScene();
    }
}
