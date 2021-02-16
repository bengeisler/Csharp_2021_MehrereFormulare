using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_MehrereFormulare
{
	public partial class Form2 : Form
	{
		// Eigenschaft "Text"

		public string Text;
		public Form2()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			// Eigenschaft "Text" beschreiben
			Text = txtEingabe.Text;

			// Gibt zurück, dass der Button "OK" gedrückt wurde
			DialogResult = DialogResult.OK;

			// Formular wird geschlossen
			Close();
		}

		private void btnAbbrechen_Click(object sender, EventArgs e)
		{
			// Gibt zurück, dass der Button "Abbrechen" gedrückt wude
			DialogResult = DialogResult.Cancel;

			// Formular schließen
			Close();
		}

		// FormClosing() wird aufgerufen, wenn der Benutzer das Formular
		// schließt - allerdings bevor das Formular wirklich geschlossen wurde
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			// MessageBox anzeigen
			// - 1. Parameter: Text, der angezeigt wird
			// - 2. Parameter: Überschrift
			// - 3. Parameter: Buttons, die zur Auswahl stehen
			var rückgabeAusMessageBox =
				MessageBox.Show(
					"Wollen Sie wirklich beenden?",
					"Form 2 schließen", 
					MessageBoxButtons.OKCancel);

			// Rückgabe auswerten
			// Schließen der Form abbrechen, wenn auf "Abbrechen" gedrückt wurde
			if (rückgabeAusMessageBox == DialogResult.Cancel) e.Cancel = true;
		}
	}
}
