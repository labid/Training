using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enseigant_Etudiant.Model
{
/// <summary>
/// Classe enseignat hértire de la clase <see cref="Personne"/>
/// </summary>
    internal class Enseignant : Personne
    {
        /// <summary>
        /// Variable Grade
        /// </summary>
        public string Grade { get; set; } 
        public Enseignant(int id, string name, int age, string grade) : base(id, name, age)
        {
            Grade = grade;
        }
        /// <summary>
        /// Affichage
        /// </summary>
        /// <returns>les informations de l'enseignant</returns>
        public override string ToString()
        {
            return base.ToString() + " Grade " + Grade ;
        }
    }
}
