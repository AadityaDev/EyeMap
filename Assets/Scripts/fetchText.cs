using UnityEngine;
using System.Collections;

public class fetchText : MonoBehaviour 
{

	public TextAsset ta;
	public GUIText gt;

	private string s;
	private ArrayList line;

	void Start()
	{
		s = ta.text;
		line = new ArrayList();

		line.AddRange (s.Split("\n"[0]));

		/*First Approach
		gt.text = "" + line [0] + "\n"       --To set GUIText with content of text file
			      + line [1] + "\n"
				+ line [2];

		*/

		//Second Approach
		for(int i = 0 ; i < line.Count ; i++)
			gt.text = gt.text + line[i] + "\n";
		 
		//Debug.Log (line[1]);               --To display particular line at console.
	}
}