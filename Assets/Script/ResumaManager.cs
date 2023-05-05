using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumaManager : MonoBehaviour
{

    public GameObject language;
    public GameObject skills;


    public void OnLanguage()
    {
        language.SetActive(true);
        skills.SetActive(false);
    }

    public void OnSkills()
    {
        skills.SetActive(true);
        language.SetActive(false);
    }
}
