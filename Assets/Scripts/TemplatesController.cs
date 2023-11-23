using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplatesController : MonoBehaviour
{

    public GameObject baseMain;
    public GameObject drums;
    public GameObject melody1;
    public GameObject pads;
    public GameObject bass;
    public GameObject melody2;

    // Update is called once per frame
    void Update()
    {
        baseMain.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        drums.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        melody1.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        pads.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        bass.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        melody2.transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}
