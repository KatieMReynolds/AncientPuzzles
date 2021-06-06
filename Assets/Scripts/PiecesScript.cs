using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiecesScript : MonoBehaviour
{
    private Vector3 RightPosition; //1
    public bool InRightPosition; //2
    public bool Selected; //2
    /// Start is called before the first frame update
    void Start()
    {
        ///random arranges pieces on side
        RightPosition = transform.position; //1
        transform.position = new Vector3(Random.Range(2f, 8f), Random.Range(5f, -2f)); //1
    }

    void Update()
    {
        ///snap pieces into place
        if (Vector3.Distance(transform.position,RightPosition) < 0.5f) //1
        {
            if (!Selected) //2
            {
                if (InRightPosition == false) //3 - now only runs once not every frame
                {
                    transform.position = RightPosition; //1
                    InRightPosition = true; //2
                    GetComponent<SortingGroup>().sortingOrder = 0; //3

                    Camera.main.GetComponent<DragAndDrop>().PlacedPieces++;
                }
            }

        }

        
    }
}
