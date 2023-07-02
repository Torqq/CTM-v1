namespace CTM_v1
{
    public partial class CTM : Form
    {
        public CTM()
        {
            InitializeComponent();
            titre.ReadOnly = true;
            objectifDuProgramme.ReadOnly = true;
            explicationFonctionnel1.ReadOnly = true;
            //Aucune visibilité avant le choix de la personne pour moins d'encombrement visuel.
            //Un programme
            unProgrammeBriefing.Visible = unProgramme.Checked;
            unProgPlageHorraires.Visible = unProgramme.Checked;
            unProgValiderPlageHorraire.Visible = unProgramme.Checked;

            //Plusieurs programmes
            plusieursProgrammesBriefing.Visible = plusieursProgrammes.Checked;
            nombreProgParSemaine.Visible = plusieursProgrammes.Checked;
            plusieursProgValiderNbProg.Visible = plusieursProgrammes.Checked;
        }

        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            unProgramme.Checked = false;
            plusieursProgrammes.Checked = false;
        }

        private void objectifDuProgramme_TextChanged(object sender, EventArgs e)
        {
            objectifDuProgramme.ReadOnly = true;
            objectifDuProgramme.ForeColor = Color.Black;
        }

        private void titre_TextChanged(object sender, EventArgs e)
        {
            titre.ReadOnly = true;
            titre.ForeColor = Color.Black;
        }

        private void explicationFonctionnel1_TextChanged(object sender, EventArgs e)
        {
            explicationFonctionnel1.ReadOnly = true;
            explicationFonctionnel1.ForeColor = Color.Black;
        }

        private void unProgramme_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;

            if (currentCheckBox.Checked)
            {
                plusieursProgrammes.Checked = false;
            }
            unProgrammeBriefing.Visible = unProgramme.Checked;
            unProgPlageHorraires.Visible = unProgramme.Checked;
            unProgValiderPlageHorraire.Visible = unProgramme.Checked;

        }

        private void unProgramme_Validated(object sender, EventArgs e)
        {

        }

        private void unProgrammeBriefing_TextChanged(object sender, EventArgs e)
        {

        }

        private void unProgPlageHorraires_TextChanged(object sender, EventArgs e)
        {

        }

        private void unProgValiderPlageHorraire_Click(object sender, EventArgs e)
        {
            string valeurInscrit = unProgPlageHorraires.Text;
            int valeurPlageHorraire = int.Parse(valeurInscrit);
        }

        private void plusieursProgrammes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = (CheckBox)sender;

            if (currentCheckBox.Checked)
            {
                unProgramme.Checked = false;
            }
            plusieursProgrammesBriefing.Visible = plusieursProgrammes.Checked;
            nombreProgParSemaine.Visible = plusieursProgrammes.Checked;
            plusieursProgValiderNbProg.Visible = plusieursProgrammes.Checked;
        }

        private void plusieursProgrammes_Validated(object sender, EventArgs e)
        {

        }

        private void plusieursProgrammesBriefing_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreProgParSemaine_TextChanged(object sender, EventArgs e)
        {

        }

        private void plusieursProgValiderNbProg_Click(object sender, EventArgs e)
        {
            string valeurInscrit = nombreProgParSemaine.Text;
            int valeurNbProgParSemaine = int.Parse(valeurInscrit);
        }
    }
}