﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnEscape : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
