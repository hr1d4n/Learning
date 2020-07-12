using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchPlayer2 : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject sideCamera;
    public GameObject topDownCamera;
    int cameraScenario = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            
            cameraScenario++;
            if (cameraScenario > 3)
            {
                cameraScenario = 1;
            }

            switch (cameraScenario)
            {
                case 1:
                    mainCamera.SetActive(false);
                    sideCamera.SetActive(true);
                    topDownCamera.SetActive(false);
                    break;
                case 2:
                    mainCamera.SetActive(false);
                    sideCamera.SetActive(false);
                    topDownCamera.SetActive(true);
                    break;
                case 3:
                    mainCamera.SetActive(true);
                    sideCamera.SetActive(false);
                    topDownCamera.SetActive(false);
                    break;
            }

            //Alternate solution
            //if (mainCamera.activeSelf)
            //{
            //    mainCamera.SetActive(false);
            //    sideCamera.SetActive(true);
            //    topDownCamera.SetActive(false);
            //}
            //else if (sideCamera.activeSelf)
            //{
            //    mainCamera.SetActive(false);
            //    sideCamera.SetActive(false);
            //    topDownCamera.SetActive(true);
            //}
            //else
            //{
            //    mainCamera.SetActive(true);
            //    sideCamera.SetActive(false);
            //    topDownCamera.SetActive(false);
            //}
        }
        
    }
}
