using UnityEngine;
using System.Collections;

public class show : MonoBehaviour 
{
	public GameObject exp,cr,lg;
	
	public void OnHover()
	{
		if(exp.activeSelf == false)
		{
			exp.SetActive (true);
			cr.SetActive (false);
			lg.SetActive(false);
		}
	}
}