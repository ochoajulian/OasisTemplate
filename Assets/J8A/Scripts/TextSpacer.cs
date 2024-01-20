using TMPro;
using UnityEngine;

public class TextSpacer : MonoBehaviour
{
    private TextMeshProUGUI tmPro;
    [SerializeField] private float speed = 0.01f;

    private void OnEnable()
    {
        tmPro = GetComponent<TextMeshProUGUI>();
        tmPro.characterSpacing = 0;
    }

    private void Update()
    {
        if (tmPro.characterSpacing < 90)
        {
            tmPro.characterSpacing += speed;
        }
    }
}