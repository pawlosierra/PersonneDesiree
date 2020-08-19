using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneDesiree
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonneDesiree p = new PersonneDesiree.Builder()
                     .WithSexe(SexeSouhaite.Femme)
                     .WithMin_age(17)
                     .WithMax_age(100)
                     .WithCouleur_cheveu(CouleurCheveuSouhaite.blond)
                     .WithCouleur_yeux(CouleurYeuxSouhaite.bleus)
                     .WithEducation(EducationSouhaite.baccaloureat)
                     .Build();

            Console.WriteLine("client 1");
            Console.WriteLine(" Sexe de la personne desiree: " + p.Sexe);
            Console.WriteLine(" age minimal: " + p.Min_age);
            Console.WriteLine(" age maximal: " + p.Max_age);
            Console.WriteLine(" pays d'origine: " + p.Pays_origine);
            Console.WriteLine(" couleur du cheveu: " + p.Couleur_cheveu);
            Console.WriteLine(" couleur du yeux: " + p.Couleur_yeux);
            Console.WriteLine(" niveau minimal d'etudes: " + p.Education);
            Console.WriteLine();

            PersonneDesiree p1 = new PersonneDesiree.Builder()
                     .WithSexe(SexeSouhaite.Homme)
                     .WithMin_age(19)
                     .WithMax_age(67)
                     .WithCouleur_cheveu(CouleurCheveuSouhaite.brun)
                     .Build();

            Console.WriteLine("client 2");
            Console.WriteLine(" Sexe de la personne desiree: " + p1.Sexe);
            Console.WriteLine(" age minimal: " +  p1.Min_age);
            Console.WriteLine(" age maximal: " + p1.Max_age);
            Console.WriteLine(" pays d'origine: " + p1.Pays_origine);
            Console.WriteLine(" couleur du cheveu: " + p1.Couleur_cheveu);
            Console.WriteLine();

           
            PersonneDesiree p2 = new PersonneDesiree.Builder()
                    .WithSexe(SexeSouhaite.Inconnu)
                    .WithMin_age(22)
                    .WithMax_age(30)
                    .WithCouleur_cheveu(CouleurCheveuSouhaite.noir)
                    .WithCouleur_yeux(CouleurYeuxSouhaite.verts)
                    .WithEducation(EducationSouhaite.maitrise)
                    .Build();


            Console.WriteLine("client 3");
            Console.WriteLine(" Sexe de la personne desiree: " + p2.Sexe);
            Console.WriteLine(" age minimal: " + p2.Min_age);
            Console.WriteLine(" age maximal: " + p2.Max_age);
            Console.WriteLine(" pays d'origine: " + p2.Pays_origine);
            Console.WriteLine(" couleur du cheveu: " + p2.Couleur_cheveu);
            Console.WriteLine(" couleur du yeux: " + p2.Couleur_yeux);
            Console.WriteLine(" niveau minimal d'etudes: " + p2.Education);
            Console.WriteLine();


            PersonneDesiree p3 = new PersonneDesiree.Builder()
                .Build();

            Console.WriteLine("client 4");
            Console.WriteLine(" Sexe de la personne desiree: " + p3.Sexe);
            Console.WriteLine(" age minimal: " + p3.Min_age);
            Console.WriteLine(" age maximal: " + p3.Max_age);
            Console.WriteLine(" pays d'origine: " + p3.Pays_origine);
            Console.WriteLine(" couleur du cheveu: " + p3.Couleur_cheveu);
            Console.WriteLine(" couleur du yeux: " + p3.Couleur_yeux);
            Console.WriteLine(" niveau minimal d'etudes: " + p3.Education);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
