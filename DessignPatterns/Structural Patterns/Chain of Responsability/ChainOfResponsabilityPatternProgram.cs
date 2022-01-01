using DessignPatterns.Structural_Patterns.Chain_of_Responsability.Exercise;
using DessignPatterns.Structural_Patterns.Chain_of_Responsability.Games;
using System;
using System.Collections.Generic;
using System.Text;
using Exercise = DessignPatterns.Structural_Patterns.Chain_of_Responsability.Exercise;

namespace DessignPatterns.Structural_Patterns.Chain_of_Responsability
{
    public class ChainOfResponsabilityPatternProgram
    {
        public static void RunMethodChain()
        {
            var goblin = new Creature("Goblin", 2, 2);
            Console.WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            //Goblin receive spell damage
            root.Add(new NoBonusesModifier(goblin));

            Console.WriteLine("Let's double the goblin's attack");
            root.Add(new DoubleAttackModifier(goblin));
            
            Console.WriteLine("Let's increase goblin's defense");
            root.Add(new IncreaseDefenseModifier(goblin));

            root.Handle();

            Console.WriteLine(goblin);
        }

        //Chain of responsability as mediator
        //event broker
        public static void RunBrokerChain()
        {
            var game = new Games.Game();
            var goblin = new Games.Creature(game, "Strong Goblin", 3, 3);
            Console.WriteLine(goblin);

            using (new Games.DoubleAttackModifier(game, goblin))
            {
                Console.WriteLine(goblin);
                using (new Games.IncreaseDefenseModifier(game, goblin))
                {
                    Console.WriteLine(goblin);
                }
            }
            Console.WriteLine(goblin);
        }

        public static void RunExercise()
        {
            //var game = new ExerciseCourse.Game();
            //var goblin = new ExerciseCourse.Goblin(game);
            //game.Creatures.Add(goblin);
            //Console.WriteLine(goblin.Attack);

            //var goblin2 = new ExerciseCourse.Goblin(game);
            //game.Creatures.Add(goblin2);
            //Console.WriteLine(goblin2.Attack);

            //var goblin3 = new ExerciseCourse.GoblinKing(game);
            //game.Creatures.Add(goblin3);
            //Console.WriteLine(goblin.Attack);

            var game = new Exercise.Game();
            var goblin = new Exercise.Goblin(game);
            game.Creatures.Add(goblin);
            Console.WriteLine(goblin);

            var goblin2 = new Exercise.Goblin(game);
            game.Creatures.Add(goblin2);
            Console.WriteLine(goblin);
            Console.WriteLine(goblin2);
        }
    }
}
