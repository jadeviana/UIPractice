using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu = null;
    [SerializeField] private RectTransform ribbonTitle = null;
    [SerializeField] private RectTransform buttonPanel = null;

    public void CloseMainMenu()
    {
        //mainMenu.SetActive(false);
    }
    public void OpenMainMenu()
    {
        mainMenu.SetActive(true);
    }

}
