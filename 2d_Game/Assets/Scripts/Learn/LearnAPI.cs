using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    
    private void Start()
    {
		print("輸出訊息");

		Debug.Log("輸出訊息");

		//API練習
		// 靜態(static)取得屬性
		//隨機
		print(Random.value);
		//PI
		print(Mathf.PI);
		//指數
		print(Mathf.Pow(6, 2));

		//靜態method
		print("範圍:"+Random.Range(0, 100));

		Debug.LogError("錯誤");
		Debug.LogWarning("警告");
		Debug.LogAssertion(true);
	}

	private void Update()
	{
		//每幀內取得鍵盤上的輸入
		//print(Input.inputString);
		if (Input.GetKeyDown("s"))
		{
			print("s is pressed.");
		}
	}


}
