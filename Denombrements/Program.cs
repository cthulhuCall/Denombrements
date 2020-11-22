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
            int choix = 1;
            while (choix != 0)
            {
                // Affichage du menu
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) { Environment.Exit(0); }

                if (choix == 1)
                {
                    // Calcul de la permutation
                    Console.Write("nombre total d'éléments à gérer = ");
                    // Saisie des nombres
                    int nbTotal = int.Parse(Console.ReadLine());  
                    // Calcul de resultat
                    long resultat = 1;
                    for (int k = 1; k <= nbTotal; k++)
                        resultat *= k;
                    // Affichage du résultat
                    Console.WriteLine(nbTotal + "! = " + resultat);
                }
                else
                {
                    if (choix == 2)
                    {
                        // Calcul de l'arrangement
                        Console.Write("nombre total d'éléments à gérer = ");
                        // Saisie des nombres
                        int nbTotal = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int sousEnsemble = int.Parse(Console.ReadLine());
                        // Calcul de resultat
                        long resultat = 1;
                        for (int k = (nbTotal - sousEnsemble + 1); k <= nbTotal; k++)
                            resultat *= k;
                        // Affichage du résultat
                        Console.WriteLine("A(" + nbTotal + "/" + sousEnsemble + ") = " + resultat);
                    }
                    else
                    {
                        // Calcul de la combinaison
                        Console.Write("nombre total d'éléments à gérer = "); 
                        // Saisie des nombres
                        int nbTotal = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int sousEnsemble = int.Parse(Console.ReadLine());
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
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
