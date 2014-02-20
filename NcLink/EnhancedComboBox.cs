/*
 * Created by SharpDevelop.
 * User: Adam
 * Date: 20/02/2014
 * Time: 00:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NcLink
{
	/// <summary>
	/// Description of EnhancedComboBox.
	/// </summary>
	public partial class EnhancedComboBox : ComboBox
	{
		private int _defaultIndex = 0;
		
		public EnhancedComboBox()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public int DefaultIndex
		{
			get { return _defaultIndex; }
			set 
			{ 
				if (value > Items.Count - 1)
					throw new ArgumentOutOfRangeException("The index is outside the range available!");
				
				base.SelectedIndex = value;
				_defaultIndex = value;				
			}
		}
	}
}
