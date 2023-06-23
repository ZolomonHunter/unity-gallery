using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DownloadManager : MonoBehaviour
{
    private const string picsSourceUrl = "http://data.ikppbb.com/test-task-unity-data/pics/";
    private const string imageFormat = ".jpg";

    public void downloadImage(string imageNumber, Image image)
    {
        GetTexture(picsSourceUrl + imageNumber.ToString() + imageFormat,
            (string error) => Debug.Log("Image loading error: " + error),
            (Texture2D texture) =>
            {
                image.sprite = createSprite(texture);
                image.color = Color.white;
            });
    }

    private Sprite createSprite(Texture2D texture)
    {
        // create sprite from downloaded texture
        return Sprite.Create(texture,
            new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));
    }

    private void GetTexture(string picUrl, Action<string> onError, Action<Texture2D> onSuccess)
    {
        // start coroutine for downloading
        StartCoroutine(GetTextureCoroutine(picUrl, onError, onSuccess));
    }

    private IEnumerator GetTextureCoroutine(string picUrl, Action<string> onError, Action<Texture2D> onSuccess)
    {
        using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(picUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError ||
                request.result == UnityWebRequest.Result.ProtocolError)
            {
                onError(request.error);
            }
            else
            {
                DownloadHandlerTexture handler = request.downloadHandler as DownloadHandlerTexture;
                onSuccess(handler.texture);
            }
        }
    }
}
