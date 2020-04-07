using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuScreen = null;
    [SerializeField] private GameObject ribbonTitle = null;
    [SerializeField] private GameObject buttonPanel = null;

    private CanvasGroup titleCanvasGroup;
    private CanvasGroup buttonPanelCanvasGroup;

    private float titlePosY;
    private float buttonPanelPosY;
    private float animDuration = 0.4f;

    private void Start()
    {
        titleCanvasGroup = ribbonTitle.GetComponent<CanvasGroup>();
        buttonPanelCanvasGroup = buttonPanel.GetComponent<CanvasGroup>();

        titlePosY = ribbonTitle.GetComponent<RectTransform>().localPosition.y;
        buttonPanelPosY = buttonPanel.GetComponent<RectTransform>().localPosition.y;

        titleCanvasGroup.alpha = 0;
        buttonPanelCanvasGroup.alpha = 0;

        StartCoroutine(FadeIn(animDuration));
    }

    public IEnumerator FadeIn(float time)
    {
        yield return new WaitForSeconds(0.3f);

        MenuScreen.SetActive(true);

        ribbonTitle.transform.DOLocalMoveY(titlePosY - 40f, time, true);
        titleCanvasGroup.DOFade(1.0f, time);

        buttonPanel.transform.DOLocalMoveY(buttonPanelPosY + 40f, time, true);
        buttonPanelCanvasGroup.DOFade(1.0f, time);
    }
    public IEnumerator FadeOut(float time)
    {
        ribbonTitle.transform.DOLocalMoveY(titlePosY + 40f, time, true);
        titleCanvasGroup.DOFade(0f, time);

        buttonPanel.transform.DOLocalMoveY(buttonPanelPosY - 40f, time, true);
        buttonPanelCanvasGroup.DOFade(0f, time);

        yield return new WaitForSeconds(time + 0.1f);

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
