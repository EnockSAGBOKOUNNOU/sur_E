using System;

namespace mon_premier_projet_en_cs
{
    public class Program
    {
       // static string MonNom = "";


        static string name(int n)
        {
            string MonNom = "";
            while (MonNom == "")
            {

                Console.Write("Quel est le nom de la personne N°" + n + " ?");
                MonNom = Console.ReadLine();
                MonNom = MonNom.Trim();
                if (MonNom == "")
                {

                    Console.WriteLine("ERREUR: le champs nom est vide  ");
                    Console.WriteLine("Veillez Entrez un nom valide ");
                    Console.Write("Quel est ton nom?");
                    MonNom = Console.ReadLine();
                }


            }
            return MonNom;

        }
      //  static int MonAge_int = 0;

        static int DemnderAge(String nom) {


            int MonAge_int = 0;
            while (MonAge_int <= 0)
            {
                Console.Write( nom  +", Quel est votre âge??");
                string MonAge_str = Console.ReadLine();
                // string ageProchain = MonAge + 1;
                try
                {
                    MonAge_int = int.Parse(MonAge_str);
                    if (MonAge_int < 0)
                    {
                        Console.WriteLine("ERREUR: L'age ne doit pas être négatif");
                    }
                    if (MonAge_int == 0)
                    {
                        Console.WriteLine("ERREUR: Entrez un age plus grand que 0 ");
                    }


                }
                catch
                {
                    Console.WriteLine("ERREUR: vous devez entrez un age  valides");
                }
            }return MonAge_int;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
                        Console.Write("Quel est ton nom?");
                        string nomDeLaPersonne = Console.ReadLine();
                        Console.WriteLine("Bonjour vou vous appellez " + nomDeLaPersonne);
                        Console.WriteLine(nomDeLaPersonne + " c'est bien mon nom");*/

           string Nom1 = name(1);
            string Nom2 = name(2);

            int MonAge1 = DemnderAge(Nom1);
            int MonAge2 = DemnderAge(Nom2);



            /* DemnderAge(Nom1);
             DemnderAge(Nom2);
 */
            Console.WriteLine();
            Console.WriteLine("Vous vous appellez " + Nom1 + " et vous avez " + MonAge1 + " ans");
            //int ageProchain = MonAge_int + 1;


            Console.WriteLine("Bientôt vous aurez " + (MonAge1 + 1) + " ans");
            
            Console.WriteLine();
            Console.WriteLine("Vous vous appellez " + Nom2 + " et vous avez " + MonAge2 + " ans");
            //int ageProchain = MonAge_int + 1;


            Console.WriteLine("Bientôt vous aurez " + (MonAge2 + 1) + " ans");


            Console.ReadLine();
        }
    }
}