using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasGroupSwapper : MonoBehaviour
{
    public static void ShowCanvasGroup(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1.0f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    public static void HideCanvasGroup(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0.0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}