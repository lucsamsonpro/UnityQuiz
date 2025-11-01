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
    public string R�ponse;
    public int RightScore;
    public int WrongScore;
    public int AnsweredScore;
    public int IgnoredScore;

    //D�claration tableau
    public string[] Quiz;


    private void Start()
    {
        //Composants
        TexteQuestion = GameObject.Find("TexteQuestion").GetComponent<Text>();
        TexteRightScore = GameObject.Find("TexteRightScore").GetComponent<Text>();
        TexteWrongScore = GameObject.Find("TexteWrongScore").GetComponent<Text>();
        NumeroQuestion = GameObject.Find("NumeroQuestion").GetComponent<Text>();
        TexteIgnoredScore = GameObject.Find("TexteIgnoredScore").GetComponent<Text>();
        TexteBouton1 = GameObject.Find("R�ponse1").GetComponent<Text>();
        TexteBouton2 = GameObject.Find("R�ponse2").GetComponent<Text>();
        TexteBouton3 = GameObject.Find("R�ponse3").GetComponent<Text>();
        TexteBouton4 = GameObject.Find("R�ponse4").GetComponent<Text>();
    }
    public void StartQuiz()
    {
        //Affichage
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeD�but();
        GameObject.Find("QuizManager").GetComponent<ViewManager>().CacherEcranDeFin();

        //Initialisation
        Quiz = new string[65];
        RightScore = 0;
        WrongScore = 0;
        AnsweredScore = 0;
        IgnoredScore = 0;
        IndexMemory = new List<int>();

        //D�claration du contenu du tableau
        Quiz[0] = "Qui a �crit Le Seigneur des Anneaux�?�Philip Pullman�Douglas Adams�J. R. R. Tolkien�C. S. Lewis�J. R. R. Tolkien";
        Quiz[1] = "Qui a �crit Les Mis�rables�?�Honor� de Balzac�Stendhal�George Sand�Victor Hugo�Victor Hugo";
        Quiz[2] = "Quand a �t� guillotin� Louis XVI�?�Le 14 juillet 1789�Le 21 janvier 1793�Le 21 septembre 1792�Le 16 octobre 1793�Le 21 janvier 1793";
        Quiz[3] = "Qui a �crit Hamlet�?�William Schakespear�William Shackespire�William Shrekhespeare�William Shakespeare�William Shakespeare";
        Quiz[4] = "Dans l�univers de Dune, quel est le nom de naissance d�Usul�?�Paul Atr�ides�Pierre Harkonnen�Jean Corrino�Beno�t Gesserit�Paul Atr�ides";
        Quiz[5] = "� quelle dynastie appartiennent Agamemnon, M�n�las, Oreste et �lectre�?�Arkon�nes�Atrides�Corinthos�Th�leilas�Atrides";
        Quiz[6] = "Quelle est la densit� papale de la cit�du Vatican�?�3,14�papes�au km� �1�pape�au km� �2,27�papes�au km� �0,94�papes�au km� �2,27�papes�au km� ";
        Quiz[7] = "Comment s�appelle le personnage principal d�Assassin�s Creed (2007)�?�Ald�baran�Antar�s�Arcturus�Alta�r�Alta�r";
        Quiz[8] = "Quel compositeur a re�u l�Oscar de la meilleure musique de film en 1995�?�Hans Zimmer�Otto K�che�Markus Garten�Friedrich Dusche�Hans Zimmer";
        Quiz[9] = "Quelle �tait la couleur du cheval blanc d�Henri IV�?�Bleu�Blanc�Rouge�C��tait une licorne, pas un cheval�Blanc";
        Quiz[10] = "Quel est le plombier le plus c�l�bre du jeu vid�o ?�Bubsy�Sonic�Mario�Crash Bandicoot�Mario";
        Quiz[11] = "Quel est le nom du h�risson bleu de Sega ?�Knuckles�Sonic�Shadow�Tails�Sonic";
        Quiz[12] = "Quel jeu Pok�mon n�existe pas�?�Rubis et Saphir�Am�thyste et Obsidienne�Soleil et Lune�Diamant et Perle�Am�thyste et Obsidienne";
        Quiz[13] = "Quel jeu propose de construire avec des blocs ?�Assassin�s Creed�Call of Duty�League of Legends�Minecraft�Minecraft";
        Quiz[14] = "Quel est le nom du h�ros principal de The Legend of Zelda ?�Zelda�Link�Ganondorf�Navi�Link";
        Quiz[15] = "Dans quel jeu incarne-t-on un personnage nomm� Lara Croft ?�Uncharted�Tomb Raider�Far Cry�Assassin�s Creed�Tomb Raider";
        Quiz[16] = "Quel jeu de tir populaire a un mode Battle Royale ?�Alexandra Ledermann 2 : Mon aventure au haras�Overwatch�Fortnite�Life is Strange�Fortnite";
        Quiz[17] = "Quel jeu de simulation de vie met en sc�ne les Sims ?�Second Life�Animal Crossing�Les Sims�Stardew Valley�Les Sims";
        Quiz[18] = "Quelle entreprise a cr�� la console PlayStation ?�Microsoft�Sony�Nintendo�Sega�Sony";
        Quiz[19] = "Quelle console portable a �t� cr��e par Nintendo ?�PSP�Game Boy�Atari Lynx�Dreamcast�Game Boy";
        Quiz[20] = "Comment est appel� le personnage principal de Halo ?�Marcus Fenix�Solid Snake�Major�Samus Aran�Major";
        Quiz[21] = "Dans quel jeu trouve-t-on Pikachu ?�Sonic�Street Fighter�Pok�mon�Mario Kart�Pok�mon";
        Quiz[22] = "Quelle entreprise est � l�origine de la console Xbox ?�Atari�Sony�Microsoft�Nintendo�Microsoft";
        Quiz[23] = "Dans quel jeu conduit-on des voitures sur des circuits ?�Gran Turismo�Tekken�FIFA�Diablo�Gran Turismo";
        Quiz[24] = "Quel est le but principal du jeu Tetris ?�Construire une maison�Empiler des formes pour faire des lignes�Tirer sur des ennemis�Attraper des monstres�Empiler des formes pour faire des lignes";
        Quiz[25] = "Dans quel jeu affronte-t-on Bowser ?�Kirby�Zelda�Super Mario Bros�Metroid�Super Mario Bros";
        Quiz[26] = "Quel jeu se d�roule dans la ville fictive de Los Santos ?�Saints Row�GTA V�Cyberpunk 2077�Watch Dogs�GTA V";
        Quiz[27] = "Quel jeu de sport est d�velopp� par EA Sports ?�Rocket League�PES�FIFA�NBA 2K�FIFA";
        Quiz[28] = "Dans quel jeu le joueur incarne Geralt de Riv ?�Elden Ring�The Witcher�Dark Souls�Skyrim�The Witcher";
        Quiz[29] = "Quel jeu met en sc�ne les combattants Ryu et Ken ?�Tekken�Street Fighter�Mortal Kombat�Soul Calibur�Street Fighter";
        Quiz[30] = "Dans la mythologie grecque, qui sont les parents d�H�racl�s ?�Alcm�ne et Zeus (sous l�apparence du mari d�Alcm�ne)�Alcm�ne et son mari Amphitryon�Alcm�ne et Apollon�Alcm�ne et Pos�idon�Alcm�ne et Zeus (sous l�apparence du mari d�Alcm�ne)";
        Quiz[31] = "Dans la mythologie grecque, qui sont les parents de Pers�e ?�Dana� et Apollon�Dana� et Zeus (sous l�apparence d�une pluie d�or)�Dana� et Ouranos�Dana� et Had�s�Dana� et Zeus (sous l�apparence d�une pluie d�or)";
        Quiz[32] = "Dans la mythologie grecque, qui sont les parents d�H�l�ne ?�L�da et Pos�idon�L�da et Ar�s�L�da et Zeus (sous l�apparence cygne)�L�da et Apollon�L�da et Zeus (sous l�apparence cygne)";
        Quiz[33] = "Dans la mythologie grecque, qui sont les parents de Minos ?�Europe et Pos�idon�Europe et H�pha�stos�Europe et Had�s�Europe et Zeus (sous l�apparence d�un taureau blanc)�Europe et Zeus (sous l�apparence d�un taureau blanc)";
        Quiz[34] = "Dans la mythologie grecque, qui sont les parents de �paphos ?�Io et Zeus (sous l�apparence d�un nuage)�Io et Apollon�Io et Herm�s�Io et Dionysos�Io et Zeus (sous l�apparence d�un nuage)";
        Quiz[35] = "Dans la mythologie grecque, qui sont les parents de Pers�phone ?�D�m�ter et Pos�idon�D�m�ter et Zeus (sous l�apparence d�un serpent)�D�m�ter et Ouranos�D�m�ter et Cronos�D�m�ter et Zeus (sous l�apparence d�un serpent)";
        Quiz[36] = "Quel est l�unit� de la force ?�le watt�le joule�le newton�le pascal�le newton";
        Quiz[37] = "Quel gaz est le plus abondant dans l�air ?�Dioxyg�ne�Diazote�Dioxyde de carbone�Argon�Diazote";
        Quiz[38] = "Quelle est la formule de l�eau ?�CO2�H2O�O2�CH4�H2O";
        Quiz[39] = "Quel instrument mesure la pression ?�Thermom�tre�Voltm�tre�Barom�tre�Ohmm�tre�Barom�tre";
        Quiz[40] = "Quelle est l�unit� de la puissance �lectrique ?�volt�amp�re�ohm�watt�watt";
        Quiz[41] = "Quel physicien a formul� la th�orie de la relativit� g�n�rale ?�Einstein�Galil�e�Newton�Kepler�Einstein";
        Quiz[42] = "Que mesure un amp�rem�tre ?�La tension �lectrique�La r�sistance �lectrique�L�intensit� d�un courant �lectrique�La puissance �lectrique�L�intensit� d�un courant �lectrique";
        Quiz[43] = "Quel est le symbole du fer dans le tableau p�riodique ?�Fe�Ir�F�Fr�Fe";
        Quiz[44] = "Quel est l�organe principal de la respiration ?�Le c�ur�Le foie�Les poumons�L�estomac�Les poumons";
        Quiz[45] = "Quel est le gaz essentiel � la photosynth�se ?�CO2�O2�N2�H2�CO2";
        Quiz[46] = "Quel est le plus grand organe du corps humain ?�Le cerveau�La peau�Le foie�Le c�ur�La peau";
        Quiz[47] = "Quelle mol�cule transporte l�oxyg�ne dans le sang ?�L�eau�L�h�moglobine�La chlorophylle�Le glucose�L�h�moglobine";
        Quiz[48] = "A quoi participe le diaphragme ?�La digestion�La respiration�La filtration r�nale�La circulation sanguine�La respiration";
        Quiz[49] = "Comment appelle-t-on la fusion de deux gam�tes ?�La mitose�La m�iose�La f�condation�La respiration�La f�condation";
        Quiz[50] = "Quel est le principal constituant des os ?�Fer�Calcium�Magn�sium�Soufre�Calcium";
        Quiz[51] = "O� se situe l�ADN dans une cellule eucaryote ?�Cytoplasme�Noyau�Membrane�Ribosome�Noyau";
        Quiz[52] = "Quel organe filtre le sang dans le corps humain ?�Le cerveau�Le rein�Le c�ur�Le pancr�as�Le rein";
        Quiz[53] = "En quelle ann�e a eu lieu la R�volution fran�aise ?�1789�1815�1852�1914�1789";
        Quiz[54] = "Qui �tait le premier empereur romain ?�C�sar�Auguste�N�ron�Trajan�Auguste";
        Quiz[55] = "Comment est mort le roi de France Charles VIII�Renvers� par un cochon dans une rue�Br�l� vif lors d�un bal costum�Fracass� contre une porte trop basse pour lui et son cheval�Tomb� en marchant sur sa barbe�Fracass� contre une porte trop basse pour lui et son cheval";
        Quiz[56] = "Quel �v�nement marque la fin du Moyen �ge ?�Chute de Rome�Chute de Constantinople�D�couverte de l�Am�rique�Guerre de Cent Ans�Chute de Constantinople";
        Quiz[57] = "Qui a (re)d�couvert l�Am�rique en 1492 ?�Vasco de Gama�Christophe Colomb�Fernand de Magellan�James Cook�Christophe Colomb";
        Quiz[58] = "Quelle guerre a eu lieu de 1914 � 1918 ?�Guerre de Quatre Ans�Seconde Guerre mondiale�Premi�re Guerre mondiale�Guerre froide�Premi�re Guerre mondiale";
        Quiz[59] = "Qui a �t� le premier pr�sident du Conseil national de la R�sistance�?�Jean Moulin�Charles de Gaulle�Philippe Leclerc�Fran�ois Mitterrand�Jean Moulin";
        Quiz[60] = "D�o� �tait originaire Napol�on Bonaparte ?�Paris�Bretagne�Corse�Guyane�Corse";
        Quiz[61] = "Quelle ville fut bombard�e en 1945 par la bombe atomique ?�Berlin�Tokyo�Hiroshima�S�oul�Hiroshima";
        Quiz[62] = "Quelle r�volution eut lieu en 1917 ?�Fran�aise�Industrielle�Russe�Chinoise�Russe";
        Quiz[63] = "Dans ��Qui veut gagner de l�argent en masse��, quelle r�ponse revient � chaque question�?�La r�ponse A�La r�ponse B�La r�ponse C�La r�ponse D�La r�ponse D";
        Quiz[64] = "Dans H2G2, quelle est la r�ponse � la grande question sur la vie, l'Univers et le reste�?�Oui�Chuck Norris�42�La r�ponse D�42";




        QuizPoseUneQuestion();
    }

    void Update()
    {
        NumeroQuestion.text = "Question n� " + IndexMemory.Count;

        if(RightScore <= 1)
        {
            TexteRightScore.text = RightScore + " bonne r�ponse";
        }
        else
        {
            TexteRightScore.text = RightScore + " bonnes r�ponses";
        }

        if (WrongScore <=1 )
        {
            TexteWrongScore.text = WrongScore + " mauvaise r�ponse";
        }
        else
        {
            TexteWrongScore.text = WrongScore + " mauvaises r�ponses";
        }

        if (IgnoredScore <=1 )
        {
            TexteIgnoredScore.text = IgnoredScore + " question ignor�e";
        }
        else
        {
            TexteIgnoredScore.text = IgnoredScore + " questions ignor�es";
        }

    }
    public void QuizPoseUneQuestion()
    {
        GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
        QuizChoisitUneQuestion();
        string[] Col = Quiz[Index].Split('�');
        TexteQuestion.text = Col[0];
        TexteBouton1.text = Col[1];
        TexteBouton2.text = Col[2];
        TexteBouton3.text = Col[3];
        TexteBouton4.text = Col[4];
        R�ponse = Col[5];
        GameObject.Find("QuizManager").GetComponent<TimeManager>().TimerStart();
    }

    public void QuizChoisitUneQuestion()
    {
        if (IndexMemory.Count == Quiz.Length)
        {
            Debug.Log("Toutes les questions ont �t� pos�es !");
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
