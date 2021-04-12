using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Color myColor;
    public float rFloat;
    public float gFloat;
    public float bFloat;
    public float aFloat;

    public Renderer myRenderer;

    // Update is called once per frame
    void Start()
    {
        aFloat = 1;
        myRenderer = gameObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            if(aFloat<1)
            {
                aFloat += 0.01f;
            }
            else
            {
                aFloat = 0;
            }
        }

        if (Input.GetKey(KeyCode.R))
        {
            if (rFloat < 1)
            {
                rFloat += 0.01f;
            }
            else
            {
                rFloat = 0;
            }

        }

        if (Input.GetKey(KeyCode.G))
        {
            if (gFloat < 1)
            {
                gFloat += 0.01f;
            }
            else
            {
                gFloat = 0;
            }

        }

        if (Input.GetKey(KeyCode.B))
        {
            if (bFloat < 1)
            {
                bFloat += 0.01f;
            }
            else
            {
                bFloat = 0;
            }

        }
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        myRenderer.material.color = myColor;
    }
}
