using System;
using System.Collections.Generic;
using System.Text;

namespace BindingsGen.GLSpecs
{
	public class EnumerantComparer : IComparer<Enumerant>
	{
		public int Compare(Enumerant x, Enumerant y)
		{
			int compare;

			if ((compare = x.Name.CompareTo(y.Name)) != 0)
				return (compare);

			if        ((x.Api != null) && (y.Api != null)) {
				if ((compare = x.Api.CompareTo(y.Api)) != 0)
					return (compare);
			} else if ((x.Api == null) && (y.Api != null)) {
				return (-1);
			} else if ((x.Api != null) && (y.Api == null)) {
				return (+1);
			}

			return (compare);
		}
	}
}
