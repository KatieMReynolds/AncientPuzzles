using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleSelect : MonoBehaviour
{
    public GameObject StartPanel;
    //StartPanel is not a panel, but the image background renamed
    public void SetPuzzlesPhoto(Image Photo)
    {
        //TO DO: GET THE SELECTED SCENE AND SEND THAT DATA TO THE NEXT SCENE

        //assigns parts of the puzzle image to the corresponding pieces
        for (int i = 0; i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);
        //SceneManager.LoadScene(2);//loads next scene
    }
}
