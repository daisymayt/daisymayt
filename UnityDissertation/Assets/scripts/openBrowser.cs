using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;

public class openBrowser : MonoBehaviour
{
    public Button toggleStaticButton;
    private bool doubleClick = false;

    void Start()
    {
        Debug.Log(Microphone.devices.Length);
        Debug.Log(Application.internetReachability.ToString());
        Button btn = toggleStaticButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (doubleClick)
        {
            doubleClick = false;

            Application.OpenURL("https://www.google.com");
        }
        else
        {
            doubleClick = true;
        }
    }
}
