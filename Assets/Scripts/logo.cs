using UnityEngine;
using System.Collections;

public class logo : MonoBehaviour 
{
	public GameObject go,e,c;

	public void OnHover()
	{
		go.SetActive (true);
		e.SetActive (false);
		c.SetActive (false);

	}
}