using UnityEngine;

public class Floor : MonoBehaviour
{
    [Header("地板移動速度")]  [Range(0.1f,100)]
    public float speed = 1.0f;
	[Header("地板TRANSFORM")]
	public Transform floortrans;


    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
		floortrans.Translate(-speed*Time.deltaTime,0 , 0);
		
	}

	private void Update()
	{
		Move();
	}
}
