using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PopUpManager : MonoBehaviour
{
    [SerializeField] private GameObject PopUpScreen = null;
    [SerializeField] private GameObject ribbonTitle = null;
    [SerializeField] private GameObject optionsPanel = null;
    [SerializeField] private GameObject popUps = null;
    [SerializeField] private GameObject returnButton = null;

    private CanvasGroup titleCanvasGroup;
    private CanvasGroup optionsPanelCanvasGroup;
    private CanvasGroup returnButtonCanvasGroup;
    private CanvasGroup popUpsCanvasGroup;

    private float titlePosY;
    private float optionsPanelPosY;
    private float returnButtonPosY;
    private float popUpPosY;
    private float animDuration = 0.4f;

    private void Start()
    {
        titleCanvasGroup = ribbonTitle.GetComponent<CanvasGroup>();
        optionsPanelCanvasGroup = optionsPanel.GetComponent<CanvasGroup>();
        returnButtonCanvasGroup = returnButton.GetComponent<CanvasGroup>();
        //popUpsCanvasGroup = popUps.GetComponent<CanvasGroup>();

        titlePosY = ribbonTitle.GetComponent<RectTransform>().localPosition.y;
        optionsPanelPosY = optionsPanel.GetComponent<RectTransform>().localPosition.y;
        returnButtonPosY = returnButton.GetComponent<RectTransform>().localPosition.y;
        //popUpPosY = popUps.GetComponent<RectTransform>().localPosition.y;

    }

    public IEnumerator FadeIn(float time)
    {
        titleCanvasGroup.alpha = 0;
        optionsPanelCanvasGroup.alpha = 0;
        returnButtonCanvasGroup.alpha = 0;
        //popUpsCanvasGroup.alpha = 0;

        yield return new WaitForSeconds(0.3f);

        PopUpScreen.SetActive(true);

        ribbonTitle.transform.DOLocalMoveY(titlePosY - 40f, time, true);
        titleCanvasGroup.DOFade(1.0f, time);

        optionsPanel.transform.DOLocalMoveY(optionsPanelPosY + 20f, time, true);
        optionsPanelCanvasGroup.DOFade(1.0f, time);

        returnButton.transform.DOLocalMoveY(returnButtonPosY + 20f, time, true);
        returnButtonCanvasGroup.DOFade(1.0f, time);

        //popUps.transform.DOLocalMoveY(popUpPosY + 40f, time, true);
        //popUpsCanvasGroup.DOFade(1.0f, time);
    }
    public IEnumerator FadeOut(float time)
    {
        ribbonTitle.transform.DOLocalMoveY(titlePosY + 40f, time, true);
        titleCanvasGroup.DOFade(0f, time);

        optionsPanel.transform.DOLocalMoveY(optionsPanelPosY - 20f, time, true);
        optionsPanelCanvasGroup.DOFade(0f, time);

        returnButton.transform.DOLocalMoveY(returnButtonPosY - 20f, time, true);
        returnButtonCanvasGroup.DOFade(0f, time);

        //popUps.transform.DOLocalMoveY(popUpPosY - 40f, time, true);
        //popUpsCanvasGroup.DOFade(1.0f, time);

        yield return new WaitForSeconds(time + 0.1f);

        PopUpScreen.SetActive(false);
    }

    public void CloseScreen()
    {
        StartCoroutine(FadeOut(animDuration));
    }
    public void OpenScreen()
    {
        StartCoroutine(FadeIn(animDuration));
    }
}
