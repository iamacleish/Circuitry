using UnityEngine;
using System.Collections;

public class SpawnNewObj : MonoBehaviour {
	private Vector3 offset;
	public GameObject nMosTransistor;
	GameObject nMosTransistorSpawn;
	int gridx = 10;
	int gridy = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
//todo: raycast
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		Cursor.visible = false;
		nMosTransistorSpawn = (GameObject)Instantiate(nMosTransistor, new Vector3(curPosition.x, curPosition.y, 0), Quaternion.identity);
	}

	void OnMouseDrag() 
	{ 
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		curPosition.z = 0;
		nMosTransistorSpawn.transform.position = curPosition;
		//transform.position = curPosition;
		//}
	}


	void OnMouseUp()
	{
		Cursor.visible = true;
		Vector3 curScreenPoint = new Vector3 (nMosTransistorSpawn.transform.position.x, nMosTransistorSpawn.transform.position.y, 0);
		nMosTransistorSpawn.transform.position = new Vector3 (Mathf.Round (curScreenPoint.x / gridx) * gridx, Mathf.Round (curScreenPoint.y / gridy) * gridy, 0);
	}
}
