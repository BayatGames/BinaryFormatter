using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Reflection;

namespace BayatGames.Serialization.Formatters.Binary
{

	public class BinaryObjectReader : IDisposable
	{

		#region Fields

		/// <summary>
		/// The reader.
		/// </summary>
		protected BinaryReader m_Reader;

		/// <summary>
		/// The surrogate selector.
		/// </summary>
		protected ISurrogateSelector m_SurrogateSelector;

		/// <summary>
		/// The context.
		/// </summary>
		protected StreamingContext m_Context;

		#endregion

		#region Properties

		/// <summary>
		/// Gets the reader.
		/// </summary>
		/// <value>The reader.</value>
		public virtual BinaryReader reader
		{
			get
			{
				return m_Reader;
			}
		}

		/// <summary>
		/// Gets or sets the surrogate selector.
		/// </summary>
		/// <value>The surrogate selector.</value>
		public virtual ISurrogateSelector surrogateSelector
		{
			get
			{
				return m_SurrogateSelector;
			}
			set
			{
				m_SurrogateSelector = value;
			}
		}

		/// <summary>
		/// Gets or sets the context.
		/// </summary>
		/// <value>The context.</value>
		public virtual StreamingContext context
		{
			get
			{
				return m_Context;
			}
			set
			{
				m_Context = value;
			}
		}

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/> class.
		/// </summary>
		/// <param name="stream">Stream.</param>
		public BinaryObjectReader ( Stream stream ) : this ( stream, null, new StreamingContext ( StreamingContextStates.All ) )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/> class.
		/// </summary>
		/// <param name="reader">Reader.</param>
		public BinaryObjectReader ( BinaryReader reader ) : this ( reader, null, new StreamingContext ( StreamingContextStates.All ) )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/> class.
		/// </summary>
		/// <param name="stream">Stream.</param>
		/// <param name="selector">Selector.</param>
		/// <param name="context">Context.</param>
		public BinaryObjectReader ( Stream stream, ISurrogateSelector selector, StreamingContext context ) : this ( new BinaryReader ( stream ), selector, context )
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/> class.
		/// </summary>
		/// <param name="reader">Reader.</param>
		/// <param name="selector">Selector.</param>
		/// <param name="context">Context.</param>
		public BinaryObjectReader ( BinaryReader reader, ISurrogateSelector selector, StreamingContext context )
		{
			m_Reader = reader;
			m_SurrogateSelector = selector;
			m_Context = context;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Read the specified type.
		/// </summary>
		/// <param name="type">Type.</param>
		public virtual object Read ( Type type )
		{
			object result = null;
			if ( type == null )
			{
				result = null;
			}
			return result;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		/// <filterpriority>2</filterpriority>
		/// <remarks>Call <see cref="Dispose"/> when you are finished using the
		/// <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/>. The <see cref="Dispose"/> method leaves the
		/// <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/> in an unusable state. After calling
		/// <see cref="Dispose"/>, you must release all references to the
		/// <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/> so the garbage collector can reclaim the memory
		/// that the <see cref="BayatGames.Serialization.Formatters.Binary.BinaryObjectReader"/> was occupying.</remarks>
		public virtual void Dispose ()
		{
		}

		#endregion
		
	}

}