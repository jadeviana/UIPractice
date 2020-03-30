using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonTransition : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private RectTransform buttonContent = null;
    [SerializeField] private Image buttonIcon = null;
    [SerializeField] private TextMeshProUGUI buttonTitle = null;
    private Vector2 initialPosition;
    private float initialPosY;


    private void Start()
    {
        initialPosition = buttonContent.localPosition;
        initialPosY = buttonContent.localPosition.y;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        buttonIcon.color = new Color32(70, 70, 70, 125);
        buttonTitle.color = new Color32(70, 70, 70, 125);
        buttonContent.localPosition = new Vector2(0, initialPosY - 8);
    }

    //Return Button Visual to initial state
    public void OnPointerUp(PointerEventData eventData)
    {
        buttonIcon.color = new Color32(255, 255, 255, 255);
        buttonTitle.color = new Color32(255, 255, 255, 255);
        buttonContent.localPosition = initialPosition;
    }
}