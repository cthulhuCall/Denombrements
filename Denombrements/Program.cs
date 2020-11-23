/**
 * titre : Denombrements
 * description : permet le calcul de permutation, d'arrangement et de combinaison
 * auteur : LF
 * date création : 22/11/2020
 * date dernière modification : 23/11/2020
 */

using System;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Fonction permettant de multiplier une suite d'entiers, d'une valeur à une autre.
        /// </summary>
        /// <param name="valDebut">Valeur d'initialisation de k pour le calcul.</param>
        /// <param name="valFin">Valeur permettant de définir la taille de la boucle.</param>
        /// <returns></returns>
        static long CalculSuite(int valDebut, int valFin)
        {
            long resultat = 1;
            for (int k = valDebut; k <= valFin; k++)
                resultat *= k;
            return resultat;
        }
        /// <summary>
        /// Boucle sur le menu permettant d'accéder aux différents calculs.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int nbTotal, sousEnsemble;
            // Boucle sur le menu
            string choix = "1";
            while (choix != "0")
            {
                // Affichage du menu
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                // Saisie du choix
                Console.Write("Saisissez votre choix = ");
                choix = Console.ReadLine();
                // Contrôle de saisie du choix
                if (choix == "1" || choix == "2" || choix == "3")
                {
                    try
                    {
                        // Saisie d'un nombre
                        Console.Write("Nombre total d'éléments à gérer = ");
                        nbTotal = int.Parse(Console.ReadLine());
                        if (choix == "1")
                        {
                            // Calcul et affichage du resultat
                            long permutation = CalculSuite(1, nbTotal);
                            Console.WriteLine(nbTotal + "! = " + permutation);
                        }
                        else
                        {
                            Console.Write("Nombre d'éléments dans le sous ensemble = ");
                            sousEnsemble = int.Parse(Console.ReadLine());
                            long arrangement = CalculSuite(nbTotal - sousEnsemble + 1, nbTotal);
                            if (choix == "2") 
                            {                                
                                // Calcul et affichage du résultat
                                Console.WriteLine("A(" + nbTotal + "/" + sousEnsemble + ") = " + arrangement);
                            }
                            else
                            {
                                // Calcul et affichage du résultat
                                long combinaison = arrangement / CalculSuite(1, sousEnsemble);
                                Console.WriteLine("C(" + nbTotal + "/" + sousEnsemble + ") = " + combinaison);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de calcul. Saisir une valeur correcte.");
                    }
                }
            }
        }
    }
}
