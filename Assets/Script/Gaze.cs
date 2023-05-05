using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Gaze : Singleton<Gaze>
{
    public List<InfoBehaviour> infos = new List<InfoBehaviour>();
    private int maxDistance = 10;
    private float sphereRad = 0.1f;


    public void Start()
    {
        UpdateInfos();
    }

    void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out RaycastHit hit))
        {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo"))
            {   
                OpenInfo(go.GetComponent<InfoBehaviour>());
            }
            else
            {
                CloseAll(); 
            }
        }
        
    }

    void OpenInfo(InfoBehaviour desiredInfo)
    {
  
        foreach (InfoBehaviour info in infos)
        {
            if (info == desiredInfo)
                info.OpenInfo();
            else
                info.CloseInfo();
        }
    }

    private void CloseAll()
    {
        foreach (InfoBehaviour info in infos)
            info.CloseInfo();
    }

    public void UpdateInfos()
    {
        infos = FindObjectsOfType<InfoBehaviour>().ToList();
    }

}
