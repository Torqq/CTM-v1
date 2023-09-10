using System;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static CTM_v1.CTM;

/* TODO : Cr�e la classe de calcul pour faire la moyenne.
 * Cr�er le bouton valider (confirmation des donn�e entr�s par l'utilisateur) pour renvoyer le r�sultat. (valable pour les 2 versions du programme). ++
 * cr�er la classe plage horraire pour plusieurs programmes.
 */
namespace CTM_v1
{
    public partial class CTM : Form
    {
        /// <summary>
        /// Ici le code qui permet � l'utilisateur de donner les donn�es au programme + Creation des TextBoxes + Calcul.
        /// </summary>

        public int valeurEntreeParUtilisateur { get; set; }
        public int valeurEntreeParUtilisateurPProg { get; set; }

        // 1 Prog
        private TextBox? explication;
        private TextBox[]? textboxesHorraire;
        private TextBox[]? textboxesTemperature;
        private TextBox[]? indiqHorraire;
        private TextBox[]? indiqTemperature;
        private TextBox? reponseCalcul;

        // Plusieurs Prog
        private TextBox? explicationPProg;
        private TextBox[]? textboxesnbprog;
        private TextBox[]? indiqnbjoursparprog;
        private TextBox? numProgramme;
        private TextBox? numProgramme2;
        private TextBox[]? textboxesHorraire2;
        private TextBox[]? textboxesTemperature2;
        private TextBox[]? pProgPlageHorraires;
        private TextBox[]? horaireTextBox;
        private TextBox[]? indiqHoraireTextBox;
        private TextBox[]? temperatureTextBox;
        private TextBox[]? indiqTemperatureTextBox;

        Point derniereLocation = new Point();
        Point derniereLocationPP = new Point();
        Point derniereLocationPPMaj = new Point();

        private List<TextBox> textboxesnbprogList = new List<TextBox>();
        private List<TextBox> numProgrammesList = new List<TextBox>();
        private List<TextBox> numProgrammesList2 = new List<TextBox>();
        private List<TextBox> pProgPlageHorrairesList = new List<TextBox>();
        private List<TextBox> textboxesHorraire2List = new List<TextBox>();
        private List<TextBox> horaireTextBoxList = new List<TextBox>();
        private List<TextBox> indiqHoraireTextBoxList = new List<TextBox>();
        private List<TextBox> temperatureTextBoxList = new List<TextBox>();
        private List<TextBox> indiqTemperatureTextBoxList = new List<TextBox>();

        public CTM()
        {
            InitializeComponent();
            titre.ReadOnly = true;
            objectifDuProgramme.ReadOnly = true;
            explicationFonctionnel1.ReadOnly = true;
            // Aucune visibilit� avant le choix de la personne pour moins d'encombrement visuel.

            // Un programme
            unProgrammeBriefing.Visible = unProgramme.Checked;
            unProgPlageHorraires.Visible = unProgramme.Checked;
            unProgValiderPlageHorraire.Visible = unProgramme.Checked;

            // Plusieurs programmes
            plusieursProgrammesBriefing.Visible = plusieursProgrammes.Checked;
            nombreProgParSemaine.Visible = plusieursProgrammes.Checked;
            plusieursProgValiderNbProg.Visible = plusieursProgrammes.Checked;
        }

        public class ValeurJourParProg
        {
            public List<string> Donnees { get; } = new List<string>();
        }

        public ValeurJourParProg InstanceValeurJourParProg { get; } = new ValeurJourParProg();

        public class PProgPlageHorraires
        {
            public List<string> PPPH { get; } = new List<string>();
        }

        public PProgPlageHorraires InstancePProgPlageHorraires { get; } = new PProgPlageHorraires();


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

        public void buttonReinitialiser_Click(object sender, EventArgs e)
        {
            //Application.Restart();

            // R�initialiser les Axes X ,Y
            derniereLocation = new Point(0, 0);
            derniereLocationPP = new Point(0, 0);
            derniereLocationPPMaj = new Point(0, 0);

            // R�initialiser les cases
            unProgramme.Checked = false;
            unProgPlageHorraires.Text = "";
            unProgPlageHorraires.ReadOnly = false;

            plusieursProgrammes.Checked = false;
            nombreProgParSemaine.Text = "";
            nombreProgParSemaine.ReadOnly = false;

            // R�initialiser les valeurs des variables entr�es par l'utilisateur
            valeurEntreeParUtilisateur = 0;
            valeurEntreeParUtilisateurPProg = 0;

            // R�initialiser les contr�les
            if (explication != null)
            {
                explication.Visible = false;
            }

            if (textboxesHorraire != null)
            {
                foreach (TextBox textBox in textboxesHorraire)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (textboxesTemperature != null)
            {
                foreach (TextBox textBox in textboxesTemperature)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (indiqHorraire != null)
            {
                foreach (TextBox textBox in indiqHorraire)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (indiqTemperature != null)
            {
                foreach (TextBox textBox in indiqTemperature)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (reponseCalcul != null)
            {

                reponseCalcul.Text = string.Empty;

            }

            if (explicationPProg != null)
            {
                explicationPProg.Visible = false;
            }

            if (textboxesnbprog != null)
            {
                foreach (TextBox textBox in textboxesnbprog)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (indiqnbjoursparprog != null)
            {
                foreach (TextBox textBox in indiqnbjoursparprog)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (numProgramme != null)
            {
                numProgramme.Text = string.Empty;
            }

            if (numProgramme2 != null)
            {
                numProgramme2.Text = string.Empty;
            }

            if (textboxesHorraire2 != null)
            {
                foreach (TextBox textBox in textboxesHorraire2)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (textboxesTemperature2 != null)
            {
                foreach (TextBox textBox in textboxesTemperature2)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (pProgPlageHorraires != null)
            {
                foreach (TextBox textBox in pProgPlageHorraires)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (horaireTextBox != null)
            {
                foreach (TextBox textBox in horaireTextBox)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (indiqHoraireTextBox != null)
            {
                foreach (TextBox textBox in indiqHoraireTextBox)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (temperatureTextBox != null)
            {
                foreach (TextBox textBox in temperatureTextBox)
                {
                    textBox.Text = string.Empty;
                }
            }

            if (indiqTemperatureTextBox != null)
            {
                foreach (TextBox textBox in indiqTemperatureTextBox)
                {
                    textBox.Text = string.Empty;
                }
            }

            // R�initialiser les Collections
            horaireTextBoxList.Clear();
            indiqHoraireTextBoxList.Clear();
            temperatureTextBoxList.Clear();
            indiqTemperatureTextBoxList.Clear();
            textboxesnbprogList.Clear();
            numProgrammesList.Clear();
            numProgrammesList2.Clear();
            pProgPlageHorrairesList.Clear();
            textboxesHorraire2List.Clear();

        }

        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Met � jour la position et la taille de la barre de d�filement
            vScrollBar.Location = new System.Drawing.Point(panel1.Width - vScrollBar.Width, 0);
            vScrollBar.Height = panel1.Height;
            // Met � jour la zone de d�filement du panneau en fonction de la taille du contenu
            panel1.AutoScrollMinSize = new System.Drawing.Size(0, panel1.Controls.Count * 25);
            // Met � jour la position verticale du panneau en fonction de la valeur de d�filement de la barre
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

        private void unProgramme_CheckedChanged(object sender, EventArgs e) // 1 PROGRAMME
        {
            CheckBox currentCheckBox = (CheckBox)sender;

            unProgrammeBriefing.Visible = unProgramme.Checked;
            unProgPlageHorraires.Visible = unProgramme.Checked;
            unProgValiderPlageHorraire.Visible = unProgramme.Checked;

            if (currentCheckBox.Checked)
            {
                if (plusieursProgrammes.Checked)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        buttonReinitialiser_Click(sender, e);
                    }
                }
                plusieursProgrammes.Checked = false;
            }

            if (explication != null)
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

            if (unProgGo != null)
            {
                unProgGo.Visible = false;
            }

            if (reponseCalcul != null)
            {

                reponseCalcul.Visible = false;

            }
        }

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
                        valeurEntreeParUtilisateur = tempValeurPlageHorraire;
                        unProgPlageHorraires.ReadOnly = true;

                        // Appel la m�thode de la classe un prog
                        UnProgExplication();
                        UnProgBoxCreation(valeurEntreeParUtilisateur);
                    }
                    else
                    {
                        MessageBox.Show("Il n'est pas possible d'avoir plus de plages horraires qu'il n'y � d'heure dans la journ�e.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void unProgValiderPlageHorraire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            explication.Text = "Veuillez remplir les donn�es dans les cases indiqu�s ci-dessous dans l'ordre indiqu�.";
            panel1.Controls.Add(explication);
        }

        public void UnProgBoxCreation(int valeurEntreeParUtilisateur)
        {
            int nbPlageHorraire = valeurEntreeParUtilisateur;
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

                if (i == nbPlageHorraire - 1)
                {
                    derniereLocation = textboxesHorraire[i].Location;
                }
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

                int newY = derniereLocation.Y + 50;
                Point derniereLocationMaj = new Point(derniereLocation.X, newY);
                unProgGo.Location = derniereLocationMaj;
                unProgGo.Visible = true;
            }
        }
        public double CalculerReponse()
        {
            double add = 0.0;

            if (textboxesHorraire != null && textboxesTemperature != null && textboxesHorraire.Length == textboxesTemperature.Length)
            {
                for (int i = 0; i < textboxesHorraire.Length; i++)
                {
                    if (double.TryParse(textboxesHorraire[i].Text, out double horaire) &&
                        double.TryParse(textboxesTemperature[i].Text, out double temperature))
                    {
                        add += horaire * temperature;
                    }
                }
            }

            double moy = add / 24.0;
            string moyFormatted = moy.ToString("F2");

            return double.Parse(moyFormatted);
        }

        public void UnProgGo_Click(object sender, EventArgs e)
        {
            reponseCalcul = new TextBox();
            reponseCalcul.Size = new Size(100, 25);

            // Calculer la r�ponse en fonction des valeurs dans textboxesHorraire et textboxesTemperature
            double reponse = CalculerReponse();
            reponseCalcul.Text = reponse.ToString();

            // Positionner la bo�te sous le bouton unProgGo
            Point position = new Point(unProgGo.Location.X, unProgGo.Location.Y + unProgGo.Height + 25);
            reponseCalcul.Location = position;
            panel1.Controls.Add(reponseCalcul);
        }


        /*____________________________________________________________________________________________________________________________________________________________*/

        private void plusieursProgrammes_CheckedChanged(object sender, EventArgs e) // PLUSIEURS PROG
        {
            CheckBox currentCheckBox = (CheckBox)sender;

            plusieursProgrammesBriefing.Visible = plusieursProgrammes.Checked;
            nombreProgParSemaine.Visible = plusieursProgrammes.Checked;
            plusieursProgValiderNbProg.Visible = plusieursProgrammes.Checked;

            if (currentCheckBox.Checked)
            {
                if (unProgramme.Checked)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        buttonReinitialiser_Click(sender, e);
                    }
                }
                unProgramme.Checked = false;
            }

            if (explicationPProg != null) // Plusieurs Prog
            {
                explicationPProg.Visible = false;
            }

            if (textboxesnbprog != null)
            {
                foreach (TextBox textBox in textboxesnbprog)
                {
                    textBox.Visible = false;
                }
            }

            if (numProgrammesList != null)
            {
                foreach (TextBox textBox in numProgrammesList)
                {
                    textBox.Visible = false;
                }
                numProgrammesList.Clear();
            }

            if (numProgrammesList2 != null)
            {
                foreach (TextBox textBox in numProgrammesList2)
                {
                    textBox.Visible = false;
                }
            }

            if (indiqnbjoursparprog != null)
            {
                foreach (TextBox textBox in indiqnbjoursparprog)
                {
                    textBox.Visible = false;
                }
            }

            if (textboxesHorraire2List != null)
            {
                foreach (TextBox textBox in textboxesHorraire2List)
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

            if (pProgPlageHorrairesList != null)
            {
                foreach (TextBox textBox in pProgPlageHorrairesList)
                {
                    textBox.Visible = false;
                }
            }

            if (plusieursProgValiderNbJourParProg != null)
            {
                plusieursProgValiderNbJourParProg.Visible = false;
            }

            if (plusieursProgValiderPlageHorraires != null)
            {
                plusieursProgValiderPlageHorraires.Visible = false;
            }

            if (PProgPH != null)
            {
                PProgPH.Visible = false;
            }

            if (PProgGo != null)
            {
                PProgGo.Visible = false;
            }
        }

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
                        valeurEntreeParUtilisateurPProg = tempValeurProgParSemaine;
                        nombreProgParSemaine.ReadOnly = true;

                        // Appel la m�thode de la classe 'plusieurs prog.'
                        PlusieursProgExplication();
                        PlusieursProgNbProgBoxCreation();
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

        private void plusieursProgValiderNbProg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            explicationPProg.ReadOnly = true;
            explicationPProg.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            explicationPProg.Text = "Veuillez indiquer ci-dessous le nombre de jours qui sont inclus dans chaques programmes.";
            panel1.Controls.Add(explicationPProg);
        }

        public void PlusieursProgNbProgBoxCreation()
        {
            int nbJoursParProg = valeurEntreeParUtilisateurPProg;
            int x = 732;
            int y = 400;
            int v = 0;
            const int largeur = 100;
            const int hauteur = 25;

            textboxesnbprog = new TextBox[nbJoursParProg];

            for (int i = 0; i < nbJoursParProg; i++)
            {
                v++;
                textboxesnbprog[i] = new TextBox();
                textboxesnbprog[i].Location = new Point(x, y + i * 50);
                textboxesnbprog[i].Size = new Size(largeur, hauteur);
                panel1.Controls.Add(textboxesnbprog[i]);
                textboxesnbprogList.Add(textboxesnbprog[i]);

                if (i == nbJoursParProg - 1)
                {
                    derniereLocationPP = textboxesnbprog[i].Location;
                }
            }

            v = 0;

            indiqnbjoursparprog = new TextBox[nbJoursParProg];

            for (int i = 0; i < nbJoursParProg; i++)
            {
                v++;
                indiqnbjoursparprog[i] = new TextBox();
                indiqnbjoursparprog[i].Location = new Point(x + 100, y + i * 50);
                indiqnbjoursparprog[i].Size = new Size(270, hauteur);
                indiqnbjoursparprog[i].Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                indiqnbjoursparprog[i].BackColor = SystemColors.InactiveCaption;
                indiqnbjoursparprog[i].BorderStyle = BorderStyle.None;
                indiqnbjoursparprog[i].Text = ("<- Nombres de jours pour le programme " + v);
                indiqnbjoursparprog[i].ReadOnly = true;
                indiqnbjoursparprog[i].Enabled = false;
                panel1.Controls.Add(indiqnbjoursparprog[i]);
            }

            int newY = derniereLocationPP.Y + 50;
            derniereLocationPPMaj = new Point(derniereLocationPP.X, newY);
            plusieursProgValiderNbJourParProg.Location = derniereLocationPPMaj;
            plusieursProgValiderNbJourParProg.Visible = true;
        }

        private void plusieursProgValiderNbJourParProg_Click(object sender, EventArgs e)
        {
            if (textboxesnbprog != null)
            {
                int sum = 0;
                foreach (TextBox textBox in textboxesnbprog)
                {
                    if (textBox.Text != "")
                    {
                        string valeurInscrit = textBox.Text;
                        int tempValeurJourParProg;

                        if (int.TryParse(valeurInscrit, out tempValeurJourParProg) && tempValeurJourParProg != 0)
                        {
                            if (tempValeurJourParProg < 7)
                            {
                                InstanceValeurJourParProg.Donnees.Add(valeurInscrit);
                                sum = sum + int.Parse(valeurInscrit);
                                if (sum > 7)
                                {
                                    MessageBox.Show("Il n'est pas possible que la somme des jours par programme d�passent les 7 jours de la semaine.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    foreach (TextBox textboxesnbprog in textboxesnbprogList)
                                    {
                                        textboxesnbprog.ReadOnly = true;
                                    }
                                    // Appel les m�thodes de la classe 'plusieurs prog box creation'
                                    PProgIndicationPlageHorraires(derniereLocationPPMaj);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Si vous avez 7 jours dans un programme veuillez cocher la case 1 programme en amont.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        void PProgIndicationPlageHorraires(Point derniereLocationPPMaj)
        {
            int dernierX = derniereLocationPPMaj.X;
            int dernierY = derniereLocationPPMaj.Y;
            const int largeur = 100;
            const int hauteur = 25;
            int v = 0;

            // Cr�er des listes temporaires pour les nouveaux contr�les
            List<TextBox> nouveauxNumProgrammesList = new List<TextBox>();
            List<TextBox> nouveauxTextboxesHorraire2List = new List<TextBox>();
            List<TextBox> nouveauxPProgPlageHorrairesList = new List<TextBox>();

            for (int i = 0; i < valeurEntreeParUtilisateurPProg; i++)
            {
                v++;

                TextBox numProgramme = new TextBox();
                TextBox textboxesHorraire2 = new TextBox();
                TextBox pProgPlageHorraires = new TextBox();

                numProgramme.Text = " - Programme " + v;
                numProgramme.Location = new Point(dernierX + 300, dernierY + 50);
                numProgramme.Size = new Size(largeur, hauteur);
                numProgramme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                numProgramme.BackColor = SystemColors.InactiveCaption;
                numProgramme.BorderStyle = BorderStyle.None;
                numProgramme.ReadOnly = true;
                numProgramme.Enabled = false;
                panel1.Controls.Add(numProgramme);
                nouveauxNumProgrammesList.Add(numProgramme);

                textboxesHorraire2.Location = new Point(dernierX, dernierY + 50);
                textboxesHorraire2.Size = new Size(largeur, hauteur);
                panel1.Controls.Add(textboxesHorraire2);
                nouveauxTextboxesHorraire2List.Add(textboxesHorraire2);

                pProgPlageHorraires.Location = new Point(dernierX + 100, dernierY + 50);
                pProgPlageHorraires.Size = new Size(largeur + 170, hauteur);
                pProgPlageHorraires.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                pProgPlageHorraires.BackColor = SystemColors.InactiveCaption;
                pProgPlageHorraires.BorderStyle = BorderStyle.None;
                pProgPlageHorraires.Text = "<-Nombres de plages horraires ";
                pProgPlageHorraires.ReadOnly = true;
                pProgPlageHorraires.Enabled = false;
                panel1.Controls.Add(pProgPlageHorraires);
                nouveauxPProgPlageHorrairesList.Add(pProgPlageHorraires);

                dernierY += 50; // Ajouter 1 pour l'espace entre les groupes de TextBox
            }

            // Supprimer les anciens contr�les de la liste
            foreach (TextBox textBox in numProgrammesList)
            {
                panel1.Controls.Remove(textBox);
            }
            numProgrammesList.Clear();

            foreach (TextBox textBox in textboxesHorraire2List)
            {
                panel1.Controls.Remove(textBox);
            }
            textboxesHorraire2List.Clear();

            foreach (TextBox textBox in pProgPlageHorrairesList)
            {
                panel1.Controls.Remove(textBox);
            }
            pProgPlageHorrairesList.Clear();

            // Mettre � jour les listes avec les nouveaux contr�les
            numProgrammesList = nouveauxNumProgrammesList;
            textboxesHorraire2List = nouveauxTextboxesHorraire2List;
            pProgPlageHorrairesList = nouveauxPProgPlageHorrairesList;

            dernierY += 50;
            derniereLocationPPMaj = new Point(dernierX, dernierY);
            plusieursProgValiderPlageHorraires.Location = derniereLocationPPMaj;
            plusieursProgValiderPlageHorraires.Visible = true;
        }



        private void plusieursProgValiderPlageHorraires_Click(object sender, EventArgs e)
        {
            if (textboxesHorraire2 != null)
            {
                foreach (TextBox textBox in textboxesHorraire2)
                {
                    if (textBox.Text != "")
                    {
                        string valeurInscrit = textBox.Text;
                        int tempValeurJourParProg;

                        if (int.TryParse(valeurInscrit, out tempValeurJourParProg) && tempValeurJourParProg != 0)
                        {
                            if (tempValeurJourParProg < 7)
                            {
                                InstancePProgPlageHorraires.PPPH.Add(valeurInscrit);
                                // Appel m�thodes 
                                PlusieursProgPlageHorraireBoxCreation(derniereLocationPPMaj);

                                foreach (TextBox TextboxesHorraire2 in textboxesHorraire2List)
                                {
                                    textBox.ReadOnly = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Si vous avez 7 jours dans un programme veuillez cocher la case 1 programme en amont.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Veuillez entrer un nombre valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        void PlusieursProgPlageHorraireBoxCreation(Point derniereLocationPPMaj)
        {
            int dernierX = derniereLocationPPMaj.X;
            int dernierY = derniereLocationPPMaj.Y;
            int v = 0;
            int v2 = 0;
            const int largeur = 100;
            const int hauteur = 25;

            foreach (string valeur in InstancePProgPlageHorraires.PPPH)
            {
                int valeurInt = int.Parse(valeur);

                v++;

                if (numProgramme2 != null)
                {
                    TextBox numProgramme2 = new TextBox(); // Cr�ez un nouveau contr�le TextBox pour chaque programme
                    numProgramme2.Text = "Programme " + v + " :";
                    numProgramme2.Location = new Point(dernierX, dernierY);
                    numProgramme2.Size = new Size(largeur, hauteur);
                    numProgramme2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    numProgramme2.BackColor = SystemColors.InactiveCaption;
                    numProgramme2.BorderStyle = BorderStyle.None;
                    numProgramme2.ReadOnly = true;
                    numProgramme2.Visible = true;
                    panel1.Controls.Add(numProgramme2);
                    numProgrammesList2.Add(numProgramme2);
                }

                v2 = 0;

                for (int i = 0; i < valeurInt; i++)
                {
                    v2++;
                    TextBox horaireTextBox = new TextBox();
                    horaireTextBox.Location = new Point(dernierX, dernierY + 50);
                    horaireTextBox.Size = new Size(largeur, hauteur);
                    horaireTextBox.Visible = true;
                    panel1.Controls.Add(horaireTextBox);
                    horaireTextBoxList.Add(horaireTextBox);


                    TextBox indiqHoraireTextBox = new TextBox();
                    indiqHoraireTextBox.Location = new Point(dernierX + 100, dernierY + 50);
                    indiqHoraireTextBox.Size = new Size(largeur, hauteur);
                    indiqHoraireTextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    indiqHoraireTextBox.BackColor = SystemColors.InactiveCaption;
                    indiqHoraireTextBox.BorderStyle = BorderStyle.None;
                    indiqHoraireTextBox.Text = "<-Horaires " + v2;
                    indiqHoraireTextBox.Enabled = false;
                    indiqHoraireTextBox.ReadOnly = true;
                    indiqHoraireTextBox.Visible = true;
                    panel1.Controls.Add(indiqHoraireTextBox);
                    indiqHoraireTextBoxList.Add(indiqHoraireTextBox);

                    TextBox temperatureTextBox = new TextBox();
                    temperatureTextBox.Location = new Point(dernierX + 373, dernierY + 50);
                    temperatureTextBox.Size = new Size(largeur, hauteur);
                    temperatureTextBox.Visible = true;
                    panel1.Controls.Add(temperatureTextBox);
                    temperatureTextBoxList.Add(temperatureTextBox);

                    TextBox indiqTemperatureTextBox = new TextBox();
                    indiqTemperatureTextBox.Location = new Point(dernierX + 273, dernierY + 50);
                    indiqTemperatureTextBox.Size = new Size(largeur, hauteur);
                    indiqTemperatureTextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    indiqTemperatureTextBox.BackColor = SystemColors.InactiveCaption;
                    indiqTemperatureTextBox.BorderStyle = BorderStyle.None;
                    indiqTemperatureTextBox.Text = "Temperature " + v2 + "->";
                    indiqTemperatureTextBox.Enabled = false;
                    indiqTemperatureTextBox.ReadOnly = true;
                    indiqTemperatureTextBox.Visible = true;
                    panel1.Controls.Add(indiqTemperatureTextBox);
                    indiqTemperatureTextBoxList.Add(indiqTemperatureTextBox);
                }

                dernierY += 50; // Ajouter 1 pour l'espace entre les groupes de TextBox
            }

            dernierY += 50;
            derniereLocationPPMaj = new Point(dernierX, dernierY);
            PProgPH.Location = derniereLocationPPMaj;
            PProgPH.Visible = true;
        }

    }
}
