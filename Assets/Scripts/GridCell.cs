using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCell : MonoBehaviour
{
    private bool hasSnake;
    private bool hasFood;
    private bool hasObstacle;
    private bool hasPowerUp;
    private int x;
    private int y;
    private Sprite originalSprite;

    public GridCell(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public void SetHasSnake(bool hasSnake) {
        this.hasSnake = hasSnake;
    }

    public void SetHasFood(bool hasFood) {
        this.hasFood = hasFood;

        if (hasFood) {
            SetSprite(Assets.Instance.food);
        } else {
            SetSprite(originalSprite);
        }
    }

    public void SetAsObstacle() {
        hasObstacle = true;
        GetComponent<SpriteRenderer>().sprite = Assets.Instance.obstacle;
    }

    public void SetHasPowerUp(bool hasPowerUp) {
        this.hasPowerUp = hasPowerUp;
    }

    public bool GetHasSnake() {
        return hasSnake;
    }

    public bool GetHasFood() {
        return hasFood;
    }

    public bool GetHasObstacle() {
        return hasObstacle;
    }

    public bool GetHasPowerUp() {
        return hasPowerUp;
    }

    public int GetX() {
        return x;
    }

    public int GetY() {
        return y;
    }

    public void SetOriginalSprite(Sprite sprite) {
        originalSprite = sprite;
    }

    public void SetSprite(Sprite sprite) {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
}
