using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropSquare : MonoBehaviour
{
    public AudioSource source;
    public AudioClip check;
    public AudioClip aplodismenty;
    private bool isDrag = true;
    private Rigidbody2D rb;
    public int counter_square;
 
    public List<Transform> puzzleObjects;
    public List<Transform> spawnPoints;
    private void Start() {
        
        rb = GetComponent<Rigidbody2D>();

        System.Random rng = new System.Random();
        int n = puzzleObjects.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = puzzleObjects[k];
            puzzleObjects[k] = puzzleObjects[n];
            puzzleObjects[n] = value;
        }

        PlacePuzzlePiecesRandomly();
    }
    private void OnMouseDrag() {
        if(isDrag)
        {
          this.transform.position = GetMousePosition();
        }
    }
    private Vector3 GetMousePosition()
    {
        var _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _mousePosition.z = 0;
        return _mousePosition;
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "square")
        {
            isDrag = false;
            other.gameObject.SetActive(false);
            this.transform.position = other.transform.position;
            rb.isKinematic = true;
            source.PlayOneShot(check);
            counter_square++;
        }
        if(counter_square==1)
        {
            source.PlayOneShot(aplodismenty);
        }
    }
    private void PlacePuzzlePiecesRandomly()
    {
        // Разместить фигуры на случайных позициях из списка spawnPoints
        foreach (var puzzleObjects in puzzleObjects)
        {
            if (spawnPoints.Count == 0)
            {
                Debug.LogWarning("Not enough spawn points!");
                return;
            }

            int randomIndex = Random.Range(0, spawnPoints.Count);
            var spawnPoint = spawnPoints[randomIndex];

            puzzleObjects.position = spawnPoint.position;

            // Удалить использованную позицию из списка, чтобы не повторяться
            spawnPoints.RemoveAt(randomIndex);
        }
    }
    
}
