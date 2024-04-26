using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using UnityEngine.UI;

public class resetWindow : MonoBehaviour
{
    public Button resetWindowButton;
    public GameObject quad;
    private bool doubleClick = false;

    void Start()
    {
        Debug.Log(Microphone.devices.Length);
        Debug.Log(Application.internetReachability.ToString());
        Button btn = resetWindowButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (doubleClick)
        {
            doubleClick = false;

            quad.transform.position = new Vector3(-2.5F, -0.4F, 3);
            quad.transform.rotation = new Quaternion(0, 180, 30, 0);
        }
        else
        {
            doubleClick = true;
        }
    }
}
