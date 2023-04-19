using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public Color Original;
    public Color targetColor;

    private MeshRenderer objectRenderer;
    private bool hasCollidedWithObject1;
    private bool hasCollidedWithObject2;

    void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        Original = objectRenderer.material.color;
        hasCollidedWithObject1 = false;
        hasCollidedWithObject2 = false;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected");
        if (collision.gameObject == object1)
        {
            hasCollidedWithObject1 = true;
        }

        if (collision.gameObject == object2)
        {
            hasCollidedWithObject2 = true;
        }

        if (hasCollidedWithObject1 && hasCollidedWithObject2)
        {
            objectRenderer.material.color = targetColor;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == object1)
        {
            hasCollidedWithObject1 = false;
        }

        if (collision.gameObject == object2)
        {
            hasCollidedWithObject2 = false;
        }

        if (!hasCollidedWithObject1 || !hasCollidedWithObject2)
        {
            objectRenderer.material.color = Original;
        }
    }
}
