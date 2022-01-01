using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Adapter
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving a file");
        }
    }

    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opening a file");
        }
    }

    public class Button
    {
        private ICommand _command;
        private string _name;

        public Button(ICommand command, string name)
        {
            _command = command;
            _name = name;
        }

        public void Click()
        {
            _command.Execute();
        }

        public void PrintMe()
        {
            Console.WriteLine($"I am a button called {_name}");
        }
    }

    public class Editor
    {
        private readonly IEnumerable<Button> _buttons;

        public Editor(IEnumerable<Button> buttons)
        {
            _buttons = buttons;
        }

        public IEnumerable<Button> Buttons 
        {
            get { return _buttons; } 
        }

        public void ClickAll()
        {
            foreach (var btn in _buttons)
            {
                btn.Click();
            }
        }
    }
}
