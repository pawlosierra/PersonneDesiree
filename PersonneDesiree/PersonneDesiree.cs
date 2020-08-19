using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneDesiree
{
    public class PersonneDesiree
    {
        private int min_age;
        private int max_age;
       
        public SexeSouhaite Sexe { get; private set; }
        public int Min_age
        {
            get => min_age;
            private set
            {
                if (value < 18)
                {
                    min_age = 18;
                    Console.WriteLine("L’âge minimal doit être plus grand ou égal à 18 ans");
                }
                else
                {
                    min_age = value;
                }
            }
        }
        public int Max_age{get;private set;}
        public PaysOrigineSouhaite Pays_origine { get; private set; }
        public CouleurCheveuSouhaite Couleur_cheveu { get; private set; }
        public CouleurYeuxSouhaite Couleur_yeux { get; private set; }
        public EducationSouhaite Education { get; private set; }
        

        public PersonneDesiree(SexeSouhaite sexe, int min_age, int max_age, PaysOrigineSouhaite pays_origine,
            CouleurCheveuSouhaite couleur_cheveu, CouleurYeuxSouhaite couleur_yeux, EducationSouhaite education)
        {
            this.Sexe = sexe;
            this.Min_age = min_age;
            this.Max_age = max_age;
            this.Pays_origine = pays_origine;
            this.Couleur_cheveu = couleur_cheveu;
            this.Couleur_yeux = couleur_yeux;
            this.Education = education;
        }

        public class Builder
        {
            public SexeSouhaite Sexe { get; private set; }=SexeSouhaite.vite;
            public int Min_age { get; private set; } = 18;
            public int Max_age { get; private set; } = 110;
            public PaysOrigineSouhaite Pays_origine { get; private set; } = PaysOrigineSouhaite.vite;
            public CouleurCheveuSouhaite Couleur_cheveu { get; private set; } = CouleurCheveuSouhaite.vite;
            public CouleurYeuxSouhaite Couleur_yeux { get; private set; } = CouleurYeuxSouhaite.vite;
            public EducationSouhaite Education { get; private set; } = EducationSouhaite.vite;
           

            public Builder()
            {
            }

            public Builder WithSexe(SexeSouhaite sexe)
            {
                this.Sexe = sexe;
                return this;
            }
            public Builder WithMin_age(int v)
            {
                this.Min_age = 18;
                return this;
            }
            public Builder WithMax_age(int v)
            {
                this.Max_age = v;
                return this;
            }
            public Builder WithPays_origine(PaysOrigineSouhaite v)
            {
                this.Pays_origine = v;
                return this;
            }
            public Builder WithCouleur_cheveu(CouleurCheveuSouhaite v)
            {
                this.Couleur_cheveu = v;
                return this;
            }
            public Builder WithCouleur_yeux(CouleurYeuxSouhaite v)
            {
                this.Couleur_yeux = v;
                return this;
            }
            public Builder WithEducation(EducationSouhaite v)
            {
                this.Education = v;
                return this;
            }
            
            public PersonneDesiree Build()
            {
                return new PersonneDesiree(this);
            }

        }  // fin de la classe Builder

        private PersonneDesiree(Builder b)
        {
            this.Sexe = b.Sexe;
            this.Min_age = b.Min_age;
            this.Max_age = b.Max_age;
            this.Pays_origine = b.Pays_origine;
            this.Couleur_cheveu = b.Couleur_cheveu;
            this.Couleur_yeux = b.Couleur_yeux;
            this.Education = b.Education;
        }
    }
}
