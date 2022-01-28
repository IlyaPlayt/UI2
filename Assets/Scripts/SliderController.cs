
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] private Slider Slider;
    [SerializeField] private Slider progressBar;

    // Update is called once per frame
    void Update()
    {
        progressBar.value = Mathf.Lerp(progressBar.value, Slider.value, Time.deltaTime * 10f);

    }
}
