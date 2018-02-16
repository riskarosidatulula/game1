using UnityEngine;
using System.Collections;

public class TongController : MonoBehaviour {

	public float speed;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			goleft ();
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			goright ();
		}
		/*if(Input.GetKey(KeyCode.UpArrow)){
			goford ();
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			goback ();
		}*/

	}

	//===========================================================

	private void goleft(){
		transform.Translate (Vector3.left * speed * Time.deltaTime);
	}

	private void goright ()
	{
		transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	private void goford ()
	{
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	private void goback ()
	{
		transform.Translate (Vector3.back * speed * Time.deltaTime);
	}
}