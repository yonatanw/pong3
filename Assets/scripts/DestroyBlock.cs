using UnityEngine;
using System.Collections;

public class DestroyBlock : MonoBehaviour {
    public float destroyTime = 0.25f;
    public  void mDestroyBlock()
    {
        
        //AudioSource.PlayClipAtPoint(hit2sfx, new Vector3(0, 0, 0));
        Debug.Log("Destroyed!");
    }
	
}
