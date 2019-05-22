﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.Serialization;

public class HandController : MonoBehaviour
{
    [SerializeField]
    private List<FingerJoint> fingerJoints;

    private bool configured = false;

    private void Update()
    {
        SetReadings(FindObjectOfType<BaseInputController>().GetValues());
        transform.rotation = FindObjectOfType<BaseInputController>().GetMPUValues();
    }

    public void SetReadings(int[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            fingerJoints[i].SetRotation(values[i]);
        }
    }


    public void SetReadings(List<int> values)
    {
        SetReadings(values.ToArray());
    }


    public void SetBounds(int[] lowerValues, int[] highValues)
    {
        for(int i = 0; i < Math.Min(lowerValues.Length, highValues.Length); i++)
        {
            fingerJoints[i].SetBounds(lowerValues[i], highValues[i]);
        }
    }
}