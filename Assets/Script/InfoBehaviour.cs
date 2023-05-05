using System;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{
    const float SPEED = 6f; 

    [SerializeField]
    Transform SectionInfo;

    Vector3 desiredScale = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }
    public void OpenInfo()
    {
        desiredScale = new Vector3(0.1f,0.1f,0.1f) ;
    }

    public void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }

}
