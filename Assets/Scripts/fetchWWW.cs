using UnityEngine;
using System.Collections;

public class fetchWWW : MonoBehaviour 
{
	public string url = "https://upload.wikimedia.org/wikipedia/commons/c/c8/Taj_Mahal_in_March_2004.jpg";
	public GameObject g;
	public Texture img;

	/*To fetch image texture from a URL.
	IEnumerator Start()
	{
		WWW ob = new WWW (url);
		yield return ob;
		g.renderer.material.mainTexture = ob.texture;
	}*/

	//To fetch image texture from a file.
	void Update()
	{
		g.renderer.material.mainTexture = img;
	}
}