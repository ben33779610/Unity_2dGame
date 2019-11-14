using UnityEngine;

public class GameManger : MonoBehaviour
{
    [Header("得分")]  [Range(0,999)]
    public int point;  //得分
    [Header("最佳得分")]   [Range(0, 999)]
    public int bestpoint;  //最高得分

}
