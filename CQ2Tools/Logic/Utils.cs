using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQ2Tools.Logic
{
	public static class Utils
	{
		#region Extension Methods
		/// <summary>
		/// Returns the substring in a safe way. Does not throw errors. Instead, when starting index is higher than
		/// the length of the string, an empty string is returned, and when the length of the substring surpasses the length of the string,
		/// the substring will be as long as the string allows.
		/// </summary>
		public static string Substring(this string s, int startIndex, int length, bool safe)
		{
			if (s == null) return null;
			if (startIndex > s.Length - 1) return string.Empty;

			return s.Substring(startIndex, Math.Min(length, (s.Length - startIndex)));
		}

		/// <summary>
		/// Returns whether or not the specified string can be parsed to an int.
		/// </summary>
		public static bool IsNumber(this string s)
		{
			int x;
			return Int32.TryParse(s, out x);
		}
		#endregion

		#region Static Methods
		public static T StringToEnum<T>(string name)
		{
			return (T)Enum.Parse(typeof(T), name, true);
		}

		/// <summary>
		/// Concatenates the given <paramref name="parts"/> with the specified <paramref name="concatenationString"/>.
		/// </summary>
		/// <param name="concatenationChar">The string to concatenate the given <paramref name="parts"/> with.</param>
		/// <param name="parts">The strings to concatenate.</param>
		/// <param name="leaveOutBlanks">True to leave out blank <paramref name="parts"/>, false to include them in the result.</param>
		/// <returns>The concatenated string.</returns>
		/// <exception cref="ArgumentNullException">Thrown when either parameters are null.</exception>
		/// <exception cref="ArgumentException">Thrown when no parts are specified. At least one must be specified.</exception>
		public static string ConcatWith(string concatenationString, bool leaveOutBlanks, params string[] parts)
		{
			if (concatenationString == null) throw new ArgumentNullException("concatenationString");
			if (parts == null) throw new ArgumentNullException("parts");
			if (parts.Length == 0) throw new ArgumentException("parts");

			string result = string.Empty;

			foreach (string part in parts.Where(s => s != string.Empty && leaveOutBlanks))
				result += part + concatenationString;

			return result.Remove(result.LastIndexOf(concatenationString));
		}
		#endregion
	}
}
