using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Chain_of_Responsability.ExerciseCourse
{
    //Chain of Responsibility Coding Exercise

    //You are given a game scenario with classes Goblin and GoblinKing.Please implement the following
    //    rules:


    //    A goblin has base 1 attack/1 defense (1/1), a goblin king is 3/3.
    //    When the Goblin King is in play, every other goblin gets +1 Attack.
    //    Goblins get +1 to Defense for every other Goblin in play(a GoblinKing is a Goblin!).

    //Example:

    //    Suppose you have 3 ordinary goblins in play.Each one is a 1/3 (1/1 + 0/2 defense bonus).

    //    A goblin king comes into play.Now every goblin is a 2/4 (1/1 + 0/3 defense bonus from each
    //        other + 1/0 from goblin king)

    //The state of all the goblins has to be consistent as goblins are added and removed from the
    //    game.

    //Example
    //var game = new Exercise.Game();
    //var goblin = new Goblin(game);
    //game.Creatures.Add(goblin);
    //        Console.WriteLine(goblin.Attack);

    //        var goblin2 = new Goblin(game);
    //game.Creatures.Add(goblin2);
    //        Console.WriteLine(goblin.Attack);

    //        var goblin3 = new GoblinKing(game);
    //game.Creatures.Add(goblin3);
    //        Console.WriteLine(goblin.Attack);
    public abstract class Creature
    {
        protected Game _game;
        protected readonly int _baseAttack;
        protected readonly int _baseDefense;

        protected Creature(Game game, int baseAttack, int baseDefense)
        {
            _game = game;
            _baseAttack = baseAttack;
            _baseDefense = baseDefense;
        }

        public virtual int Attack { get; set; }
        public virtual int Defense { get; set; }
        public abstract void Query(object source, StatQuery sq);

    }

    public enum Statistic
    {
        Attack, Defense
    }

    public class StatQuery
    {
        public Statistic Statistic;
        public int Result;
    }

    public class Goblin : Creature
    {
        public Goblin(Game game) : base(game, 1, 1)
        {
        }

        public Goblin(Game game, int baseAttack, int baseDefense) 
            : base(game, baseAttack, baseDefense)
        {
            
        }

        public override int Attack { 
            get
            {
                var q = new StatQuery { Statistic = Statistic.Attack };
                foreach (var c in _game.Creatures)
                {
                    c.Query(this, q);
                }
                return q.Result;
            } 
        }
        public override int Defense {
            get
            {
                var q = new StatQuery { Statistic = Statistic.Defense };
                foreach (var c in _game.Creatures)
                {
                    c.Query(this, q); // t
                }
                return q.Result;
            }
        }

        public override void Query(object source, StatQuery sq)
        {
            if (ReferenceEquals(source, this))
            {
                switch (sq.Statistic)
                {
                    case Statistic.Attack:
                        sq.Result += _baseAttack;
                        break;
                    case Statistic.Defense:
                        sq.Result += _baseDefense;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                if (sq.Statistic == Statistic.Defense)
                {
                    sq.Result++;
                }
            }
        }
    }

    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game) 
        {
            Attack = 3;
            Defense = 3;
        }

        public override void Query(object source, StatQuery sq)
        {
            if (!ReferenceEquals(source, this) && sq.Statistic == Statistic.Attack)
            {
                
                sq.Result++; // every goblin gets +1 attack
            }
            else base.Query(source, sq);
        }
    }

    public class Game
    {
        public IList<Creature> Creatures = new List<Creature>();
    }
}
