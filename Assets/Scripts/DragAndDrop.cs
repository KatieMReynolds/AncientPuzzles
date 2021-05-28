using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    public GameObject SelectedPiece;
    int OIL = 1; //order in layer

    //Start is enabled before any Update methods and called only once
    void Start()
    {
    }
    //Update is called every frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform.CompareTag("PuzzleTag"))
            {
                SelectedPiece = hit.transform.gameObject;
            }
        }

        if (SelectedPiece != null)
        {
            SelectedPiece.transform.position = new Vector3(Mouse)
        }
    }
}
