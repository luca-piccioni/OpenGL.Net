
// Copyright (C) 2012-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGL.Objects
{
	/// <summary>
	/// Generic media codec criteria.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Classes deriving from <see cref="MediaCodec{TPlugin,TMedia,TMediaInfo}"/> needs a generic method for specifying
	/// a set of parameters to be passed with specific media codec plugin implementation.
	/// </para>
	/// <para>
	/// This class is the container of parameters used by <see cref="MediaCodec{TPlugin,TMedia,TMediaInfo}"/>. Parameters
	/// are identified with a generic invariant string, while the parameter is a generic object.
	/// </para>
	/// </remarks>
	public class MediaCodecCriteria
	{
		#region Criteria Collection

		/// <summary>
		/// Define a criteria.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="String"/> that specify the criteria value name.
		/// </param>
		/// <param name="value">
		/// A <see cref="Object"/> that specify the criteria value. It can null.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="criteriaName"/> is null.
		/// </exception>
		public void Set(string criteriaName, object value)
		{
			if (criteriaName == null)
				throw new ArgumentNullException("criteriaName");

			// Define or overwrite criteria value
			_Criteria[criteriaName] = value;
		}

		/// <summary>
		/// Undefine a criteria.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="String"/> that specify the criteria value name.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="criteriaName"/> is null.
		/// </exception>
		public void Reset(string criteriaName)
		{
			if (criteriaName == null)
				throw new ArgumentNullException("criteriaName");

			_Criteria.Remove(criteriaName);
		}

		/// <summary>
		/// Determine whether a criteria is defined.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="String"/> that specify the criteria value name.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the criteria <see cref="criteriaName"/> is
		/// actually defined.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="criteriaName"/> is null.
		/// </exception>
		public bool IsSet(string criteriaName)
		{
			if (criteriaName == null)
				throw new ArgumentNullException("criteriaName");

			return (_Criteria.ContainsKey(criteriaName));
		}

		/// <summary>
		/// Get the criteria value.
		/// </summary>
		/// <typeparam name="T">
		/// The type of the criterial value.
		/// </typeparam>
		/// <param name="criteriaName">
		/// A <see cref="String"/> that specify the criteria value name.
		/// </param>
		/// <returns>
		/// It returns the value corresponding to the criterial <paramref name="criteriaName"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This routine try to make the value associated with the criteria <paramref name="criteriaName"/> compatible with
		/// the type <typeparamref name="T"/>. In the case the value is not exacttly <typeparamref name="T"/>, it checks whether
		/// the value is a <see cref="IConvertible"/>; if the <typeparamref name="T"/> is a <see cref="IConvertible"/> too then
		/// the value is converted into a <typeparamref name="T"/> using <see cref="Convert.ChangeType(object,System.Type)"/>.
		/// </para>
		/// <para>
		/// Using the above strategy, it is possible to manage numeric values without caring about the specific value type.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="criteriaName"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="criteriaName"/> is not defined or the associated value is not compatible with
		/// the type <typeparamref name="T"/>.
		/// </exception>
		public T Get<T>(string criteriaName)
		{
			if (criteriaName == null)
				throw new ArgumentNullException("criteriaName");
			if (!IsSet(criteriaName))
				throw new ArgumentException("not defined", "criteriaName");

			object criteriaObjectValue = _Criteria[criteriaName];

			// Exact match on value type?
			if (criteriaObjectValue is T)
				return ((T) criteriaObjectValue);

			// Support IConvertible values
			if ((criteriaObjectValue is IConvertible) && (typeof(T).GetInterface("IConvertible") != null))
				return ((T) Convert.ChangeType(criteriaObjectValue, typeof (T)));

			throw new ArgumentException(String.Format("not compatible with the type {0}", typeof(T).Name), "criteriaName");
		}

		/// <summary>
		/// Map between criteria and its value.
		/// </summary>
		private readonly Dictionary<string, object> _Criteria = new Dictionary<string, object>();

		#endregion

		#region Operators

		/// <summary>
		/// Get and set a codec criteria.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="String"/> that specify the criteria value name.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="criteriaName"/> is null.
		/// </exception>
		public object this[string criteriaName]
		{
			get
			{
				if (criteriaName == null)
					throw new ArgumentNullException("criteriaName");

				return (_Criteria[criteriaName]);
			}
			set
			{
				if (criteriaName == null)
					throw new ArgumentNullException("criteriaName");

				_Criteria[criteriaName] = value;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this MediaCodecCriteria.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this MediaCodecCriteria.
		/// </returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("MediaCodecCriteria: Criteria { ");
			foreach (KeyValuePair<String, object> key in _Criteria)
				sb.AppendFormat("{0}={1};", key.Key, key.Value);
			sb.Append(" }");

			return (sb.ToString());
		}

		#endregion
	}
}

