﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.ComponentModel;
using dnSpy.Contracts.Text;

namespace dnSpy.Contracts.Bookmarks {
	/// <summary>
	/// Formats some columns in the bookmarks window
	/// </summary>
	public abstract class BookmarkLocationFormatter : INotifyPropertyChanged {
		/// <summary>
		/// Name of the Location property
		/// </summary>
		public const string LocationProperty = nameof(LocationProperty);

		/// <summary>
		/// Name of the Module property
		/// </summary>
		public const string ModuleProperty = nameof(ModuleProperty);

		/// <summary>
		/// Raised when a property is changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

		/// <summary>
		/// Called when the location needs to be reformatted
		/// </summary>
		protected void RaiseLocationChanged() => OnPropertyChanged(LocationProperty);

		/// <summary>
		/// Called when the module needs to be reformatted
		/// </summary>
		protected void RaiseModuleChanged() => OnPropertyChanged(ModuleProperty);

		/// <summary>
		/// Writes the location shown in the Location column
		/// </summary>
		/// <param name="output">Output</param>
		public abstract void WriteLocation(ITextColorWriter output);

		/// <summary>
		/// Writes the module shown in the Module column
		/// </summary>
		/// <param name="output">Output</param>
		public abstract void WriteModule(ITextColorWriter output);
	}
}
