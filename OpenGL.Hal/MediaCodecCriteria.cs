
// Copyright (C) 2012-2013 Luca Piccioni
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGL
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
		#region Constructors

		/// <summary>
		/// Construct a MediaCodecCriteria.
		/// </summary>
		public MediaCodecCriteria()
		{
			
		}

		/// <summary>
		/// Construct a MediaCodecCriteria, specifying an option set.
		/// </summary>
		/// <param name="options"></param>
		public MediaCodecCriteria(string options)
		{
			
		}

		#endregion

		#region Criteria Collection

		/// <summary>
		/// Define a criteria.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="System.String"/> that specify the criteria value name.
		/// </param>
		/// <param name="value">
		/// A <see cref="System.Object"/> that specify the criteria value. It can null.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="criteriaName"/> is null.
		/// </exception>
		public void Define(string criteriaName, object value)
		{
			if (criteriaName == null)
				throw new ArgumentNullException("criteriaName");

			// Define or overwrite criteria value
			mCriteria[criteriaName] = value;
		}

		/// <summary>
		/// Undefine a criteria.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="System.String"/> that specify the criteria value name.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="criteriaName"/> is null.
		/// </exception>
		public void Undefine(string criteriaName)
		{
			if (criteriaName == null)
				throw new ArgumentNullException("criteriaName");

			mCriteria.Remove(criteriaName);
		}

		/// <summary>
		/// Determine whether a criteria is defined.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="System.String"/> that specify the criteria value name.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the criteria <see cref="criteriaName"/> is
		/// actually defined.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="criteriaName"/> is null.
		/// </exception>
		public bool IsDefined(string criteriaName)
		{
			if (criteriaName == null)
				throw new ArgumentNullException("criteriaName");

			return (mCriteria.ContainsKey(criteriaName));
		}

		/// <summary>
		/// Get the criteria value.
		/// </summary>
		/// <typeparam name="T">
		/// The type of the criterial value.
		/// </typeparam>
		/// <param name="criteriaName">
		/// A <see cref="System.String"/> that specify the criteria value name.
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
			if (!IsDefined(criteriaName))
				throw new ArgumentException("not defined", "criteriaName");

			object criteriaObjectValue = mCriteria[criteriaName];

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
		private readonly Dictionary<string, object> mCriteria = new Dictionary<string, object>();

		#endregion

		#region Operators

		/// <summary>
		/// Get and set a codec criteria.
		/// </summary>
		/// <param name="criteriaName">
		/// A <see cref="System.String"/> that specify the criteria value name.
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

				return (mCriteria[criteriaName]);
			}
			set
			{
				if (criteriaName == null)
					throw new ArgumentNullException("criteriaName");

				mCriteria[criteriaName] = value;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this MediaCodecCriteria.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="System.String"/> that represents this MediaCodecCriteria.
		/// </returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("{MediaCodecCriteria} Criteria: ");
			foreach (KeyValuePair<String, object> key in mCriteria)
				sb.AppendFormat("{0}={1};", key.Key, key.Value);

			return (sb.ToString());
		}

		#endregion
	}
}

