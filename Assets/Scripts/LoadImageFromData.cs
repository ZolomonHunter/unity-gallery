using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImageFromData : MonoBehaviour
{
    public DownloadManager downloadManager;
    public OpenedImageData imageData;

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        downloadManager.downloadImage(imageData.imageNumber, image);
    }
}
