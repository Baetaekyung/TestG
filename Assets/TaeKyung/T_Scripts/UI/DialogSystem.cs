using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoSingleton<DialogSystem>
{
    [SerializeField] TextMeshProUGUI actorNameText;
    [SerializeField] TextMeshProUGUI mainText;
    [SerializeField] GameObject dialogPanel;
    [SerializeField] GameObject currentImage;
    [SerializeField] DialogData datas;
    private Image image;

    int currentTextLine = 0;

    private void Start()
    {
        image = currentImage.GetComponent<Image>();
        Initialize(datas);
    }

    private void Update()
    {
        if (dialogPanel.activeSelf)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                PushText();
            }
        }
        else
        {
            return;
        }
    }

    private void PushText()
    {
        currentTextLine++;
        if (currentTextLine >= datas.data.Count)
        {
            Conclude();
        }
        else
        {
            currentImage.SetActive(datas.data[currentTextLine].imageOnOff);
            mainText.text = datas.data[currentTextLine].currentText;
        }
    }

    public void Initialize(DialogData dialogTexts)
    {
        Show(true);
        datas = dialogTexts;
        currentTextLine = 0;
        image.sprite = datas.sourceImage;
        mainText.text = datas.data[currentTextLine].currentText;
        currentImage.SetActive(datas.data[currentTextLine].imageOnOff);
        actorNameText.text = datas.nickName;
    }

    private void Show(bool b)
    {
        dialogPanel.SetActive(b);
    }

    private void Conclude()
    {
        Show(false);
    }
}
