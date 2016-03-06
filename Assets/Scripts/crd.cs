using UnityEngine;
using System.Collections;

public class crd : MonoBehaviour 
{
	public GameObject exp,cr,lg;
	
	public void OnHover()
	{
		if(cr.activeSelf == false)
		{
			cr.SetActive (true);
			exp.SetActive (false);
			lg.SetActive (false);
		}
	}
}