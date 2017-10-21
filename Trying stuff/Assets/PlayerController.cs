using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public GameObject line = new GameObject ();
	public Vector3 place = new Vector3 (0,0,-1);
	protected int i = 1;

		// Use this for initialization
	void Start ()
	{
		i = 1;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetMouseButtonDown(0))
			{
			
			DrawLine (new Vector3 (i-5, 0, -1), new Vector3 (i, 0, -1), new Color (250,0,0), 0.0f);
			i = i + 5;
			}	
	}

	void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 2f)
	{
		GameObject myLine = new GameObject();
		myLine.transform.position = start;
		myLine.AddComponent<LineRenderer>();
		LineRenderer lr = myLine.GetComponent<LineRenderer>();
		lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
		lr.SetColors(color, color);
		lr.SetWidth(0.1f, 0.1f);
		lr.SetPosition(0, start);
		lr.SetPosition(1, end);
		GameObject.Destroy(myLine, duration);
	}
}
