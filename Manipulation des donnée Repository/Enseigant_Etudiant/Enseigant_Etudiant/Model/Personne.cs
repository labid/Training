using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enseigant_Etudiant.Model
{
    /// <summary>
    /// Classe personne, abstact
    /// </summary>
    internal abstract class Personne
    {

        /// <summary>
        /// Identifiant 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nom et prénom de la perssone
        /// </summary>
        public string Name { get; set; } = "";   
        /// <summary>
        /// l'age en entier de la personne
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Constructeur de la classe Perssone
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Personne(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return "Id : " + Id + " Name " +  Name  + " Age " + Age;
        }
    }
}
