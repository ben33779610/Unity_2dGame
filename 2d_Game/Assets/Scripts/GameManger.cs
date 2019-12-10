using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    [Header("得分")]  
    public int point = 0 ;  //得分
    public int bestpoint;  //最高得分
	public GameObject tube; //水管物件
	public GameObject goUI;
	public Text textscore;//分數
	public Text textbest;
	private int level;
	/// <summary>
	/// 生成水管
	/// </summary>
	private void Generatetube()
	{
		if (Chicken.isdead) return;
		float rand = Random.Range(-2.5f, 1.5f);
		//Vector3 三為向量 x y z
		
		Vector3 pos = new Vector3(6.0f, rand, 0f);
		//Quaternion   x y z w
		Quaternion rot = new Quaternion(0f, 0f, 0f, 0f);
		//水管生成  
		//Object.Instantiate(tube); //既成概念Object可省略
		Instantiate(tube,pos,rot);

		
	}
	
	/// <summary>
    /// 加分
    /// </summary>
    public void Pluspoint(int add)
    {
		point += add;
		//textscore.text =  point+"";   
		textscore.text = point.ToString();
		if (point >= level)
		{
			Floor.speed += 1;
			level += 5;
		}
	}
    /// <summary>
    /// 最佳分數設定
    /// </summary>
    private void Bestpointset()
    {

		bestpoint = PlayerPrefs.GetInt("best");
		if (bestpoint < point)
		{
			bestpoint = point;
			PlayerPrefs.SetInt("best",bestpoint);			
		}
		
		textbest.text = bestpoint.ToString();
	}
    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameEnd()
    {
		
		goUI.SetActive(true);
		Bestpointset();
		Floor.speed = 0;
	}

	public void Replay()
	{
		//Application.loadedLevel("遊戲場景"); //更換遊戲場景("場景名稱")
		SceneManager.LoadScene("遊戲場景");
		Floor.speed = 3;
		
	}

	public void Exit()
	{
		Application.Quit();
	}

	private void Start()
	{
		level = 5;
		//重複調用invokrepeating ( 執行method名稱 , 延遲時間 , 隔幾秒執行一次)
		InvokeRepeating("Generatetube", 0.5f, 3.0f);

	}



}
