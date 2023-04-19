using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using SimInfo;

public class Accelerator : MonoBehaviour
{
    public GameObject object2;
    public GameObject object3;
    public Vector3 originalPosition;
    public bool move = false;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        if (move)
        {
            Vector3 vib = 0.0001f * new Vector3(10000, 0, 0);
            transform.localPosition = new Vector3(10, 0, 0); ;
            object2.transform.localPosition = vib;
            object3.transform.localPosition = vib;
        }
    }

    public void OnMouseUpAsButton()
    {
        Debug.Log("HERE");
        if (move)
            move = false;
        else
            move = true;
    }
}