/************************************************************
GO_TargetにBoneのObjectを指定すれば、本scriptがattachされたObjectは、Bone Objectについていく.
************************************************************/
using UnityEngine;
using System.Collections;

/************************************************************
************************************************************/
public class TargetPosition : MonoBehaviour {
	public GameObject GO_Target;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = GO_Target.transform.position;
	}
}
