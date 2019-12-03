using UnityEngine;

public class GameManger : MonoBehaviour
{
    [Header("得分")]  [Range(0,999)]
    public int point;  //得分
    public int bestpoint;  //最高得分
	public GameObject tube; //水管物件
	public GameObject goUI;
	/// <summary>
	/// 生成水管
	/// </summary>
	private void Generatetube()
	{
		float rand = Random.Range(-1f, 0.6f);
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
    public void Pluspoint()
    {

    }
    /// <summary>
    /// 最佳分數設定
    /// </summary>
    private void Bestpointset()
    {

    }
    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameEnd()
    {
		
		goUI.SetActive(true);
    }


	private void Start()
	{
		//重複調用invokrepeating ( 執行method名稱 , 延遲時間 , 隔幾秒執行一次)
		InvokeRepeating("Generatetube", 0.5f, 3.0f);
	}

	private void Update()
	{
		
	}

}
