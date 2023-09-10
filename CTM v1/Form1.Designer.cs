namespace CTM_v1
{
    partial class CTM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            objectifDuProgramme = new TextBox();
            titre = new RichTextBox();
            unProgramme = new CheckBox();
            plusieursProgrammes = new CheckBox();
            explicationFonctionnel1 = new TextBox();
            buttonReinitialiser = new Button();
            unProgrammeBriefing = new TextBox();
            unProgPlageHorraires = new TextBox();
            unProgGo = new Button();
            plusieursProgrammesBriefing = new TextBox();
            nombreProgParSemaine = new TextBox();
            unProgValiderPlageHorraire = new Button();
            plusieursProgValiderNbProg = new Button();
            plusieursProgValiderNbJourParProg = new Button();
            plusieursProgValiderPlageHorraires = new Button();
            PProgPH = new Button();
            PProgGo = new Button();
            vScrollBar = new VScrollBar();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // objectifDuProgramme
            // 
            objectifDuProgramme.BackColor = SystemColors.InactiveCaption;
            objectifDuProgramme.BorderStyle = BorderStyle.None;
            objectifDuProgramme.Enabled = false;
            objectifDuProgramme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            objectifDuProgramme.Location = new Point(12, 63);
            objectifDuProgramme.Multiline = true;
            objectifDuProgramme.Name = "objectifDuProgramme";
            objectifDuProgramme.ReadOnly = true;
            objectifDuProgramme.Size = new Size(777, 34);
            objectifDuProgramme.TabIndex = 0;
            objectifDuProgramme.Text = "Bonjour, ce programme est un calculateur de température moyenne permettant de vous donner la moyenne mensuelle\r\nen Celsius.";
            objectifDuProgramme.TextChanged += objectifDuProgramme_TextChanged;
            // 
            // titre
            // 
            titre.BackColor = SystemColors.Info;
            titre.Enabled = false;
            titre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            titre.Location = new Point(12, 12);
            titre.Name = "titre";
            titre.ReadOnly = true;
            titre.Size = new Size(278, 43);
            titre.TabIndex = 1;
            titre.Text = "CALCULATEUR DE TEMPERATURE MOYENNE\nVersion 1.0";
            titre.TextChanged += titre_TextChanged;
            // 
            // unProgramme
            // 
            unProgramme.AutoSize = true;
            unProgramme.BackColor = SystemColors.InactiveCaption;
            unProgramme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            unProgramme.Location = new Point(12, 155);
            unProgramme.Name = "unProgramme";
            unProgramme.Size = new Size(120, 21);
            unProgramme.TabIndex = 3;
            unProgramme.Text = "Un programme";
            unProgramme.UseVisualStyleBackColor = false;
            unProgramme.CheckedChanged += unProgramme_CheckedChanged;
            unProgramme.Validated += unProgramme_Validated;
            // 
            // plusieursProgrammes
            // 
            plusieursProgrammes.AutoSize = true;
            plusieursProgrammes.BackColor = SystemColors.InactiveCaption;
            plusieursProgrammes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            plusieursProgrammes.Location = new Point(12, 184);
            plusieursProgrammes.Name = "plusieursProgrammes";
            plusieursProgrammes.Size = new Size(163, 21);
            plusieursProgrammes.TabIndex = 4;
            plusieursProgrammes.Text = "Plusieurs programmes";
            plusieursProgrammes.UseVisualStyleBackColor = false;
            plusieursProgrammes.CheckedChanged += plusieursProgrammes_CheckedChanged;
            plusieursProgrammes.Validated += plusieursProgrammes_Validated;
            // 
            // explicationFonctionnel1
            // 
            explicationFonctionnel1.BackColor = SystemColors.InactiveCaption;
            explicationFonctionnel1.BorderStyle = BorderStyle.None;
            explicationFonctionnel1.CausesValidation = false;
            explicationFonctionnel1.Enabled = false;
            explicationFonctionnel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            explicationFonctionnel1.ForeColor = SystemColors.ActiveCaptionText;
            explicationFonctionnel1.Location = new Point(12, 103);
            explicationFonctionnel1.Multiline = true;
            explicationFonctionnel1.Name = "explicationFonctionnel1";
            explicationFonctionnel1.ReadOnly = true;
            explicationFonctionnel1.Size = new Size(777, 43);
            explicationFonctionnel1.TabIndex = 5;
            explicationFonctionnel1.Text = "Pour commencer, vous devez définir si vous avez un programme qui englobe toute la semaine ou si vous avez plusieurs programme à paramètrer pour la semaine.";
            explicationFonctionnel1.TextChanged += explicationFonctionnel1_TextChanged;
            // 
            // buttonReinitialiser
            // 
            buttonReinitialiser.BackColor = Color.Red;
            buttonReinitialiser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReinitialiser.ForeColor = Color.White;
            buttonReinitialiser.Location = new Point(1307, 12);
            buttonReinitialiser.Name = "buttonReinitialiser";
            buttonReinitialiser.Size = new Size(93, 43);
            buttonReinitialiser.TabIndex = 6;
            buttonReinitialiser.Text = "Réinitialiser";
            buttonReinitialiser.UseVisualStyleBackColor = false;
            buttonReinitialiser.Click += buttonReinitialiser_Click;
            // 
            // unProgrammeBriefing
            // 
            unProgrammeBriefing.BackColor = Color.CornflowerBlue;
            unProgrammeBriefing.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            unProgrammeBriefing.Location = new Point(12, 249);
            unProgrammeBriefing.Multiline = true;
            unProgrammeBriefing.Name = "unProgrammeBriefing";
            unProgrammeBriefing.ReadOnly = true;
            unProgrammeBriefing.Size = new Size(474, 44);
            unProgrammeBriefing.TabIndex = 7;
            unProgrammeBriefing.Text = "Veuillez noter dans la case si dessous le nombre de plages horraires / température différentes que vous souhaitez paramétrer dans une journée.";
            unProgrammeBriefing.TextChanged += unProgrammeBriefing_TextChanged;
            // 
            // unProgPlageHorraires
            // 
            unProgPlageHorraires.Location = new Point(12, 299);
            unProgPlageHorraires.Name = "unProgPlageHorraires";
            unProgPlageHorraires.Size = new Size(100, 25);
            unProgPlageHorraires.TabIndex = 8;
            unProgPlageHorraires.TextChanged += unProgPlageHorraires_TextChanged;
            // 
            // plusieursProgrammesBriefing
            // 
            plusieursProgrammesBriefing.BackColor = Color.LightCoral;
            plusieursProgrammesBriefing.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            plusieursProgrammesBriefing.Location = new Point(732, 249);
            plusieursProgrammesBriefing.Multiline = true;
            plusieursProgrammesBriefing.Name = "plusieursProgrammesBriefing";
            plusieursProgrammesBriefing.ReadOnly = true;
            plusieursProgrammesBriefing.Size = new Size(474, 44);
            plusieursProgrammesBriefing.TabIndex = 9;
            plusieursProgrammesBriefing.Text = "Combien de programmes avez vous prévu dans la semaine ?";
            plusieursProgrammesBriefing.TextChanged += plusieursProgrammesBriefing_TextChanged;
            // 
            // nombreProgParSemaine
            // 
            nombreProgParSemaine.Location = new Point(732, 299);
            nombreProgParSemaine.Name = "nombreProgParSemaine";
            nombreProgParSemaine.Size = new Size(100, 25);
            nombreProgParSemaine.TabIndex = 10;
            nombreProgParSemaine.TextChanged += nombreProgParSemaine_TextChanged;
            // 
            // unProgValiderPlageHorraire
            // 
            unProgValiderPlageHorraire.Location = new Point(118, 299);
            unProgValiderPlageHorraire.Name = "unProgValiderPlageHorraire";
            unProgValiderPlageHorraire.Size = new Size(75, 23);
            unProgValiderPlageHorraire.TabIndex = 11;
            unProgValiderPlageHorraire.Text = "Valider";
            unProgValiderPlageHorraire.UseVisualStyleBackColor = true;
            unProgValiderPlageHorraire.Click += unProgValiderPlageHorraire_Click;
            unProgValiderPlageHorraire.KeyPress += unProgValiderPlageHorraire_KeyPress;
            //
            // unProgGo
            //
            unProgGo.Visible = false;
            unProgGo.Name = "GO!";
            unProgGo.Size = new Size(75, 23);
            unProgGo.TabIndex = 14;
            unProgGo.Text = "Calculer";
            unProgGo.UseVisualStyleBackColor = true;
            unProgGo.Click += UnProgGo_Click;
            // 
            // plusieursProgValiderNbProg
            // 
            plusieursProgValiderNbProg.Location = new Point(838, 299);
            plusieursProgValiderNbProg.Name = "plusieursProgValiderNbProg";
            plusieursProgValiderNbProg.Size = new Size(75, 23);
            plusieursProgValiderNbProg.TabIndex = 12;
            plusieursProgValiderNbProg.Text = "Valider";
            plusieursProgValiderNbProg.UseVisualStyleBackColor = true;
            plusieursProgValiderNbProg.Click += plusieursProgValiderNbProg_Click;
            plusieursProgValiderNbProg.KeyPress += plusieursProgValiderNbProg_KeyPress;
            //
            // plusieursProgValiderNbJourParProg
            //               
            plusieursProgValiderNbJourParProg.Name = "plusieursProgValiderNbJourParProg";
            plusieursProgValiderNbJourParProg.Size = new Size(75, 23);
            plusieursProgValiderNbJourParProg.Visible = false;
            plusieursProgValiderNbJourParProg.TabIndex = 13;
            plusieursProgValiderNbJourParProg.Text = "Valider";
            plusieursProgValiderNbJourParProg.UseVisualStyleBackColor = true;          
            plusieursProgValiderNbJourParProg.Click += plusieursProgValiderNbJourParProg_Click;
            plusieursProgValiderNbJourParProg.KeyPress += plusieursProgValiderNbProg_KeyPress;
            //
            // plusieursProgValiderPlageHorraires
            //
            plusieursProgValiderPlageHorraires.Name = "plusieursProgValiderPlageHorraires";
            plusieursProgValiderPlageHorraires.Size = new Size(75, 23);
            plusieursProgValiderPlageHorraires.Visible = false; 
            plusieursProgValiderPlageHorraires.TabIndex = 16;
            plusieursProgValiderPlageHorraires.Text = "Valider";
            plusieursProgValiderPlageHorraires.UseVisualStyleBackColor = true;
            plusieursProgValiderPlageHorraires.Click += plusieursProgValiderPlageHorraires_Click;

            //
            // PProgPH
            //
            PProgPH.Visible = false;
            PProgPH.Name = "GO!";
            PProgPH.Size = new Size(75, 23);
            PProgPH.TabIndex = 15;
            PProgPH.Text = "Valider";
            PProgPH.UseVisualStyleBackColor = true;
            //
            // PProgGo
            //
            PProgGo.Visible = false;
            PProgGo.Name = "GO!";
            PProgGo.Size = new Size(75, 23);
            PProgGo.TabIndex = 17;
            PProgGo.Text = "Calculer";
            PProgGo.UseVisualStyleBackColor = true;
            // 
            // vScrollBar
            // 
            vScrollBar.Dock = DockStyle.Right;
            vScrollBar.Location = new Point(0, 0);
            vScrollBar.Name = "vScrollBar";
            vScrollBar.Size = new Size(17, 80);
            vScrollBar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(PProgGo);
            panel1.Controls.Add(plusieursProgValiderPlageHorraires);
            panel1.Controls.Add(plusieursProgValiderNbJourParProg);
            panel1.Controls.Add(plusieursProgValiderNbProg);
            panel1.Controls.Add(unProgValiderPlageHorraire);
            panel1.Controls.Add(nombreProgParSemaine);
            panel1.Controls.Add(plusieursProgrammesBriefing);
            panel1.Controls.Add(unProgGo);
            panel1.Controls.Add(unProgPlageHorraires);
            panel1.Controls.Add(unProgrammeBriefing);
            panel1.Controls.Add(buttonReinitialiser);
            panel1.Controls.Add(explicationFonctionnel1);
            panel1.Controls.Add(plusieursProgrammes);
            panel1.Controls.Add(unProgramme);
            panel1.Controls.Add(titre);
            panel1.Controls.Add(objectifDuProgramme);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 961);
            panel1.TabIndex = 14;
            panel1.Scroll += VScrollBar_Scroll;
            // 
            // CTM
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1424, 961);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "CTM";
            Text = "CTM - Calculateur de température moyenne";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox titre;
        private Button buttonReinitialiser;
        private TextBox objectifDuProgramme;
        private TextBox explicationFonctionnel1;
        private CheckBox unProgramme;
        private CheckBox plusieursProgrammes;
        private TextBox unProgrammeBriefing;
        private TextBox unProgPlageHorraires;
        private Button unProgGo;
        private TextBox plusieursProgrammesBriefing;
        private TextBox nombreProgParSemaine;
        private Button unProgValiderPlageHorraire;
        private Button plusieursProgValiderNbProg;
        private Button plusieursProgValiderNbJourParProg;
        private Button plusieursProgValiderPlageHorraires;
        private Button PProgPH;
        private Button PProgGo;
        private Panel panel1;
        private VScrollBar vScrollBar;
    }
}