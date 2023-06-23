using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentInitializer : MonoBehaviour
{
    public GameObject image;
    public int numberOfImages = 66;

    private RectTransform contentBox;
    private GridLayoutGroup grid;

    void Start()
    {
        contentBox = GetComponent<RectTransform>();
        grid = gameObject.GetComponent<GridLayoutGroup>();
        // calculate one image height (with paddings)
        float cellHeight = grid.cellSize.y + grid.spacing.y;
        float paddingHeight = grid.padding.top + grid.padding.bottom;
        // setup content box height for valid scroll length
        contentBox.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, numberOfImages * cellHeight / 2 + paddingHeight);

        // instantiate needed number of images
        for (int i = 0; i < numberOfImages; i++)
        {
            GameObject curImage = Instantiate(image, contentBox);
            curImage.name = "image" + (i + 1);
            curImage.SetActive(true);
        }
    }
}
