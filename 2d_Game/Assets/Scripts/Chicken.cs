﻿using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度")]    [Range(50,2000)]
    public int      jumplevel = 0; 
    [Header("是否死亡")]    
    public bool  isdead;

	[Header("分數,管理器")]
	public GameObject goScore, goGm;

	[Header("剛體")]
	public Rigidbody2D r2D;

	public GameManger gm;

	/// <summary>
	/// 小雞跳
	/// </summary>
	private void Jump()
    {

		if (isdead) return;				//若死亡 不執行此method
		//偵測到滑鼠左鍵點擊
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			goScore.SetActive(true);
			goGm.SetActive(true);
			r2D.gravityScale = 1;
			r2D.Sleep();	//讓剛體重置
			r2D.AddForce(new Vector2(0, jumplevel));  //y方向增加推力
			
		}

		//velocity剛體加速度
		r2D.SetRotation(6 * r2D.velocity.y);
	}
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
		isdead = true;
		gm.GameEnd();
	}
    /// <summary>
    /// 通過水管
    /// </summary>
    private void Passtube()
    {
		
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		print(collision.gameObject.name);
		Dead();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Dead();
	}

	private void Update()
	{
		
		
		Jump();
		
	}
}
