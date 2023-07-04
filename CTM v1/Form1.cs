using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Runtime.CompilerServices;

namespace CTM_v1
{
    public partial class CTM : Form
    {
        TextBox? explication;
        TextBox[]? textboxesHorraire;
        TextBox[]? textboxesTemperature;
        TextBox[]? indiqHorraire;
        TextBox[]? indiqTemperature;

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
            unProgPlageHorraires.Text = "";
            unProgPlageHorraires.ReadOnly = false;
            unProgPlageHorraires.Text = "";        

            if(explication != null)
            {
                explication.Visible = false;
            }

            if (textboxesHorraire != null)
            {
                foreach (TextBox textBox in textboxesHorraire)
                {
                    if (textBox != null)
                    {
                        textBox.Visible = false;
                    }
                }
            }

            if (textboxesTemperature != null)
            {
                foreach (TextBox textBox in textboxesTemperature)
                {
                    if (textBox != null)
                    {
                        textBox.Visible = false;
                    }
                }
            }

            if (indiqHorraire != null)
            {
                foreach (TextBox textBox in indiqHorraire)
                {
                    if (textBox != null)
                    {
                        textBox.Visible = false;
                    }
                }
            }

            if (indiqTemperature != null)
            {
                foreach (TextBox textBox in indiqTemperature)
                {
                    if (textBox != null)
                    {
                        textBox.Visible = false;
                    }
                }
            }

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

        public void unProgPlageHorraires_TextChanged(object sender, EventArgs e)
        {

        }

        public int valeurPlageHorraire { get; private set; }

        public void unProgValiderPlageHorraire_Click(object sender, EventArgs e)
        {
            if (unProgPlageHorraires.Text != "")
            {
                string valeurInscrit = unProgPlageHorraires.Text;
                int tempValeurPlageHorraire;

                if (int.TryParse(valeurInscrit, out tempValeurPlageHorraire) && tempValeurPlageHorraire != 0)
                {
                    if(tempValeurPlageHorraire < 24)
                    {
                        valeurPlageHorraire = tempValeurPlageHorraire;
                        unProgPlageHorraires.ReadOnly = true;

                        // Appel la méthode de la classe 'core'
                        UnProgExplication();
                        UnProgBoxCreation(valeurPlageHorraire);
                    }
                    else 
                    {
                        MessageBox.Show("Il n'est pas possible d'avoir plus de plages horraires qu'il n'y à d'heure dans la journée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

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

        private void UnProgExplication()
        {
            int x = 12;
            int y = 350;
            explication = new TextBox();
            explication.Location = new Point(x, y);
            explication.Size = new Size(474, 44);
            explication.BackColor = Color.CornflowerBlue;
            explication.Multiline = true;
            explication.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            explication.Text = "Veuillez remplir les données dans les cases indiqués ci-dessous dans l'ordre tespectif.";
            Controls.Add(explication);
        }

        public void UnProgBoxCreation(int valeurPlageHorraire)
        {           
            int nbPlageHorraire = valeurPlageHorraire;
            int x = 12;
            int y = 350;
            int v = 0;
            const int largeur = 100;
            const int hauteur = 25;

            IList<int> valeurTemperature = new List<int>();
            IList<int> valeurHorraire = new List<int>();

            textboxesHorraire = new TextBox[nbPlageHorraire];
            textboxesTemperature = new TextBox[nbPlageHorraire];
            indiqHorraire = new TextBox[nbPlageHorraire];
            indiqTemperature = new TextBox[nbPlageHorraire];

            for (int i = 0; i < nbPlageHorraire; i++)
            {
                v++;
                textboxesHorraire[i] = new TextBox();
                textboxesHorraire[i].Location = new Point(x, y + 50 + i * 50);
                textboxesHorraire[i].Size = new Size(largeur, hauteur);
                Controls.Add(textboxesHorraire[i]);

                indiqHorraire[i] = new TextBox();
                indiqHorraire[i].Location = new Point(x + 100, y + 50 + i * 50);
                indiqHorraire[i].Size = new Size(largeur, hauteur);
                indiqHorraire[i].Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                indiqHorraire[i].BackColor = SystemColors.InactiveCaption;
                indiqHorraire[i].BorderStyle = BorderStyle.None;
                indiqHorraire[i].Text = ("<-Horraires " + v);
                indiqHorraire[i].Enabled = false;
                indiqHorraire[i].ReadOnly = true;
                Controls.Add(indiqHorraire[i]);
            }

            v = 0;
            for (int i = 0; i < nbPlageHorraire; i++)
            {
                v++;
                textboxesTemperature[i] = new TextBox();
                textboxesTemperature[i].Location = new Point(x + 373, y + 50 + i * 50);
                textboxesTemperature[i].Size = new Size(largeur, hauteur);
                Controls.Add(textboxesTemperature[i]);

                indiqTemperature[i] = new TextBox();
                indiqTemperature[i].Location = new Point(x + 273, y + 50 + i * 50);
                indiqTemperature[i].Size = new Size(largeur, hauteur);
                indiqTemperature[i].Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                indiqTemperature[i].BackColor = SystemColors.InactiveCaption;
                indiqTemperature[i].BorderStyle = BorderStyle.None;
                indiqTemperature[i].Text = ("Temperature " + v + "->");
                indiqTemperature[i].Enabled = false;
                indiqTemperature[i].ReadOnly = true;
                Controls.Add(indiqTemperature[i]);
            }
        }
    }
}