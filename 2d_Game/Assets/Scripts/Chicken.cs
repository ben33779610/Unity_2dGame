using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度")]    [Range(50,2000)]
    public int      jumplevel = 0; 
    [Header("是否死亡")]    
    public bool  isdead;

	[Header("分數,管理器")]
	public GameObject goScore, goGm;

    /// <summary>
    /// 小雞跳
    /// </summary>
    private void Jump()
    {
		//偵測到滑鼠左鍵點擊
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			goScore.SetActive(true);
			goGm.SetActive(true);
		}
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


	private void Update()
	{
		Jump();
	}
}
