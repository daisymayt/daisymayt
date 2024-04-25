using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;

public class staticToggle : MonoBehaviour
{
    public Button toggleStaticButton;
    public GameObject grab;
    public GameObject distanceGrab;
    private bool doubleClick = false;

    void Start()
    {
        Button btn = toggleStaticButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (doubleClick)
        {
            distanceGrab.SetActive(!distanceGrab.activeSelf);
            grab.SetActive(!grab.activeSelf);
            doubleClick = false;

            var currentColor = GetComponent<Button>().image.color;
            if (currentColor == Color.gray)
            {
                GetComponent<Button>().image.color = Color.white;
                Application.OpenURL("https://www.google.com");
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
