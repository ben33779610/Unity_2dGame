using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("跳躍高度")]    [Range(50,2000)]
    public int      jumplevel = 0; 
    [Header("是否死亡")]    
    public static bool  isdead;

	[Header("分數,管理器")]
	public GameObject goScore, goGm;

	[Header("剛體")]
	public Rigidbody2D r2D;

	public GameManger gm;

	public AudioSource auo;

	public AudioClip auoJump, auoHit, auoadd;

	private float cd,curcd;
	private bool canjump;

	/// <summary>
	/// 小雞跳
	/// </summary>
	private void Jump()
    {

		if (isdead) return;				//若死亡 不執行此method
		//偵測到滑鼠左鍵點擊
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			if (canjump)
			{
				goScore.SetActive(true);
				goGm.SetActive(true);
				r2D.gravityScale = 1;
				r2D.Sleep();    //讓剛體重置
				r2D.AddForce(new Vector2(0, jumplevel));  //y方向增加推力
				auo.PlayOneShot(auoJump, 1);
				curcd += Time.deltaTime;
				canjump = false;
			}
		}
		if (Input.GetKeyDown(KeyCode.Mouse1))
		{
			r2D.gravityScale = 4;
		}

		//velocity剛體加速度
		r2D.SetRotation(6 * r2D.velocity.y);
	}

	private void CanJump()
	{
		if (curcd >= cd || cd==0)
		{
			curcd = 0;
			canjump = true;
		}
		else
		{
			curcd += Time.deltaTime;
		}

	}
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {
		if (isdead) return;
		auo.PlayOneShot(auoHit, 1);
		isdead = true;
		gm.GameEnd();
		
	}
    /// <summary>
    /// 通過水管
    /// </summary>
    private void Passtube()
    {
		if (isdead) return;
		gm.Pluspoint(1);
    }




	private void Start()
	{
		Chicken.isdead = false;
		Screen.SetResolution(720, 1280, false); // 設定遊戲螢幕大小(寬,高,是否全螢幕)
		cd = 0.5f;
		curcd = 0;
		canjump = true;
	}

	private void Update()
	{
		CanJump();
		Jump();
		
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		//print(collision.gameObject.name);
		Dead();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "加分區域")
		{
			Passtube();
		}
		if (collision.gameObject.name == "水管上" || collision.gameObject.name == "水管下")
		{
			Dead();
		}

	}
}
