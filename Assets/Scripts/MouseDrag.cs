using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {
	private Vector3 screenPoint;
	private Vector3 offset;
	private float _lockedYPosition;
	int gridx = 10;
	int gridy = 10;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnMouseDown() {
		//screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); // I removed this line to prevent centring 
		//_lockedYPosition = screenPoint.y;
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		Cursor.visible = false;
		
		
		
		
	}

	void OnMouseDrag() 
	{ 
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		//float distance = Vector3.Distance (curPosition, transform.position);
		//curPosition.x = _lockedYPosition;
		//if (distance >= 100) {

		transform.position = curPosition;
		//}
	}

	void OnMouseUp()
	{
		Cursor.visible = true;
		Vector3 curScreenPoint = new Vector3(transform.position.x, transform.position.y, 0);
		transform.position = new Vector3(Mathf.Round(curScreenPoint.x/gridx)*gridx, Mathf.Round(curScreenPoint.y/gridy)*gridy, 0);


		//Debug.Log (Input.mousePosition.x + " + " + Input.mousePosition.y);
		//curScreenPoint = curScreenPoint + offset;
		//curScreenPoint.x = Mathf.Round (curScreenPoint.x/gridx)*gridx;
		//curScreenPoint.y = Mathf.Round (curScreenPoint.y/gridy)*gridy;
		//Debug.Log ("z: " + curScreenPoint.z);
		//transform.position = curScreenPoint;
		Debug.Log (transform.position);

	}
	
}