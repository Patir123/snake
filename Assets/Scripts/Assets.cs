using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assets : MonoBehaviour
{
    public static Assets Instance;

    private void Awake() {
        Instance = this;
    }

    public Sprite snakeHeadTop;
    public Sprite snakeHeadRight;
    public Sprite snakeHeadBottom;
    public Sprite snakeHeadLeft;
    public Sprite snakeBodyVertical;
    public Sprite snakeBodyHorizontal;
    public Sprite snakeTailTop;
    public Sprite snakeTailRight;
    public Sprite snakeTailBottom;
    public Sprite snakeTailLeft;
    public Sprite snakeBodyTopRight;
    public Sprite snakeBodyTopLeft;
    public Sprite snakeBodyBottomRight;
    public Sprite snakeBodyBottomLeft;
    public Sprite food;
    public Sprite obstacle;
    public Sprite powerUp;
    public Sprite cell;
    public Sprite cell2;
}
