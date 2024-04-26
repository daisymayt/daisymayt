using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;

public class closeWindow : MonoBehaviour
{
    public Button closeWindowButton;
    public GameObject window;
    private bool doubleClick = false;

    void Start()
    {
        Button btn = closeWindowButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (doubleClick)
        {
            window.SetActive(!window.activeSelf);
            doubleClick = false;

            var currentColor = GetComponent<Button>().image.color;
            if (currentColor == Color.gray)
            {
                GetComponent<Button>().image.color = Color.white;
            }
            else
            {
                GetComponent<Button>().image.color = Color.gray;
            }
        }
        else
        {
            doubleClick = true;
        }
    }
}
