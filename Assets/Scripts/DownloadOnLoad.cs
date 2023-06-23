using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadOnLoad : MonoBehaviour
{
    public OpenedImageData data;
    public DownloadManager downloadManager;

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        downloadManager.downloadImage(data.imageNumber, image);
    }
}
