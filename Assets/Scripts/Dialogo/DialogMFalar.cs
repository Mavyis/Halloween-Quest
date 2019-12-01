using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogMFalar : MonoBehaviour
{
    public GameObject dialogPanel;
    public Text dialogText;

    private List<string> conversation;
    private int convoIndex;

    private void Start()
    {
        dialogPanel.SetActive(false);
    }

    public void Start_Dialog( List<string> _convo)
    {
        conversation = new List<string>(_convo);
        dialogPanel.SetActive(true);
        convoIndex = 0;
        ShowText();
    }

    public void StopDialog()
    {
        dialogPanel.SetActive(false);
    }

    public void ShowText()
    {
        dialogText.text = conversation[convoIndex];
    }

    private void OnTriggerExit(Collider other)
    {
        dialogPanel.SetActive(false);
    }

}