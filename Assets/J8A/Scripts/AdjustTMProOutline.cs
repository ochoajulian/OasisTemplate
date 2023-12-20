using UnityEngine;
using TMPro;

public class AdjustTMProOutline : MonoBehaviour
{
    
    [SerializeField] private float widthSize;
    [SerializeField] private Color32 outlineColor;
    private void Awake()
    {
        TextMeshProUGUI tmPro = GetComponent<TextMeshProUGUI>();
        tmPro.outlineWidth = widthSize;
        tmPro.outlineColor = outlineColor;
    }
}
