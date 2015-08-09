﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesen.GUI.Debugger.Controls
{
	public abstract class BaseScrollableTextboxUserControl : UserControl
	{
		protected abstract ctrlScrollableTextbox ScrollableTextbox
		{
			get;
		}

		[DefaultValue(13F)]
		public float FontSize
		{
			get { return this.ScrollableTextbox.FontSize; }
			set { this.ScrollableTextbox.FontSize = value; }
		}

		public void OpenSearchBox()
		{
			this.ScrollableTextbox.OpenSearchBox();
		}

		public void FindNext()
		{
			this.ScrollableTextbox.FindNext();
		}

		public void FindPrevious()
		{
			this.ScrollableTextbox.FindPrevious();
		}

		public void GoToAddress()
		{
			this.ScrollableTextbox.GoToAddress();
		}

		public void ScrollToLineNumber(int lineNumber)
		{
			this.ScrollableTextbox.ScrollToLineNumber(lineNumber);
		}

		public int GetCurrentLine()
		{
			return this.ScrollableTextbox.CurrentLine;
		}

		public void ScrollToTop()
		{
			this.ScrollableTextbox.ScrollToLineNumber(0);
		}
		
		public string GetWordUnderLocation(Point position)
		{
			return this.ScrollableTextbox.GetWordUnderLocation(position);
		}
	}
}
