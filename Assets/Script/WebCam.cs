using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour {

    //Camera ca;
    //Transform trans;
	public int index = 0;
	// Use this for initialization
	void Start () {	
		WebCamTexture webcamTexture = WebCamManager.Instance.Textures[index];
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
