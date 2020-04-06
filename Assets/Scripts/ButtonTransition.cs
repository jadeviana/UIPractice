using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonTransition : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform buttonContent = null;
    private Vector2 initialPosition;
    private float initialPosY;


    private void Start()
    {
        initialPosition = buttonContent.localPosition;
        initialPosY = buttonContent.localPosition.y;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        buttonContent.localPosition = new Vector2(0, initialPosY - 8);
    }

    //Return Button Visual to initial state
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonContent.localPosition = initialPosition;
    }
}