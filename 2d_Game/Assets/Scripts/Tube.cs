

public class Tube : Floor
{


	//在鏡頭看不到時執行
	private void OnBecameInvisible()
	{
		
		Destroy(gameObject, 2);//破壞(物件,延遲)
	}

	//在鏡頭看到時執行
	private void OnBecameVisible()
	{
		
	}

}
