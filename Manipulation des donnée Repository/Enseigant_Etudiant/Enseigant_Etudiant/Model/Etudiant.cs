using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enseigant_Etudiant.Model
{
    /// <summary>
    /// Classe etudiant, hérite de la classe abtract <see cref="Personne"/>
    /// </summary>
    internal class Etudiant : Personne
    {
        public string classe { get; set; }

        public Etudiant(int id, string name,int age, string classe) :base(id,name,age)
        {
            this.classe = classe;
        }

        public override string ToString()
        {
            return base.ToString() + " Niveau classe : " + classe ;
        }
    }
}
