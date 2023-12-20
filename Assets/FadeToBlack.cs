using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeToBlack : MonoBehaviour
{
    [SerializeField] private float alphaStart = 0.0f;
    [SerializeField] private float alphaEnd = 255f;
    [SerializeField] private float speed = 0.05f;

    private float time;
    private Image blackImage;
    private float imageAlpha;

    private void OnEnable()
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneAt(0));
        blackImage = GetComponent<Image>();
        imageAlpha = blackImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        imageAlpha = Mathf.Lerp(alphaStart, alphaEnd, time);
        time += speed * Time.deltaTime;

        if (time >= 1.0f)
        {
            StartOasis();
            UnloadMainMenu();
        }
    }

    private void StartOasis()
    {
        
    }
    
    private void UnloadMainMenu()
    {
        SceneManager.UnloadSceneAsync(0);
    }
}
