using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager2 : MonoBehaviour
{
    public DragAndDrop triangle;
    public DragAndDropSquare square;
    public Capsule _capusle;
    public HexagonFT hexagonFT;
    public GameObject NextLevel_panel;
    public GameObject GameModels;
    // Start is called before the first frame update
    void Start()
    {
        NextLevel_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(triangle.counter_triangle == 1 && square.counter_square == 1 && _capusle.counter_capsule == 1
       && hexagonFT.counter_hexagon_ft == 1)
       {
        NextLevel_panel.SetActive(true);
        GameModels.SetActive(false);
       }
    }
    public void ThirdLevelPuzzle()
    {
        SceneManager.LoadScene(3);
    }
}
