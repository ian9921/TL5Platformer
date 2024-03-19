using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ClickyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    [SerializeField] private Image img;
    [SerializeField] private Sprite up, pressed;
    [SerializeField] private TextMeshProUGUI playText;
    [SerializeField] private Vector3 moveOffset;
    //[SerializeField] private AudioClip compressClip, uncompressClip;
    //[SerializeField] private AudioSource audioSource;

    public void OnPointerDown(PointerEventData eventData){
        img.sprite = pressed;
        if (playText!=null){
            playText.rectTransform.localPosition += moveOffset;
        }
        //audioSource.PlayOneShot(compressClip);
    }

    public void OnPointerUp(PointerEventData eventData){
        img.sprite = up;
        if (playText!=null){
            playText.rectTransform.localPosition -= moveOffset;
        }
        //audioSource.PlayOneShot(uncompressClip);  
    }

    public void SwitchScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void LeaveTheGame(){
        Application.Quit();
    }
}
