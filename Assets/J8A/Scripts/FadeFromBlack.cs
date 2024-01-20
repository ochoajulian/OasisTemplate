using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeFromBlack : MonoBehaviour
{
    private Image blackImage;

    private void OnEnable()
    {
        blackImage = GetComponent<Image>();
        FadeUpFromBlack();
    }
    
    public void FadeUpFromBlack()
    {
        StartCoroutine(ImageFadeThenLoadScene(blackImage, 0.0f, 10.0f));
    }
    
    public IEnumerator ImageFadeThenLoadScene(Image image, float endValue, float duration)
    {
        float elapsedTime = 0;
        float startValue = image.color.a;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startValue, endValue, elapsedTime / duration);
            image.color = new Color(image.color.r, image.color.g, image.color.b, newAlpha);
            
            if (newAlpha <= 0)
            {
                yield break;
            }
            
            yield return null;
        }
    }
}
