using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private Image blackImage;

    private void OnEnable()
    {
        blackImage = GetComponent<Image>();
    }

    public void FadeToBlack()
    {
        StartCoroutine(ImageFade(blackImage, 255.0f, 1000.0f));
    }
    
    public IEnumerator ImageFade(Image image, float endValue, float duration)
    {
        float elapsedTime = 0;
        float startValue = image.color.a;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startValue, endValue, elapsedTime / duration);
            image.color = new Color(image.color.r, image.color.g, image.color.b, newAlpha);
            yield return null;
            Debug.Log("done fading");
        }
    }
}
