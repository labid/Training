// See https://aka.ms/new-console-template for more information


using Enseigant_Etudiant.Model;


#region declaration
List<Personne> personnes = new List<Personne>();
#endregion

#region Alimentation Etudiant
Personne person = new Etudiant(1, "Imad", 34, "Master");
    personnes.Add(person);
    person = new Etudiant(2, "Adil", 38, "Licence");
    personnes.Add(person);
    person = new Etudiant(3, "Soundouse", 30, "Maitrise");
    personnes.Add(person);
#endregion

#region Aliemntation Enseigant
    person = new Enseignant(4, "Tmimi", 62, "ISTA");
    personnes.Add(person);
    person = new Enseignant(5, "Bou9ri3a", 70, "Primaire");
    personnes.Add(person);
#endregion

#region affichage
    foreach (var item in personnes)
    {
        Console.WriteLine(item);
    }
#endregion




