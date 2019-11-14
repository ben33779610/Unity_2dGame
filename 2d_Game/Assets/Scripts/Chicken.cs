using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度")]    [Range(50,2000)]
    public int      jumplevel = 0; 
    [Header("是否死亡")]    
    public bool  isdead;

    /// <summary>
    /// 小雞跳
    /// </summary>
    private void Jump()
    {

    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }
    /// <summary>
    /// 通過水管
    /// </summary>
    private void Passtube()
    {

    }
}
