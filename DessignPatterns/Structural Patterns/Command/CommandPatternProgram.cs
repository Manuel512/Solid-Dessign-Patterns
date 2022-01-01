using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CC = DessignPatterns.Structural_Patterns.CompositeCommand;

namespace DessignPatterns.Structural_Patterns.Command
{
    public class CommandPatternProgram
    {
        public static void Run()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100),
                //new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 50),
                new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 1000),
            };

            Console.WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            Console.WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            Console.WriteLine(ba);
        }

        public static void RunCompositeCommand()
        {
            //var ba = new CC.BankAccount();
            //var deposit = new CC.BankAccountCommand(ba, CC.BankAccountCommand.Action.Deposit, 100);
            //var withdraw = new CC.BankAccountCommand(ba, CC.BankAccountCommand.Action.Withdraw, 50);

            //var composite = new CC.CompositeBankAccountCommand(
            //    new[] { deposit, withdraw });

            //composite.Call();
            //Console.WriteLine(ba);

            //composite.Undo();
            //Console.WriteLine(ba);

            var from = new CC.BankAccount();
            from.Deposit(100);
            var to = new CC.BankAccount();

            var mtc = new CC.MoneyTransferCommand(from, to, 1000);
            mtc.Call();

            Console.WriteLine(from);
            Console.WriteLine(to);

            mtc.Undo();
            Console.WriteLine(from);
            Console.WriteLine(to);
        }

        public static void RunExerciste()
        {
            var a = new Account();
            var command = new Command { Amount = 100, TheAction = Command.Action.Deposit };
            a.Process(command);

            command = new Command { Amount = 50, TheAction = Command.Action.Withdraw };
            a.Process(command);
        }
    }
}
