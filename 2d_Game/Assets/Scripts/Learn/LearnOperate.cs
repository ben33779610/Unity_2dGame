using UnityEngine;

public class LearnOperate : MonoBehaviour
{

	public int a = 10;
	public int b = 2;


    void Start()
    {
		print(a++);  // 先執行輸出(a值==10)再加一
		print(++a);  //先執行加一再輸出(a值==12)



		print(true && true);
		print(false && true);
		print(false && false);

		print(!true);
		print(!false);

		print(a >= 15 && b > 0);


    }


	
}
