using System.Collections;
using System.Collections.Generic;

namespace BayatGames.Serialization.Formatters.Binary
{

	/// <summary>
	/// Binary extensions.
	/// </summary>
	public static class BinaryExtensions
	{

		/// <summary>
		/// Serializes the object to it's binary representation.
		/// </summary>
		/// <returns>The binary.</returns>
		/// <param name="value">Value.</param>
		public static byte[] ToBinary ( this object value )
		{
			return BinaryFormatter.SerializeObject ( value );
		}
		
	}

}