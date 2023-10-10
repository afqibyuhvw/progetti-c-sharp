namespace pag94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            il voto finale
            se 15 punti crediti e 70 punti i prof possono dare fino a 5 punti bonus
            input:
            -name
            -3 voti scritti
            -voto orale
            -credito
            -bonus points
            -tipo di scuola (1-4)

            output:
            se voto finale >= 60 promosso
            se voto finael >100 100 e lode
            tipo di attestato (1-4)
             */

            string name;
            int mark1, mark2, mark3, oral_mark, credits, school;

            Console.Write("Insert the name of the student: ");
            name = Console.ReadLine();

            
            Console.WriteLine("1) Istituto Tecnico settore economico;");
            Console.WriteLine("2) Liceo scientifico;");
            Console.WriteLine("3) Istituto Tecnico settore Tecnologico;");
            Console.WriteLine("4) Istituto Professionale Settore dei servizi");
            Console.WriteLine("Insert the number of the school: ");
            school = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the mark of the first write test: ");
            mark1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the mark of the second write test: ");
            mark2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the mark of the third write test: ");
            mark3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the mark of the oral test: ");
            oral_mark = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert the credits of the student: ");
            credits = Convert.ToInt32(Console.ReadLine());

            int partial_mark = credits + oral_mark + mark1 + mark2 + mark3;
            int bonus_points = 0;
            if(partial_mark > 70 && credits >= 15)
            {
                Console.Write("The student has more thant 70points, insert the number of bonus points: ");
                bonus_points = Convert.ToInt32(Console.ReadLine());
            }

            string school_graduation = "Scuola non inserita";
            switch(school)
            {
                case 1:
                    school_graduation = "diploma di istruzione tecnica";
                    break;
                case 2:
                    school_graduation = "Diploma liceale";
                    break;
                case 3:
                    school_graduation = "Diploma di istruzione tecnica";
                    break;
                case 4:
                    school_graduation = "Diploma di istruzione Professionale";
                    break;
                default:
                    Console.WriteLine("Error 404");
                    break;
            }
            int final_mark = partial_mark + bonus_points;

            if(final_mark > 100)
            {
                Console.WriteLine($"Studente promosso con 100 e lode! {school_graduation}");
            }
            else if(final_mark >= 60)
            {
                Console.WriteLine($"Studente promosso! punteggio di {final_mark}. {school_graduation}");
            }
            else if(final_mark < 60)
            {
                Console.WriteLine($"Studente non promosso! punteggio di {final_mark}. {school_graduation}");
            }


        }
    }
}