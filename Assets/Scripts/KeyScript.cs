using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject HintPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            HintPanel.SetActive(true);
        }
        if (Input.GetKeyUp("space"))
        {
            HintPanel.SetActive(false);
        }
    }
}
