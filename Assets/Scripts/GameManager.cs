using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public static UnityEvent OnEatFood = new();
    public static UnityEvent OnGameOver = new();
    public static UnityEvent OnGameStart = new();
    public static UnityEvent OnGamePause = new();
    public static UnityEvent OnGameResume = new();

    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private float cellSize;
    [SerializeField] private Transform gridParent;
    private Grid grid;

    void Start()
    {
        OnGameStart.AddListener(OnGameStartLogic);
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            OnGameStart?.Invoke();
        }
    }

    private void OnGameStartLogic() {
        grid = new Grid(width, height, gridParent);

        if (width % 2 == 0) {
            gridParent.transform.position = new Vector3(-width / 2, -height / 2) * cellSize +
                new Vector3(cellSize / 2, cellSize / 2);
        } else {
            gridParent.transform.position = new Vector3(-width / 2, -height / 2) * cellSize;
        }

        gridParent.transform.localScale = new Vector3(cellSize, cellSize, 1);
    }
}
