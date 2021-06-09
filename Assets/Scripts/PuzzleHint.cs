using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleHint : MonoBehaviour
{
    //public GameObject StartPanel;
    //public GameObject ButtonHint;
    public GameObject HintPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateButton()
    {
        //(gameObject.activeSelf)
        //(gameObject.activeInHierarchy == true)

        if (HintPanel.activeInHierarchy == false)
        {
            HintPanel.SetActive(true);
        } else
        {
            HintPanel.SetActive(false);
        }
    }
}
