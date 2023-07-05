using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

/* TODO : Crée la classe de calcul pour faire la moyenne.
 * Créer le bouton valider (confirmation des donnée entrés par l'utilisateur) pour renvoyer le résultat. (valable pour les 2 versions du programme).
 * créer la classe plusieurs programme box creation.
 * créer la classe plage horraire pour plusieurs programmes.
 * Créer la rollbar pour naviguer dans le programme verticalement.
 */
namespace CTM_v1
{
    public partial class CTM : Form
    {
        /// <summary>
        /// Ici le code qui permet à l'utilisateur de donner les données au programme + Creation des TextBoxes + Calcul.
        /// </summary>
        
        // 1 Prog
        TextBox? explication;
        TextBox[]? textboxesHorraire;
        TextBox[]? textboxesTemperature;
        TextBox[]? indiqHorraire;
        TextBox[]? indiqTemperature;

        // Plusieurs Prog
        TextBox? explicationPProg;
        TextBox[]? textboxesnbprog;
        TextBox[]? textboxesHorraire2;
        TextBox[]? textboxesTemperature2;
        TextBox[]? indiqHorraire2;
        TextBox[]? indiqTemperature2;

        public CTM()
        {
            InitializeComponent();
            titre.ReadOnly = true;
            objectifDuProgramme.ReadOnly = true;
            explicationFonctionnel1.ReadOnly = true;
            // Aucune visibilité avant le choix de la personne pour moins d'encombrement visuel.

            // Un programme
            unProgrammeBriefing.Visible = unProgramme.Checked;
            unProgPlageHorraires.Visible = unProgramme.Checked;
            unProgValiderPlageHorraire.Visible = unProgramme.Checked;

            // Plusieurs programmes
            plusieursProgrammesBriefing.Visible = plusieursProgrammes.Checked;
            nombreProgParSemaine.Visible = plusieursProgrammes.Checked;
            plusieursProgValiderNbProg.Visible = plusieursProgrammes.Checked;
        }

        private void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            unProgramme.Checked = false;
            unProgPlageHorraires.Text = "";
            unProgPlageHorraires.ReadOnly = false;

            plusieursProgrammes.Checked = false;
            nombreProgParSemaine.Text = "";
            nombreProgParSemaine.ReadOnly = false;

            if (explication != null) // 1 Prog
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

            if (explicationPProg  != null) // Plusieurs Prog
            {
                explicationPProg.Visible = false;
            }

            if (textboxesnbprog != null) 
            {
                foreach(TextBox textBox in textboxesnbprog)
                {
                    textBox.Visible= false;
                }
            }

            if (textboxesHorraire2 != null)
            {
                foreach (TextBox textBox in textboxesHorraire2)
                {
                    textBox.Visible = false;
                }
            }

            if (textboxesTemperature2 != null)
            {
                foreach (TextBox textBox in textboxesTemperature2)
                {
                    textBox.Visible = false;
                }
            }

            if (indiqHorraire2 != null)
            {
                foreach (TextBox textBox in indiqHorraire2)
                {
                    textBox.Visible = false;
                }
            }

            if (indiqTemperature2 != null)
            {
                foreach (TextBox textBox in indiqTemperature2)
                {
                    textBox.Visible = false;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Met à jour la position et la taille de la barre de défilement
            vScrollBar.Location = new System.Drawing.Point(panel1.Width - vScrollBar.Width, 0);
            vScrollBar.Height = panel1.Height;
            // Met à jour la zone de défilement du panneau en fonction de la taille du contenu
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, panel1.Controls.Count * 25);
            // Met à jour la position verticale du panneau en fonction de la valeur de défilement de la barre
            panel1.VerticalScroll.Value = e.NewValue;
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

        private void unProgramme_Validated(object sender, EventArgs e)
        {

        }

        private void unProgrammeBriefing_TextChanged(object sender, EventArgs e)
        {

        }

        public void unProgPlageHorraires_TextChanged(object sender, EventArgs e)
        {

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

        private void unProgramme_CheckedChanged(object sender, EventArgs e) // 1 PROGRAMME
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

        public int valeurPlageHorraire { get; private set; }

        public void unProgValiderPlageHorraire_Click(object sender, EventArgs e) // ETAPE 1
        {
            if (unProgPlageHorraires.Text != "")
            {
                string valeurInscrit = unProgPlageHorraires.Text;
                int tempValeurPlageHorraire;

                if (int.TryParse(valeurInscrit, out tempValeurPlageHorraire) && tempValeurPlageHorraire != 0)
                {
                    if (tempValeurPlageHorraire < 24)
                    {
                        valeurPlageHorraire = tempValeurPlageHorraire;
                        unProgPlageHorraires.ReadOnly = true;

                        // Appel la méthode de la classe un prog
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

        private void unProgValiderPlageHorraire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                unProgValiderPlageHorraire.PerformClick();
                e.Handled = true;
            }
        }
        private void UnProgExplication() // ETAPE 2
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
            panel1.Controls.Add(explication);
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
                panel1.Controls.Add(textboxesHorraire[i]);

                indiqHorraire[i] = new TextBox();
                indiqHorraire[i].Location = new Point(x + 100, y + 50 + i * 50);
                indiqHorraire[i].Size = new Size(largeur, hauteur);
                indiqHorraire[i].Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                indiqHorraire[i].BackColor = SystemColors.InactiveCaption;
                indiqHorraire[i].BorderStyle = BorderStyle.None;
                indiqHorraire[i].Text = ("<-Horraires " + v);
                indiqHorraire[i].Enabled = false;
                indiqHorraire[i].ReadOnly = true;
                panel1.Controls.Add(indiqHorraire[i]);
            }

            v = 0;
            for (int i = 0; i < nbPlageHorraire; i++)
            {
                v++;
                textboxesTemperature[i] = new TextBox();
                textboxesTemperature[i].Location = new Point(x + 373, y + 50 + i * 50);
                textboxesTemperature[i].Size = new Size(largeur, hauteur);
                panel1.Controls.Add(textboxesTemperature[i]);

                indiqTemperature[i] = new TextBox();
                indiqTemperature[i].Location = new Point(x + 273, y + 50 + i * 50);
                indiqTemperature[i].Size = new Size(largeur, hauteur);
                indiqTemperature[i].Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                indiqTemperature[i].BackColor = SystemColors.InactiveCaption;
                indiqTemperature[i].BorderStyle = BorderStyle.None;
                indiqTemperature[i].Text = ("Temperature " + v + "->");
                indiqTemperature[i].Enabled = false;
                indiqTemperature[i].ReadOnly = true;
                panel1.Controls.Add(indiqTemperature[i]);
            }
        }

/*____________________________________________________________________________________________________________________________________________________________*/

        private void plusieursProgrammes_CheckedChanged(object sender, EventArgs e) // PLUSIEURS PROG
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

        public int valeurNbProgParSemaine { get; private set; }

        private void plusieursProgValiderNbProg_Click(object sender, EventArgs e) // ETAPE 1 
        {
            if (nombreProgParSemaine.Text != "")
            {
                string valeurInscrit = nombreProgParSemaine.Text;
                int tempValeurProgParSemaine;

                if (int.TryParse(valeurInscrit, out tempValeurProgParSemaine) && tempValeurProgParSemaine != 0)
                {
                    if (tempValeurProgParSemaine <= 7)
                    {
                        valeurNbProgParSemaine = tempValeurProgParSemaine;
                        nombreProgParSemaine.ReadOnly = true;

                        // Appel la méthode de la classe 'plusieurs prog.'
                        PlusieursProgExplication();
                        PlusieursProgNbProgBoxCreation(valeurNbProgParSemaine);
                    }
                    else
                    {
                        MessageBox.Show("Il n'est pas possible d'avoir plus de programmes qu'il n'y a de jours par semaine.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void plusieursProgValiderNbProg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                plusieursProgValiderNbProg.PerformClick();
                e.Handled = true;
            }
        }

        private void PlusieursProgExplication() // ETAPE 2
        {
            int x = 732;
            int y = 350;
            explicationPProg = new TextBox();
            explicationPProg.Location = new Point(x, y);
            explicationPProg.Size = new Size(474, 44);
            explicationPProg.BackColor = Color.LightCoral;
            explicationPProg.Multiline = true;
            explicationPProg.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            explicationPProg.Text = "Veuillez définir ci-dessous le nombre de programme / semaine.";
            panel1.Controls.Add(explicationPProg);
        }

        public void PlusieursProgNbProgBoxCreation(int valeurNbProgParSemaine)
        {
            int x = 732;
            int y = 400;
            int v = 0;
            const int largeur = 100;
            const int hauteur = 25;

            textboxesnbprog = new TextBox[valeurNbProgParSemaine];

            for (int i = 0; i < valeurNbProgParSemaine; i++)
            {
                v++;
                textboxesnbprog[i] = new TextBox();
                textboxesnbprog[i].Location = new Point(x, y + i * 50);
                textboxesnbprog[i].Size = new Size(largeur, hauteur);
                panel1.Controls.Add(textboxesnbprog[i]);
            }
        }
        /*
        public void PlusieursProgProgBoxCreation(int )
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
                panel1.Controls.Add(textboxesHorraire[i]);

                indiqHorraire[i] = new TextBox();
                indiqHorraire[i].Location = new Point(x + 100, y + 50 + i * 50);
                indiqHorraire[i].Size = new Size(largeur, hauteur);
                indiqHorraire[i].Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                indiqHorraire[i].BackColor = SystemColors.InactiveCaption;
                indiqHorraire[i].BorderStyle = BorderStyle.None;
                indiqHorraire[i].Text = ("<-Horraires " + v);
                indiqHorraire[i].Enabled = false;
                indiqHorraire[i].ReadOnly = true;
                panel1.Controls.Add(indiqHorraire[i]);
            }

            v = 0;
            for (int i = 0; i < nbPlageHorraire; i++)
            {
                v++;
                textboxesTemperature[i] = new TextBox();
                textboxesTemperature[i].Location = new Point(x + 373, y + 50 + i * 50);
                textboxesTemperature[i].Size = new Size(largeur, hauteur);
                panel1.Controls.Add(textboxesTemperature[i]);

                indiqTemperature[i] = new TextBox();
                indiqTemperature[i].Location = new Point(x + 273, y + 50 + i * 50);
                indiqTemperature[i].Size = new Size(largeur, hauteur);
                indiqTemperature[i].Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                indiqTemperature[i].BackColor = SystemColors.InactiveCaption;
                indiqTemperature[i].BorderStyle = BorderStyle.None;
                indiqTemperature[i].Text = ("Temperature " + v + "->");
                indiqTemperature[i].Enabled = false;
                indiqTemperature[i].ReadOnly = true;
                panel1.Controls.Add(indiqTemperature[i]);
            }
        }
        */

    }
}