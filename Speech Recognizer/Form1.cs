using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;//Permet la reconnaissance vocale
using System.Speech.Synthesis;//Permet de faire parler l'ordinateur
using System.Media;//Permet de lire des fichiers .wav
using System.Globalization;//Gère les langues disponibles
using System.Text.RegularExpressions;
using MouseKeyboardActivityMonitor.WinApi;
using MouseKeyboardActivityMonitor;

//Ceci est un début de contrôle vocal rien de bien compliqué pour l'instant
//Pour commencer à parler à Olivia, vous devez tout d'abord appuyer sur le bouton de gauche 
//puis une fois l'ordre terminer appuyer sur le bouton de droite
//Chaque commande doit être d'abord rentrée dans les commandes, elle n'apprend pas encore seul ;)
//Pour ce qui est de la lecture de musique, le programme ne lis que des .wav
//Amusez-vous bien en tout cas moi je m'éclate

namespace Speech_Recognizer
{
    public partial class Form1 : Form
    {
        int i = 0;

        //Pour les touches

        //private readonly KeyboardHookListener m_KeyboardHookManager;

        SpeechRecognitionEngine recEngine =
        new SpeechRecognitionEngine(new CultureInfo("fr-FR"));//Permet de comprendre le français
        //SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        SoundPlayer son = new SoundPlayer("C:\\Users\\antho\\Documents\\Speech Recognizer\\23222.wav");

        
        Player Player1 = new Player();

        bool flagPlayer = false;
        bool flagPositionX = false;
        bool flagPositionY = false;
        bool flagAttaq = false;
        bool flagDef = false;


        public Form1()
        {
            InitializeComponent();
            DisableButton.Enabled = false;
            enableButton.Enabled = true;

            //Pour les touches

            //m_KeyboardHookManager = new KeyboardHookListener(new GlobalHooker());
            //m_KeyboardHookManager.Enabled = true;
            //m_KeyboardHookManager.KeyPress += HookManager_KeyPress;
        }

        //Pour la touche espace

        //private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(e.KeyChar == (char)Keys.Space)
        //    {
        //        if (a == 0)
        //        {
        //            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        //            a = 1;
        //        }
        //    }

        //    else 
        //    {
        //        a = 0;
        //        recEngine.RecognizeAsyncStop();
        //    }
        //}

        private void enableButton_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            DisableButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string>numberList = new List<string>();
            
            for (i = 0; i < 10; i++)
            {
                numberList.Add(Convert.ToString(i));
            }

            Choices commands = new Choices();
            commands.Add(new string[] { "écrit mon nom", "dit bonjour", "bienvenu", "clear",
                                        "bonjour olivia", "play music", "stop music", "joueur", "0",
                                        "1", "2", "3", "4", "sinque", "6", "7", "8", "9", "10", "11",
                                        "position en x", "position en y", "affiche", "attaque", "defense" });
                                        // Il reconnait les chiffres           

            //commands.Add(regexList);
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;
        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //richTextBox1.Text += e.Result.Text;
            switch (e.Result.Text)
            {
                case "dit bonjour":
                    synthesizer.SpeakAsync("okay ! ");

                    System.Threading.Thread.Sleep(1000);
                    MessageBox.Show("Hello Anthony");
                    break;
                case "écrit mon nom":
                    richTextBox1.Text += "\nAnthony";
                    System.Threading.Thread.Sleep(1000);
                    synthesizer.SpeakAsync("Quel beau prénom ! ");
                    break;
                case "clear":
                    richTextBox1.Text = "Parlez encore";
                    break;
                case "bonjour olivia":
                    synthesizer.SpeakAsync("Bonjour mon nom est Olivia que puis-je faire pour vous ? ");
                    //richTextBox1.Text += e.Result.Text;
                    break;
                case "play music":
                    synthesizer.SpeakAsync("okay let's go ! ");

                    System.Threading.Thread.Sleep(1000);
                    son.Play();
                    break;
                case "stop music":
                    son.Stop();
                    System.Threading.Thread.Sleep(1000);
                    synthesizer.SpeakAsync("oh dommage c'était bien ");
                    break;
                case "sinque":
                    if (flagPlayer)
                        Player1.number = 5;
                    if (flagPositionX)
                        Player1.positionx = 5;
                    if (flagPositionY)
                        Player1.positiony = 5;
                    if (flagAttaq)
                        Player1.attaq = 5;
                    if (flagDef)
                        Player1.defense = 5;

                    flagPlayer = false;
                    flagPositionX = false;
                    flagPositionY = false;
                    flagAttaq = false;
                    flagDef = false;

                    labelPlayer.Text = Convert.ToString(Player1.number);
                    labelPosX.Text = Convert.ToString(Player1.positionx);
                    labelPosY.Text = Convert.ToString(Player1.positiony);
                    labelAttaq.Text = Convert.ToString(Player1.attaq);
                    labelDef.Text = Convert.ToString(Player1.defense);
                    break;
                case "affiche":
                    labelPlayer.Text = Convert.ToString(Player1.number);
                    labelPosX.Text = Convert.ToString(Player1.positionx);
                    labelPosY.Text = Convert.ToString(Player1.positiony);
                    break;
                case "joueur":
                    flagPlayer = true;
                    break;
                case "position en x":
                    flagPositionX = true;
                    break;
                case "position en y":
                    flagPositionY = true;
                    break;
                case "attaque":
                    flagAttaq = true;
                    break;
                case "defense":
                    flagDef = true;
                    break;
                default:
                    richTextBox1.Text += "error";
                    break;
            };

            if (int.TryParse(e.Result.Text, out i)) //Permet de savoir si c'est un nombre
            {
                if (flagPlayer)
                    Player1.number = Convert.ToInt32(e.Result.Text);
                if (flagPositionX)
                    Player1.positionx = Convert.ToDouble(e.Result.Text);
                if (flagPositionY)
                    Player1.positiony = Convert.ToDouble(e.Result.Text);
                if (flagAttaq)
                    Player1.attaq = Convert.ToDouble(e.Result.Text);
                if (flagDef)
                    Player1.defense = Convert.ToDouble(e.Result.Text);

                flagPlayer = false;
                flagPositionX = false;
                flagPositionY = false;
                flagAttaq = false;
                flagDef = false;

                labelPlayer.Text = Convert.ToString(Player1.number);
                labelPosX.Text = Convert.ToString(Player1.positionx);
                labelPosY.Text = Convert.ToString(Player1.positiony);
                labelAttaq.Text = Convert.ToString(Player1.attaq);
                labelDef.Text = Convert.ToString(Player1.defense);

                richTextBox1.Text = e.Result.Text;
            }
        }



        private void DisableButton_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            DisableButton.Enabled = false;
        }

    }
}
