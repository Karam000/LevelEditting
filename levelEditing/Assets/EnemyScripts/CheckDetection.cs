﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CheckDetection : MonoBehaviour
{
   
    [SerializeField] GameObject _RestartPanel;
    float TaregtTime = 1.0f;

    void Start()
    {
        Time.timeScale = 1.0f;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Founded");
            TaregtTime -= Time.deltaTime;

        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            TaregtTime -= Time.deltaTime;
            if(TaregtTime < 0)
            {
                Debug.Log("Detected");
                _RestartPanel.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TriggerExit");
            TaregtTime = 10.0f;
        }
    }
   
}
