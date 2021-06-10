using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuzzleSelect : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject EndPanel;
    public GameObject BackButton1;
    public GameObject BackButton2;
    public GameObject HintImage;
    //StartPanel is not a panel, but the image background renamed

    public void SetPuzzlesPhoto(Image Photo)
    {
        for (int i = 0; i < 36; i++)
        {
            GameObject.Find("Piece (" + i + ")").transform.Find("Puzzle").GetComponent<SpriteRenderer>().sprite = Photo.sprite;
        }
        StartPanel.SetActive(false);
    }

    public void SetHintPhoto(Image Photo)
    {
        HintImage.gameObject.GetComponent<SpriteRenderer>().sprite = Photo.sprite;
    }

    public void FinishBack()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        StartPanel.SetActive(true);
        EndPanel.SetActive(false);

    }

    public void BackSelect()
    {

    }

}
