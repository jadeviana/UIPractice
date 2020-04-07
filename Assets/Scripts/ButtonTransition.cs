using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonTransition : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform buttonContent = null;
    private float initialPosX;
    private float initialPosY;

    private void Start()
    {
        initialPosX = buttonContent.localPosition.x;
        initialPosY = buttonContent.localPosition.y;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonContent.localPosition = new Vector2(initialPosX, initialPosY - 8);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonContent.localPosition = new Vector2(initialPosX, initialPosY);
    }
}