using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour {
    public float MoveSpeed = 10.0f;
    private textset blood;
	// Use this for initialization
	void Start () {
        blood = GameObject.Find("Canvas/Text").GetComponent<textset>();
	}
	

    
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
        }
        blood.a = 1;
	}
}
