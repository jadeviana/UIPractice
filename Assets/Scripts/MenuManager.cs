using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuScreen = null;
    [SerializeField] private GameObject ribbonTitle = null;
    [SerializeField] private GameObject buttonPanel = null;

    //Title variables
    private CanvasGroup titleCanvasGroup;
    private float titlePosY;

    //Panel variables
    private CanvasGroup buttonPanelCanvasGroup;
    private float buttonPanelPosY;

    //Animation variables
    private float animDuration = 0.5f;

    private void Start()
    {
        titleCanvasGroup = ribbonTitle.GetComponent<CanvasGroup>();
        titlePosY = ribbonTitle.GetComponent<RectTransform>().localPosition.y;
        titleCanvasGroup.alpha = 0;

        buttonPanelCanvasGroup = buttonPanel.GetComponent<CanvasGroup>();
        buttonPanelPosY = buttonPanel.GetComponent<RectTransform>().localPosition.y;
        buttonPanelCanvasGroup.alpha = 0;

        StartCoroutine(FadeIn(animDuration));
    }

    public IEnumerator FadeIn(float time)
    {
        yield return new WaitForSeconds(0.1f);

        MenuScreen.SetActive(true);

        ribbonTitle.transform.DOLocalMoveY(titlePosY - 40f, 0.5f, true);
        titleCanvasGroup.DOFade(1.0f, time);

        buttonPanel.transform.DOLocalMoveY(buttonPanelPosY + 40f, 0.5f, true);
        buttonPanelCanvasGroup.DOFade(1.0f, time);
    }
    public IEnumerator FadeOut(float time)
    {
        ribbonTitle.transform.DOLocalMoveY(titlePosY + 40f, 0.5f, true);
        titleCanvasGroup.DOFade(0f, time);

        buttonPanel.transform.DOLocalMoveY(buttonPanelPosY - 40f, 0.5f, true);
        buttonPanelCanvasGroup.DOFade(0f, time);

        yield return new WaitForSeconds(time);

        MenuScreen.SetActive(false);
    }

    public void CloseMenu()
    {
        StartCoroutine(FadeOut(animDuration));
    }
    public void OpenMenu()
    {
        StartCoroutine(FadeIn(animDuration));
    }

}
