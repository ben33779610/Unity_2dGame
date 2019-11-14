using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度")]    [Range(0,2000)]
    public int      jumplevel = 0; 
    [Header("是否死亡")]    
    public bool  dead;

}
