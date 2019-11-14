using UnityEngine;  //  引用Unity的API


//     類別  類別名稱
public class First : MonoBehaviour
{
    //修飾詞  public private  若沒有 預設為 private
    public int    level = 100;                   //整數      預設值0
    public float speed = 1.00f;  //浮點數  預設值0
    public string prop = "藍色藥水";                 //字串      預設""
    public bool mission = true;             //布林值  預設false

    [Header("血量")]  //[Header ("字串 ")]   
    public int hp = 100;
    [Header("速度")]  [Range(0,2.00f)]
    public float speed2;
    [Header("死亡")]  [Tooltip("是否死亡,打勾:死亡,沒勾:活著")]
    public bool dead;
    [Header("魔力")]  [Range(0, 999)]
    public int mp;

    
}
