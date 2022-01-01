using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Chain_of_Responsability.Exercise
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
    //var game = new Game();
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
        protected int _baseAttack;
        protected int _baseDefense;

        protected Creature(Game game, int baseAttack, int baseDefense)
        {
            _game = game;
            _baseAttack = baseAttack;
            _baseDefense = baseDefense;
        }

        public virtual int Attack { get; set; }
        public virtual int Defense { get; set; }

        public abstract void PrepareStatistics(QueryStatistics qs, Creature creature);

        public override string ToString()
        {
            return $"{GetType().Name}'s Attack is {Attack} and Defense is {Defense}";
        }
    }

    public enum Statistics
    {
        Attack,
        Defense
    }

    public class QueryStatistics
    {
        public Statistics Statistics;
        public int Result;
    }

    public class Game
    {
        public IList<Creature> Creatures = new List<Creature>();
    }

    public class Goblin : Creature
    {
        public Goblin(Game game) : this(game, 1, 1)
        {

        }

        public Goblin(Game game, int baseAttack, int baseDefense) : base(game, baseAttack, baseDefense)
        {

        }

        public override int Attack 
        {
            get 
            {
                var queryStats = new QueryStatistics { Statistics = Statistics.Attack };
                foreach (var creature in _game.Creatures)
                {
                    creature.PrepareStatistics(queryStats, this);
                }

                return queryStats.Result;
            }
        }
        public override int Defense 
        { 
            get
            {
                var queryStats = new QueryStatistics { Statistics = Statistics.Defense };
                foreach (var creature in _game.Creatures)
                {
                    creature.PrepareStatistics(queryStats, this);
                }

                return queryStats.Result;
            }
        }

        public override void PrepareStatistics(QueryStatistics qs, Creature creature)
        {
            if (ReferenceEquals(creature, this))
            {
                qs.Result += qs.Statistics switch
                {
                    Statistics.Attack => _baseAttack,
                    Statistics.Defense => _baseDefense,
                    _ => throw new ArgumentOutOfRangeException(),
                };
            }
            else
            {
                if (qs.Statistics == Statistics.Defense)
                {
                    qs.Result++;
                }
            }

        }
    }

    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game, 2, 2)
        {
        }

        public override void PrepareStatistics(QueryStatistics qs, Creature creature)
        {
            if (!ReferenceEquals(creature, this) && qs.Statistics == Statistics.Attack)
            {
                qs.Result++;
            }
            else
            {
                base.PrepareStatistics(qs, creature);
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}'s Attack is {Attack} and Defense is {Defense}";
        }
    }
}
