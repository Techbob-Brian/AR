using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VTBN : MonoBehaviour
{
    public GameObject plate;
    public VirtualButtonBehaviour Vb;

    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        plate.SetActive(false);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        plate.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        plate.SetActive(false);
    }
}
