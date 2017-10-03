/************************************************************
************************************************************/
using UnityEngine;
using System.Collections;

/************************************************************
************************************************************/
public class Show_OnOff : MonoBehaviour {
	public GameObject[] _GameObject;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		/********************
		********************/
		if(Input.GetKeyDown(KeyCode.S)){
			for(int i = 0; i < _GameObject.Length; i++){
				/********************
				通常、GameObjectには、MeshRendeererがaddされているが、これはRendererからの派生class.
					https://docs.unity3d.com/jp/540/ScriptReference/MeshRenderer.html
						MeshRenderer
						class in UnityEngine/Inherits from: Renderer
				
				あくまで、rendering機能のon/off.
				********************/
				Renderer Renderer = _GameObject[i].GetComponent<Renderer>();
				Renderer.enabled = true;
			}
		}else if(Input.GetKeyDown(KeyCode.H)){
			for(int i = 0; i < _GameObject.Length; i++){
				Renderer Renderer = _GameObject[i].GetComponent<Renderer>();
				Renderer.enabled = false;
			}
		}
	}
}
