using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleSelect : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject BackButton1;
    public GameObject BackButton2;
    //StartPanel is not a panel, but the image background renamed
    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);
        BackButton1.SetActive(false);
        BackButton2.SetActive(true);
        
    }

    public void BackSelect()
    {
        //StartPanel.SetActive(true);//BackButton1.SetActive(true);//BackButton2.SetActive(false);
        
        //This fixes the puzzle piecees not resetting when loading a new puzzle, just resets the whole scene
    }

    public void FinishBack()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

    }
}
