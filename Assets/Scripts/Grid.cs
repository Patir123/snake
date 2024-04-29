using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private int width;
    private int height;
    private Transform gridParent;
    private GridCell[,] gridCells;
    private GridCell snakeHeadSpawnPoint;

    public Grid(int width, int height, Transform gridParent) {
        this.width = width;
        this.height = height;
        this.gridParent = gridParent;
        gridCells = new GridCell[width, height];

        CreateGrid();
    }

    private void CreateGrid() {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                CreateGridCell(new Vector3(x, y));
            }
        }

        PlaceFood();
    }

    private void CreateGridCell(Vector3 position) {
        GameObject cell = new($"gridCell {position.x} : {position.y}",typeof(SpriteRenderer));
        cell.transform.parent = gridParent;
        cell.transform.localPosition = position;
        GridCell gridCell = cell.AddComponent<GridCell>();
        gridCells[(int)position.x, (int)position.y] = gridCell;

        if (position.x == 0 || position.x == width - 1 || position.y == 0 || position.y == height - 1) {
            gridCell.SetAsObstacle();
        } else {
            // make a chess board pattern
            if ((position.x + position.y) % 2 == 0) {
                cell.GetComponent<SpriteRenderer>().sprite = Assets.Instance.cell;
            } else {
                cell.GetComponent<SpriteRenderer>().sprite = Assets.Instance.cell2;
            }
        }

        gridCell.SetOriginalSprite(cell.GetComponent<SpriteRenderer>().sprite);
    }

    private void PlaceFood() {
        int x = Random.Range(1, width - 1);
        int y = Random.Range(1, height - 1);

        GridCell gridCell = gridCells[x, y];
        gridCell.SetHasFood(true);
    }
}
