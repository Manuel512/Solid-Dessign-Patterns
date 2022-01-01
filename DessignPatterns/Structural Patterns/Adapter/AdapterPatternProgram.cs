using Autofac;
using Autofac.Features.Metadata;
using DessignPatterns.Structural_Patterns.Generic_Value_Adapter;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Structural_Patterns.Adapter
{
    public class AdapterPatternProgram
    {
        private static readonly List<VectorObject> vectorObjects
             = new List<VectorObject>
             {
                 new VectorRectangule(1, 1, 10, 10),
                 new VectorRectangule(3, 3, 6, 6)
             };

        private static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        private static void Draw()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }

        public static void RunVectorRaster()
        {
            Draw();
            Draw();
            //foreach (var vo in vectorObjects)
            //{
            //    foreach (var line in vo)
            //    {
            //        var adapter = new LineToPointAdapter(line);
            //        adapter.ForEach(DrawPoint);
            //    }
            //}
        }

        public static void RunGenericValueAdapater()
        {
            var v = new Vector2i(1, 2);
            v[0] = 0;

            var vv = new Vector2i(3, 2);

            var result = v + vv;

            Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
        }

        public static void RunAdapterInDI()
        {
            var b = new ContainerBuilder();
            b.RegisterType<SaveCommand>().As<ICommand>()
                .WithMetadata("Name", "Save");
            b.RegisterType<OpenCommand>().As<ICommand>()
                .WithMetadata("Name", "Open");
            //b.RegisterType<Button>();

            //this call multiples instances to satisfy the IEnumerable from editor
            //b.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));

            b.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
                new Button(cmd.Value, (string)cmd.Metadata["Name"])
            );
            b.RegisterType<Editor>();

            using (var c = b.Build())
            {
                var editor = c.Resolve<Editor>();
                //editor.ClickAll();

                foreach (var btn in editor.Buttons)
                {
                    btn.PrintMe();
                }
            }
        }
    }
}
