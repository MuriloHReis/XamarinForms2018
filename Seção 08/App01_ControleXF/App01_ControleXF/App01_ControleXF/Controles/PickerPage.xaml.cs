﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();
		}
        private void ActionMudarIndex(object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;
            Resultado.Text = obj.SelectedItem.ToString() + " - " + obj.SelectedIndex.ToString();
        }
    }
}