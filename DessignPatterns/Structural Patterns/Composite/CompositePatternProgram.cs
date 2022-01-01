using DessignPatterns.Structural_Patterns.Composite.Geometric_Shapes;
using DessignPatterns.Structural_Patterns.Composite.Neural_Networks;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Composite
{
    public class CompositePatternProgram
    {
        public static void RunGeometricShapes()
        {
            var drawing = new GraphicObject { Name = "My Drawing" };
            drawing.Children.Add(new Square { Color = "Red" });
            drawing.Children.Add(new Circle { Color = "Yellow" });

            var group = new GraphicObject();
            group.Children.Add(new Square { Color = "Blue" });
            group.Children.Add(new Circle { Color = "Blue" });

            var group2 = new GraphicObject();
            group2.Children.Add(new Square { Color = "Blue" });
            group2.Children.Add(new Circle { Color = "Blue" });
            group.Children.Add(group2);
            
            drawing.Children.Add(group);

            Console.WriteLine(drawing);
        }

        public static void RunNeuronalNetworks()
        {
            var neuron1 = new Neuron();
            var neuron2 = new Neuron();

            neuron1.ConnectTo(neuron2);

            var layer1 = new NeuronLayer();
            var layer2 = new NeuronLayer();

            neuron1.ConnectTo(layer1);
            layer1.ConnectTo(layer2);
        }
    }
}
