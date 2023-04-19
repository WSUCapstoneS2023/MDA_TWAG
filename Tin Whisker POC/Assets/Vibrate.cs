using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using SimInfo;

public class Vibrate : MonoBehaviour
{
    public GameObject object2;
    public GameObject object3;
    public Vector3 originalPosition;
    public bool vibrate = false;
    public Vector3 cap = new Vector3(0.001f, 0.001f, 0.001f), counter = new Vector3(0.0f, 0.0f, 0.0f);

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        if (vibrate)
        {
            System.Random rnd = new System.Random();
            var intensity = 0.00005f;
            Vector3 vib = intensity * new Vector3(rnd.Next(0, 101) - 50, rnd.Next(0, 101) - 50, rnd.Next(0, 101) - 50);
            counter += vib;
            if (counter.magnitude >= cap.magnitude) //check to see if the objects move too far from the original position
            {
                transform.localPosition -= vib;
                object2.transform.localPosition -= vib;
                object3.transform.localPosition -= vib;
                counter -= vib;
            }
            else
            {
                transform.localPosition += vib;
                object2.transform.localPosition += vib;
                object3.transform.localPosition += vib;
            }
        }
    }

    public void OnMouseUpAsButton()
    {
        Debug.Log("HERE");
        if (vibrate)
            vibrate = false;
        else
            vibrate = true;
    }
}
