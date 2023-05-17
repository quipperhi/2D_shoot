using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class CancelButtonHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Sprite NormalButton;
    [SerializeField] Sprite HighlightButton;
    [SerializeField] Button button;
    [SerializeField] GameObject SettingWindow;
    public void OnPointerEnter(PointerEventData eventData)
    {
        button.image.sprite = HighlightButton;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.image.sprite = NormalButton;
    }

    public void CancelButton()
    {
        SettingWindow.SetActive(false);
        Time.timeScale = 1;
    }
}
