using UnityEngine;

public class Learnlogic : MonoBehaviour

{

	public int combo = 0;

	void OnMouseDown()
	{
		print("noo");
	}

	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (combo >= 50 && combo < 100)
			print("atk*2");
		else if (combo >= 100 && combo < 150)
			print("atk*5");
		else if (combo >= 150)
			print("atk*10");
			

	}
}
