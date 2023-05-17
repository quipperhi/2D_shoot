using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ReplayButtonHighlight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Sprite NormalButton;
    [SerializeField] Sprite HighlightButton;
    [SerializeField] Button button;
    public void OnPointerEnter(PointerEventData eventData)
    {
        button.image.sprite = HighlightButton;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.image.sprite = NormalButton;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }
}
