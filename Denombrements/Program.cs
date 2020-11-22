/**
 * titre : Denombrements
 * description : permet le calcul de permutation, d'arrangement et de combinaison
 * auteur : LF
 * date création : 22/11/2020
 * date dernière modification : 22/11/2020
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
        static void Main(string[] args)
        {
            int nbTotal = 0, sousEnsemble = 0;
            long resultat;
            bool correct;

            // Boucle sur le menu
            int choix = 1;
            while (choix != 0)
            {
                // Affichage du menu
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");

                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Choix :                            ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Saisissez un entier.");
                    }
                }
                switch (choix)
                {                    
                    case 1:                        
                        // Saisie des nombres avec contrôle
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = ");
                                nbTotal = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier.");
                            }
                            
                        }
                        // Calcul de resultat
                        resultat = 1;
                        for (int k = 1; k <= nbTotal; k++)
                            resultat *= k;
                        // Affichage du résultat
                        Console.WriteLine(nbTotal + "! = " + resultat);
                        break;

                    case 2:
                        // Saisie des nombres avec contrôle
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = ");
                                nbTotal = int.Parse(Console.ReadLine());
                                Console.Write("nombre d'éléments dans le sous ensemble = ");
                                sousEnsemble = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier.");
                            }
                        }
                        // Calcul de resultat
                        resultat = 1;
                        for (int k = (nbTotal - sousEnsemble + 1); k <= nbTotal; k++)
                            resultat *= k;
                        // Affichage du résultat
                        Console.WriteLine("A(" + nbTotal + "/" + sousEnsemble + ") = " + resultat);
                        break;

                    case 3:
                        // Saisie des nombres ace contrôle
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write("nombre total d'éléments à gérer = ");
                                nbTotal = int.Parse(Console.ReadLine());
                                Console.Write("nombre d'éléments dans le sous ensemble = ");
                                sousEnsemble = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Saisissez un entier.");
                            }
                        }
                        // Calcul de resultat1
                        long resultat1 = 1;
                        for (int k = (nbTotal - sousEnsemble + 1); k <= nbTotal; k++)
                            resultat1 *= k;
                        // Calcul de resultat2
                        long resultat2 = 1;
                        for (int k = 1; k <= sousEnsemble; k++)
                            resultat2 *= k;
                        // Affichage du résultat
                        Console.WriteLine("C(" + nbTotal + "/" + sousEnsemble + ") = " + (resultat1 / resultat2));
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
