using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BayatGames.Serialization.Formatters.Binary
{

	public class Example01 : MonoBehaviour
	{
		
		[SerializeField]
		protected InputField m_Input;
		[SerializeField]
		protected InputField m_Output;
		protected byte [] m_Buffer;

		public void Serialize ()
		{
			if ( !string.IsNullOrEmpty ( m_Input.text ) )
			{
				m_Buffer = BinaryFormatter.SerializeObject ( m_Input.text );
				m_Output.text = System.Text.Encoding.UTF8.GetString ( m_Buffer );
				Debug.Log ( "Successfully Serialized" );
				Debug.Log ( "String Value: " + m_Output.text );
				Debug.Log ( "Buffer Length: " + m_Buffer.Length );
			}
			else
			{
				Debug.LogError ( "Can't Serialize an empty string" );
			}
		}

		public void Deserialize ()
		{
			if ( m_Buffer != null && m_Buffer.Length > 0 )
			{
				m_Buffer = System.Text.Encoding.UTF8.GetBytes ( m_Output.text );
				m_Input.text = ( string )BinaryFormatter.DeserializeObject ( m_Buffer, typeof ( string ) );
				Debug.Log ( "Successfully Deserialized" );
				Debug.Log ( "String Value: " + m_Input.text );
				Debug.Log ( "Buffer Length: " + m_Buffer.Length );
			}
			else
			{
				Debug.LogError ( "Can't Deserialize from an empty buffer." );
			}
		}
		
	}

}