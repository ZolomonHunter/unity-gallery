using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public float loadingTime = 3.0f;
    public UnityEvent OnComplete;

    private Slider slider;
    private TextMeshProUGUI progressText;
    private float timer = 0f;

    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        progressText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
        if (timer < loadingTime)
        {
            timer += Time.deltaTime;
            float progress = timer / loadingTime;
            slider.value = progress;
            progressText.text = progress.ToString("P2");
        }
        else
        {
            progressText.text = "100%";
            OnComplete.Invoke();
        }
    }


}
