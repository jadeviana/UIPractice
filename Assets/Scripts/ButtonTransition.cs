using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTransition : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform buttonContent = null;

    private void Start()
    {
        buttonContent = GetComponent<RectTransform>();
        var yPos = buttonContent.anchoredPosition.y;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //buttonContent.anchoredPosition = new Vector2(0, 8);
        Debug.Log("Pressed");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //buttonContent.anchoredPosition = new Vector2(0, 0);
        Debug.Log("Released");
    }
}