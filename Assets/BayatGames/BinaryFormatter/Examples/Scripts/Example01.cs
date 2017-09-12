using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace BayatGames.Serialization.Formatters.Binary
{

	public class Example01 : MonoBehaviour
	{

		// Use this for initialization
		void Start ()
		{
			BinaryFormatter formatter = new BinaryFormatter ();
			formatter.Serialize ( stream );
			Debug.Log ( Encoding.UTF8.GetString ( stream.ToArray () ) );
			stream.Dispose ();
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
	}

}