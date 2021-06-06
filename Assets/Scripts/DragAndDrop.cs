using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DragAndDrop : MonoBehaviour
{
    public GameObject EndPanel;
    public GameObject SelectedPiece; //1
    int OIL = 1; //3 - order in layer - for moving pieces on top when selected
    public int PlacedPieces = 0;


    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //1
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero); //1
            if (hit.transform.CompareTag("PuzzleTag")) //1
            {
                if (!hit.transform.GetComponent<PiecesScript>().InRightPosition) //2 - Locks pieces in place
                {
                    SelectedPiece = hit.transform.gameObject; //1
                    SelectedPiece.GetComponent<PiecesScript>().Selected = true; //2 - this fixes weird placing issue
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL; //3
                    OIL++; //3
                }
            }
        }

        if (Input.GetMouseButtonUp(0)) //1
        {
            if (SelectedPiece != null) //3 - removes an error
            {
                SelectedPiece.GetComponent<PiecesScript>().Selected = false; //2 - goes with line 25
                SelectedPiece = null; //1
            }
            
        }
        if (SelectedPiece != null) //1
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition); //1
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0); //1
        }
        if (PlacedPieces == 36)
        {
            EndPanel.SetActive(true);
        }
    }
}
