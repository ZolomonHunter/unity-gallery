using System;
using UnityEngine;
using UnityEngine.UI;

public class ImageLazyLoading : MonoBehaviour
{
    public DownloadManager downloadManager;
    public Texture2D loadingImage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check if triggered not by image
        string name = collision.name;
        if (!name.StartsWith("image"))
        {
            Debug.Log("Trigger with not image");
            return;
        }

        // get image object
        string imageNumber = name[5..];
        Image image = collision.GetComponent<Image>();


        if (image.sprite != null)
            return;

        // set loading image
        Rect loadingImageSize = new Rect(0, 0, loadingImage.width, loadingImage.height);
        Vector2 center = new Vector2(0.5f, 0.5f);
        image.sprite = Sprite.Create(loadingImage, loadingImageSize, center);

        // download and set image
        downloadManager.downloadImage(imageNumber, image);
    }
}
