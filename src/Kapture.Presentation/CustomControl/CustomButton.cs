﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ACT_FFXIV_Kapture.Presentation
{
	public sealed class CustomButton : Button
	{
		public CustomButton()
		{
			FlatStyle = FlatStyle.Flat;
			BackColor = Color.Transparent;
			FlatAppearance.MouseOverBackColor = Color.Transparent;
			FlatAppearance.MouseDownBackColor = Color.Transparent;
			FlatAppearance.BorderSize = 0;
			ForeColor = Color.Blue;
			SetStyle(ControlStyles.Selectable, false);
			Size = new Size
			{
				Height = 23,
				Width = 85
			};
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			Font = new Font(Font, FontStyle.Regular);
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseLeave(e);
			Font = new Font(Font, FontStyle.Underline);
		}
	}
}