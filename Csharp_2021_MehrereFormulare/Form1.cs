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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnForm2Anzeigen_Click(object sender, EventArgs e)
		{
			// Objekt erstellen vom Typ des hinzugefügten Formulars
			var neueForm = new Form2();

			// Dieses Objekt anzeigen => Ruft zweite Form auf und zeigt sie an
			// neueForm.Show();

			// Form2 als Dialog anzeigen und Rückgabe auswerten
			// Rückgabe bedeutet: Welcher Button in Form2 gedrückt wurde
			var rückgabeAusForm2 = neueForm.ShowDialog();

			// Rückgabe auswerten
			if (rückgabeAusForm2 == DialogResult.OK)
			{
				// Eigenschaft "Text" (selbst angelegt) der Form2 auslesen
				lblAusgabe.Text = neueForm.Text;

				Console.WriteLine("OK wurde gedrückt");
			}				

			if (rückgabeAusForm2 == DialogResult.Cancel)
				Console.WriteLine("Abbrechen wurde gedrückt");
		}
	}
}
