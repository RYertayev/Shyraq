using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private DragAndDrop triangle;
    [SerializeField] private DragAndDropSquare square;
    [SerializeField] private Capsule _capusle;
    [SerializeField] private GameObject NextLevel_panel;
    [SerializeField] private GameObject GameModels;
    [SerializeField] private GameObject settings;
    // Start is called before the first frame update
    void Start()
    {
        NextLevel_panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(triangle.counter_triangle == 1 && square.counter_square == 1 && _capusle.counter_capsule == 1)
       {
        NextLevel_panel.SetActive(true);
        GameModels.SetActive(false);
        settings.SetActive(false);
       }
    }
   
}
