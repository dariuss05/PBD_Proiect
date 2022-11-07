using PBD_Proiect.Displays;
using PBD_Proiect.MainApps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBD_Proiect
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void iesireMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentMenuAdd_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudent();
            addStudentForm.Show();
        }

        private void notaMenuAdd_Click(object sender, EventArgs e)
        {
            var addNotaForm = new AddNote();
            addNotaForm.Show();
        }

        private void restantieriMenuDisplay_Click(object sender, EventArgs e)
        {
            var displayRestantieriForm = new DisplayRestantieri();
            displayRestantieriForm.Show();
        }

        private void raportStudentMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRaportStudent = new DisplayRaportStudent();
            displayRaportStudent.Show();
        }

        private void raportDetaliatMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRaportDetaliatStudent = new DisplayRaportDetaliatStudent();
            displayRaportDetaliatStudent.Show();
        }

        private void promovabilitateStudentMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayPromovabilitateMaterie = new DisplayPromovabilitateMaterie();
            displayPromovabilitateMaterie.Show();
        }

        private void restanteConsecutiveMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayRestanteConsecutive = new DisplayRestanteConsecutive();
            displayRestanteConsecutive.Show();
        }

        private void prezentariExamenMenuAfisare_Click(object sender, EventArgs e)
        {
            var displayPrezentariExamen = new DisplayPrezentariExamenStudent();
            displayPrezentariExamen.Show();
        }
    }
}
