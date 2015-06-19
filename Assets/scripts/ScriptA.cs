using UnityEngine;
using System.Collections;

public class ScriptA : MonoBehaviour {
   

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	 void Update () {
        ScriptB.DoSomething();
	
	}
}
