﻿#region Licence
//The MIT License (MIT)
//Copyright (c) 2014 abdallah HACID, https://www.facebook.com/ab.hacid

//Permission is hereby granted, free of charge, to any person obtaining a copy of this software
//and associated documentation files (the "Software"), to deal in the Software without restriction,
//including without limitation the rights to use, copy, modify, merge, publish, distribute,
//sublicense, and/or sell copies of the Software, and to permit persons to whom the Software
//is furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all copies or
//substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
//BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

// Project Hosting for Open Source Software on Codeplex : https://github.com/abhacid/cAlgoBot
#endregion

using System;
using cAlgo.API;

namespace cAlgo.Lib
{
	/// <summary>
	/// Méthodes d'extensions du type String
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// transforme une chaine de caractère contenant une couleur "white" par exemple en type cAlgo.API.colors
		/// </summary>
		/// <param name="color">la chaine de caractère contenant le nom de la couleur</param>
		/// <returns>cAlgo.API.colors</returns>
		public static Colors? parseColor(this string color)
		{
			Colors _color;

			if (!Enum.TryParse<Colors>(color, out _color))
				return _color;
			else
				return null;
		}
	}
}