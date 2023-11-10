using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseObject;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) PauseUnpause();
    }

    public void PauseUnpause()
    {
        Debug.Log("Test");
        if(!PauseObject.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            PauseObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            PauseObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
