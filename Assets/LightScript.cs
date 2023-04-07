using UnityEngine;
using System.Collections;

public class LightScript : MonoBehaviour
{
    public Light theLight;


    void Start()
    {
        theLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            theLight.enabled = !theLight.enabled;
        }
    }
}