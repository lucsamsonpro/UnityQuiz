using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class QuestionManager : MonoBehaviour

{
    private Text TexteQuestion;
    private int Index;
    public List<int> IndexMemory;
    private Text TexteRightScore;
    private Text TexteWrongScore;
    private Text NumeroQuestion;
    private Text TexteIgnoredScore;
    private Text TexteBouton1;
    private Text TexteBouton2;
    private Text TexteBouton3;
    private Text TexteBouton4;
    public string Réponse;
    public int RightScore;
    public int WrongScore;
    public int AnsweredScore;
    public int IgnoredScore;

    //Déclaration tableau
    public string[] Quiz;


    private void Start()
    {
        //Composants
        TexteQuestion = GameObject.Find("TexteQuestion").GetComponent<Text>();
        TexteRightScore = GameObject.Find("TexteRightScore").GetComponent<Text>();
        TexteWrongScore = GameObject.Find("TexteWrongScore").GetComponent<Text>();
        NumeroQuestion = GameObject.Find("NumeroQuestion").GetComponent<Text>();
        TexteIgnoredScore = GameObject.Find("TexteIgnoredScore").GetComponent<Text>();
        TexteBouton1 = GameObject.Find("Réponse1").GetComponent<Text>();
        TexteBouton2 = GameObject.Find("Réponse2").GetComponent<Text>();
        TexteBouton3 = GameObject.Find("Réponse3").GetComponent<Text>();
        TexteBouton4 = GameObject.Find("Réponse4").GetComponent<Text>();
    }
    public void StartQuiz()
    {
        //Affichage
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeDébut();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeFin();

        //Initialisation
        Quiz = new string[65];
        RightScore = 0;
        WrongScore = 0;
        AnsweredScore = 0;
        IgnoredScore = 0;
        IndexMemory = new List<int>();

        //Déclaration du contenu du tableau
        Quiz[0] = "Qui a écrit Le Seigneur des Anneaux ?§Philip Pullman§Douglas Adams§J. R. R. Tolkien§C. S. Lewis§J. R. R. Tolkien";
        Quiz[1] = "Qui a écrit Les Misérables ?§Honoré de Balzac§Stendhal§George Sand§Victor Hugo§Victor Hugo";
        Quiz[2] = "Quand a été guillotiné Louis XVI ?§Le 14 juillet 1789§Le 21 janvier 1793§Le 21 septembre 1792§Le 16 octobre 1793§Le 21 janvier 1793";
        Quiz[3] = "Qui a écrit Hamlet ?§William Schakespear§William Shackespire§William Shrekhespeare§William Shakespeare§William Shakespeare";
        Quiz[4] = "Dans l’univers de Dune, quel est le nom de naissance d’Usul ?§Paul Atréides§Pierre Harkonnen§Jean Corrino§Benoît Gesserit§Paul Atréides";
        Quiz[5] = "À quelle dynastie appartiennent Agamemnon, Ménélas, Oreste et Électre ?§Arkonènes§Atrides§Corinthos§Théleilas§Atrides";
        Quiz[6] = "Quelle est la densité papale de la cité du Vatican ?§3,14 papes au km² §1 pape au km² §2,27 papes au km² §0,94 papes au km² §2,27 papes au km² ";
        Quiz[7] = "Comment s’appelle le personnage principal d’Assassin’s Creed (2007) ?§Aldébaran§Antarès§Arcturus§Altaïr§Altaïr";
        Quiz[8] = "Quel compositeur a reçu l’Oscar de la meilleure musique de film en 1995 ?§Hans Zimmer§Otto Küche§Markus Garten§Friedrich Dusche§Hans Zimmer";
        Quiz[9] = "Quelle était la couleur du cheval blanc d’Henri IV ?§Bleu§Blanc§Rouge§C’était une licorne, pas un cheval§Blanc";
        Quiz[10] = "Quel est le plombier le plus célèbre du jeu vidéo ?§Bubsy§Sonic§Mario§Crash Bandicoot§Mario";
        Quiz[11] = "Quel est le nom du hérisson bleu de Sega ?§Knuckles§Sonic§Shadow§Tails§Sonic";
        Quiz[12] = "Quel jeu Pokémon n’existe pas ?§Rubis et Saphir§Améthyste et Obsidienne§Soleil et Lune§Diamant et Perle§Améthyste et Obsidienne";
        Quiz[13] = "Quel jeu propose de construire avec des blocs ?§Assassin’s Creed§Call of Duty§League of Legends§Minecraft§Minecraft";
        Quiz[14] = "Quel est le nom du héros principal de The Legend of Zelda ?§Zelda§Link§Ganondorf§Navi§Link";
        Quiz[15] = "Dans quel jeu incarne-t-on un personnage nommé Lara Croft ?§Uncharted§Tomb Raider§Far Cry§Assassin’s Creed§Tomb Raider";
        Quiz[16] = "Quel jeu de tir populaire a un mode Battle Royale ?§Alexandra Ledermann 2 : Mon aventure au haras§Overwatch§Fortnite§Life is Strange§Fortnite";
        Quiz[17] = "Quel jeu de simulation de vie met en scène les Sims ?§Second Life§Animal Crossing§Les Sims§Stardew Valley§Les Sims";
        Quiz[18] = "Quelle entreprise a créé la console PlayStation ?§Microsoft§Sony§Nintendo§Sega§Sony";
        Quiz[19] = "Quelle console portable a été créée par Nintendo ?§PSP§Game Boy§Atari Lynx§Dreamcast§Game Boy";
        Quiz[20] = "Comment est appelé le personnage principal de Halo ?§Marcus Fenix§Solid Snake§Major§Samus Aran§Major";
        Quiz[21] = "Dans quel jeu trouve-t-on Pikachu ?§Sonic§Street Fighter§Pokémon§Mario Kart§Pokémon";
        Quiz[22] = "Quelle entreprise est à l’origine de la console Xbox ?§Atari§Sony§Microsoft§Nintendo§Microsoft";
        Quiz[23] = "Dans quel jeu conduit-on des voitures sur des circuits ?§Gran Turismo§Tekken§FIFA§Diablo§Gran Turismo";
        Quiz[24] = "Quel est le but principal du jeu Tetris ?§Construire une maison§Empiler des formes pour faire des lignes§Tirer sur des ennemis§Attraper des monstres§Empiler des formes pour faire des lignes";
        Quiz[25] = "Dans quel jeu affronte-t-on Bowser ?§Kirby§Zelda§Super Mario Bros§Metroid§Super Mario Bros";
        Quiz[26] = "Quel jeu se déroule dans la ville fictive de Los Santos ?§Saints Row§GTA V§Cyberpunk 2077§Watch Dogs§GTA V";
        Quiz[27] = "Quel jeu de sport est développé par EA Sports ?§Rocket League§PES§FIFA§NBA 2K§FIFA";
        Quiz[28] = "Dans quel jeu le joueur incarne Geralt de Riv ?§Elden Ring§The Witcher§Dark Souls§Skyrim§The Witcher";
        Quiz[29] = "Quel jeu met en scène les combattants Ryu et Ken ?§Tekken§Street Fighter§Mortal Kombat§Soul Calibur§Street Fighter";
        Quiz[30] = "Dans la mythologie grecque, qui sont les parents d’Héraclès ?§Alcmène et Zeus (sous l’apparence du mari d’Alcmène)§Alcmène et son mari Amphitryon§Alcmène et Apollon§Alcmène et Poséidon§Alcmène et Zeus (sous l’apparence du mari d’Alcmène)";
        Quiz[31] = "Dans la mythologie grecque, qui sont les parents de Persée ?§Danaé et Apollon§Danaé et Zeus (sous l’apparence d’une pluie d’or)§Danaé et Ouranos§Danaé et Hadès§Danaé et Zeus (sous l’apparence d’une pluie d’or)";
        Quiz[32] = "Dans la mythologie grecque, qui sont les parents d’Hélène ?§Léda et Poséidon§Léda et Arès§Léda et Zeus (sous l’apparence cygne)§Léda et Apollon§Léda et Zeus (sous l’apparence cygne)";
        Quiz[33] = "Dans la mythologie grecque, qui sont les parents de Minos ?§Europe et Poséidon§Europe et Héphaïstos§Europe et Hadès§Europe et Zeus (sous l’apparence d’un taureau blanc)§Europe et Zeus (sous l’apparence d’un taureau blanc)";
        Quiz[34] = "Dans la mythologie grecque, qui sont les parents de Épaphos ?§Io et Zeus (sous l’apparence d’un nuage)§Io et Apollon§Io et Hermès§Io et Dionysos§Io et Zeus (sous l’apparence d’un nuage)";
        Quiz[35] = "Dans la mythologie grecque, qui sont les parents de Perséphone ?§Déméter et Poséidon§Déméter et Zeus (sous l’apparence d’un serpent)§Déméter et Ouranos§Déméter et Cronos§Déméter et Zeus (sous l’apparence d’un serpent)";
        Quiz[36] = "Quel est l’unité de la force ?§le watt§le joule§le newton§le pascal§le newton";
        Quiz[37] = "Quel gaz est le plus abondant dans l’air ?§Dioxygène§Diazote§Dioxyde de carbone§Argon§Diazote";
        Quiz[38] = "Quelle est la formule de l’eau ?§CO2§H2O§O2§CH4§H2O";
        Quiz[39] = "Quel instrument mesure la pression ?§Thermomètre§Voltmètre§Baromètre§Ohmmètre§Baromètre";
        Quiz[40] = "Quelle est l’unité de la puissance électrique ?§volt§ampère§ohm§watt§watt";
        Quiz[41] = "Quel physicien a formulé la théorie de la relativité générale ?§Einstein§Galilée§Newton§Kepler§Einstein";
        Quiz[42] = "Que mesure un ampèremètre ?§La tension électrique§La résistance électrique§L’intensité d’un courant électrique§La puissance électrique§L’intensité d’un courant électrique";
        Quiz[43] = "Quel est le symbole du fer dans le tableau périodique ?§Fe§Ir§F§Fr§Fe";
        Quiz[44] = "Quel est l’organe principal de la respiration ?§Le cœur§Le foie§Les poumons§L’estomac§Les poumons";
        Quiz[45] = "Quel est le gaz essentiel à la photosynthèse ?§CO2§O2§N2§H2§CO2";
        Quiz[46] = "Quel est le plus grand organe du corps humain ?§Le cerveau§La peau§Le foie§Le cœur§La peau";
        Quiz[47] = "Quelle molécule transporte l’oxygène dans le sang ?§L’eau§L’hémoglobine§La chlorophylle§Le glucose§L’hémoglobine";
        Quiz[48] = "A quoi participe le diaphragme ?§La digestion§La respiration§La filtration rénale§La circulation sanguine§La respiration";
        Quiz[49] = "Comment appelle-t-on la fusion de deux gamètes ?§La mitose§La méiose§La fécondation§La respiration§La fécondation";
        Quiz[50] = "Quel est le principal constituant des os ?§Fer§Calcium§Magnésium§Soufre§Calcium";
        Quiz[51] = "Où se situe l’ADN dans une cellule eucaryote ?§Cytoplasme§Noyau§Membrane§Ribosome§Noyau";
        Quiz[52] = "Quel organe filtre le sang dans le corps humain ?§Le cerveau§Le rein§Le cœur§Le pancréas§Le rein";
        Quiz[53] = "En quelle année a eu lieu la Révolution française ?§1789§1815§1852§1914§1789";
        Quiz[54] = "Qui était le premier empereur romain ?§César§Auguste§Néron§Trajan§Auguste";
        Quiz[55] = "Comment est mort le roi de France Charles VIII§Renversé par un cochon dans une rue§Brûlé vif lors d’un bal costumé§Fracassé contre une porte trop basse pour lui et son cheval§Tombé en marchant sur sa barbe§Fracassé contre une porte trop basse pour lui et son cheval";
        Quiz[56] = "Quel événement marque la fin du Moyen Âge ?§Chute de Rome§Chute de Constantinople§Découverte de l’Amérique§Guerre de Cent Ans§Chute de Constantinople";
        Quiz[57] = "Qui a (re)découvert l’Amérique en 1492 ?§Vasco de Gama§Christophe Colomb§Fernand de Magellan§James Cook§Christophe Colomb";
        Quiz[58] = "Quelle guerre a eu lieu de 1914 à 1918 ?§Guerre de Quatre Ans§Seconde Guerre mondiale§Première Guerre mondiale§Guerre froide§Première Guerre mondiale";
        Quiz[59] = "Qui a été le premier président du Conseil national de la Résistance ?§Jean Moulin§Charles de Gaulle§Philippe Leclerc§François Mitterrand§Jean Moulin";
        Quiz[60] = "D’où était originaire Napoléon Bonaparte ?§Paris§Bretagne§Corse§Guyane§Corse";
        Quiz[61] = "Quelle ville fut bombardée en 1945 par la bombe atomique ?§Berlin§Tokyo§Hiroshima§Séoul§Hiroshima";
        Quiz[62] = "Quelle révolution eut lieu en 1917 ?§Française§Industrielle§Russe§Chinoise§Russe";
        Quiz[63] = "Dans « Qui veut gagner de l’argent en masse », quelle réponse revient à chaque question ?§La réponse A§La réponse B§La réponse C§La réponse D§La réponse D";
        Quiz[64] = "Dans H2G2, quelle est la réponse à la grande question sur la vie, l'Univers et le reste ?§Oui§Chuck Norris§42§La réponse D§42";




        QuizPoseUneQuestion();
    }

    void Update()
    {
        NumeroQuestion.text = "Question n° " + IndexMemory.Count;

        if(RightScore <= 1)
        {
            TexteRightScore.text = RightScore + " bonne réponse";
        }
        else
        {
            TexteRightScore.text = RightScore + " bonnes réponses";
        }

        if (WrongScore <=1 )
        {
            TexteWrongScore.text = WrongScore + " mauvaise réponse";
        }
        else
        {
            TexteWrongScore.text = WrongScore + " mauvaises réponses";
        }

        if (IgnoredScore <=1 )
        {
            TexteIgnoredScore.text = IgnoredScore + " question ignorée";
        }
        else
        {
            TexteIgnoredScore.text = IgnoredScore + " questions ignorées";
        }

    }
    public void QuizPoseUneQuestion()
    {
        GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
        QuizChoisitUneQuestion();
        string[] Col = Quiz[Index].Split('§');
        TexteQuestion.text = Col[0];
        TexteBouton1.text = Col[1];
        TexteBouton2.text = Col[2];
        TexteBouton3.text = Col[3];
        TexteBouton4.text = Col[4];
        Réponse = Col[5];
        GameObject.Find("QuizManager").GetComponent<TimeManager>().TimerStart();
    }

    public void QuizChoisitUneQuestion()
    {
        if (IndexMemory.Count == Quiz.Length)
        {
            Debug.Log("Toutes les questions ont été posées !");
        }
        else
        {
            Index = Random.Range(0, Quiz.Length);
            while (IndexMemory.Contains(Index))
            {
                Index = Random.Range(0, Quiz.Length);
            }
            IndexMemory.Add(Index);
        }
    }
}
