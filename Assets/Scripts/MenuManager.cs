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

    private CanvasGroup titleCvGroup;
    private CanvasGroup btnPanelCvGroup;
    private float animDuration = 0.5f;

    private void Start()
    {
        titleCvGroup = ribbonTitle.GetComponent<CanvasGroup>();
        titleCvGroup.alpha = 0;

        btnPanelCvGroup = buttonPanel.GetComponent<CanvasGroup>();
        btnPanelCvGroup.alpha = 0;

        StartCoroutine(FadeIn(animDuration));
    }

    public IEnumerator FadeIn(float time)
    {
        yield return new WaitForSeconds(0.1f);

        MenuScreen.SetActive(true);
        titleCvGroup.DOFade(1.0f, time);
        btnPanelCvGroup.DOFade(1.0f, time);
    }
    public IEnumerator FadeOut(float time)
    {
        titleCvGroup.DOFade(0f, time);
        btnPanelCvGroup.DOFade(0f, time);

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
