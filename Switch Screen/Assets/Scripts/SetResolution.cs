using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetResolution : MonoBehaviour
{
    // private bool isResolution1080 = true;
    private int switchNumber = 1;
    [SerializeField] private GameObject resolutionText;

    void Start()
    {   // Switch Resolution to 1920 x 1080 windowed
        Screen.SetResolution(1920, 1080, false);
        resolutionText.GetComponent<Text>().text = "Current Screen Resolution is: 1920 x 1080";
    }

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Tab))
        {
            if (switchNumber == 1)
            {
                // Switch to 1360 x 768 windowed
                Screen.SetResolution(1360, 768, false);
                switchNumber++;
                resolutionText.GetComponent<Text>().text = "Current Screen Resolution is: 1360 x 768";
            }
            else if (switchNumber == 2)
            {
                // Switch to 1024 x 768 windowed
                Screen.SetResolution(1024, 768, false);
                switchNumber++;
                resolutionText.GetComponent<Text>().text = "Current Screen Resolution is: 1024 x 768";
            }
            else if (switchNumber == 3)
            {
                // Switch to 800 x 600 windowed
                Screen.SetResolution(800, 600, false);
                switchNumber++;
                resolutionText.GetComponent<Text>().text = "Current Screen Resolution is: 800 x 600";
            }
            else if (switchNumber == 4)
            {
                // Switch to 640 x 360 windowed
                Screen.SetResolution(640, 360, false);
                switchNumber++;
                resolutionText.GetComponent<Text>().text = "Current Screen Resolution is: 640 x 360";
            }
            else if (switchNumber == 5)
            {
                // Switch to 1920 x 1080 windowed
                Screen.SetResolution(1920, 1080, false);
                switchNumber = switchNumber - 4;
                resolutionText.GetComponent<Text>().text = "Current Screen Resolution is: 1920 x 1080";
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
