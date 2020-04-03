using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningZone : MonoBehaviour
{
    [SerializeField] GameObject WinningPanel;


    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("won");
            Time.timeScale = 0.0f;
            WinningPanel.SetActive(true);
        }
    }
}
