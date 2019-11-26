using UnityEngine;

public class LearnAPI : MonoBehaviour
{


	public Transform transA;
	public Transform transB;
	public SpriteRenderer sprA;

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



		print(transA.position);
		print(transB.position);

		transA.position = new Vector3(-1, 0, 0);
		sprA.flipX = true;
		
	}

	private void Update()
	{
		//每幀內取得鍵盤上的輸入
		//print(Input.inputString);
		if (Input.GetKeyDown("s"))
		{
			print("s is pressed.");
		}


		transA.Rotate(0, 0, 2);
		transA.localScale += new Vector3(0.1f, 0.1f, 0);
		transA.Translate(0.1f, 0.1f, 0);
	}

	
}
