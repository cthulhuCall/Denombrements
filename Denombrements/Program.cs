/**
 * titre : Denombrements
 * description : permet le calcul de permutation, d'arrangement et de combinaison
 * auteur : LF
 * date création : 22/11/2020
 * date dernière modification : 23/11/2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Fonction permettant le contrôle des saisies.
        /// </summary>
        /// <param name="message">Permet d'afficher un message personnalisé avant la saisie.</param>
        /// <returns></returns>
        static int Saisie(string message)
        {
            int nombre = 0;
            bool correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write(message);
                    nombre = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Saisissez un entier.");
                }
            }
            return nombre;
        }
        /// <summary>
        /// Fonction permettant de multiplier une suite d'entiers, d'une valeur à une autre.
        /// </summary>
        /// <param name="nb">Permet de changer uniquement la taille de la boucle</param>
        /// <param name="nbre">Permet une soustraction de k lors de son initialisation (1er terme).</param>
        /// <param name="sousEnsemble">Permet une soustraction de k lors de son initialisation (second terme).</param>
        /// <returns></returns>
        static long CalculSuite(int nb, int nbre, int sousEnsemble)
        {
            long resultat = 1;
            for (int k = (nbre - sousEnsemble + 1); k <= nb; k++)
                resultat *= k;
            return resultat;
        }
        static void Main(string[] args)
        {
            int nbTotal, sousEnsemble;
            // Boucle sur le menu
            int choix = 1;
            while (choix != 0)
            {
                // Affichage du menu
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                // Saisie du choix
                Console.Write("Saisissez votre choix = ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {                    
                    case 1:
                        // Saisie des nombres avec contrôle
                        nbTotal = Saisie("Nombre total d'éléments à gérer = ");
                        // Calcul et affichage du resultat                        
                        Console.WriteLine(nbTotal + "! = " + CalculSuite(nbTotal, 0, 0));
                        break;
                    case 2:
                        // Saisie des nombres avec contrôle
                        nbTotal = Saisie("Nombre total d'éléments à gérer = ");
                        sousEnsemble = Saisie("Nombre d'éléments dans le sous ensemble = ");                        
                        // Calcul et affichage du résultat
                        Console.WriteLine("A(" + nbTotal + "/" + sousEnsemble + ") = " + CalculSuite(nbTotal, nbTotal, sousEnsemble));
                        break;
                    case 3:
                        // Saisie des nombres avec contrôle
                        nbTotal = Saisie("Nombre total d'éléments à gérer = ");
                        sousEnsemble = Saisie("Nombre d'éléments dans le sous ensemble = ");                       
                        // Calcul et affichage du résultat
                        Console.WriteLine("C(" + nbTotal + "/" + sousEnsemble + ") = " + (CalculSuite(nbTotal, nbTotal, sousEnsemble) / CalculSuite(sousEnsemble, 0, 0)));
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }               
            }
            Console.ReadLine();
        }
    }
}
