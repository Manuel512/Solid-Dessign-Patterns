using DessignPatterns.Builder_Pattern;
using DessignPatterns.Factory_Pattern;
using DessignPatterns.Prototype_Pattern;
using DessignPatterns.Singleton_Pattern;
using DessignPatterns.Solid_Principles;
using DessignPatterns.Solid_Principles.DependencyInversion;
using DessignPatterns.Solid_Principles.InterfaceSegregation;
using DessignPatterns.Structural_Patterns.Adapter;
using DessignPatterns.Structural_Patterns.Bridge;
using DessignPatterns.Structural_Patterns.Chain_of_Responsability;
using DessignPatterns.Structural_Patterns.Command;
using DessignPatterns.Structural_Patterns.Composite;
using DessignPatterns.Structural_Patterns.Decorator;
using DessignPatterns.Structural_Patterns.Facade;
using DessignPatterns.Structural_Patterns.FlyWeight;
using DessignPatterns.Structural_Patterns.Interpreter;
using DessignPatterns.Structural_Patterns.Proxy;
using System;

namespace DessignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns

            #region Solid Principles

            //Single Responsability
            //SingleResponsabilityPrincipleProgram.Run();

            //Open-Closed Principle
            //OpenClosedPrincipalProgram.Run();

            //Liskov Substitution Principle
            //LiskovSubstitutionPrincipleProgram.Run();

            //Interface Segregation
            //InterfaceSegregationPrincipleProgram.Run();

            //Dependency Inversion
            //DependencyInversionPrincipleProgram.Run();

            #endregion

            #region Builder Pattern
            //BuilderPatternProgram.RunLifeWithouBuilder();
            //BuilderPatternProgram.RunBuilder();
            //BuilderPatternProgram.RunFluentBuilderWithInheritance();
            //BuilderPatternProgram.RunFunctionalBuilder();

            // Best Approach
            //BuilderPatternProgram.RunFacetedBuilder();

            //Exercise
            //BuilderPatternProgram.RunExercise();
            #endregion

            #region Factory Pattern
            //Factory Method Example Point
            //FactoryPatternProgram.RunExamplePoint();

            //Asynchronous Factory Method
            //FactoryPatternProgram.AsynchronousFactoryMethodRun();

            //Abstract Factory
            //FactoryPatternProgram.AbstractFactoryRun();

            //Exercise
            //FactoryPatternProgram.ExerciseRun();
            #endregion

            #region Prototype Pattern
            //IClonable is Bad
            //IClonable is not good for Prototype Pattern
            //PrototypePatternProgram.RunIClonableIsBad();

            //Copy Constructor
            //PrototypePatternProgram.RunCopyConstructors();

            //Explicit Deep Copy Interface
            //PrototypePatternProgram.RunExplicitDeepCopyInterface();

            //Copy Through Serialization
            //PrototypePatternProgram.RunCopyThroughSerialization();

            //Exercise
            //PrototypePatternProgram.RunExercise();
            #endregion

            #region Singleton Pattern
            //Singleton Implementation
            //SingletonPatternProgram.RunSingletonImplementation();

            //Monostate
            //SingletonPatternProgram.RunMonostate();

            //Per-Thread Singleton
            //SingletonPatternProgram.RunPerThreadSingleton();

            //Ambient Context
            //SingletonPatternProgram.RunAmbientContext();
            #endregion

            #endregion

            #region Structural Patterns

            #region Adapter
            //Vector/Raster
            //AdapterPatternProgram.RunVectorRaster();

            //Adapter DI
            //AdapterPatternProgram.RunAdapterInDI();
            #endregion

            #region Bridge
            //BridgePatternProgram.Run();
            //BridgePatternProgram.RunWithDI();
            #endregion

            #region Composite
            //CompositePatternProgram.RunGeometricShapes();
            //BridgePatternProgram.RunWithDI();
            #endregion

            #region Decorators
            //Custom String builder
            //DecoratorPatternProgram.RunCustomStringBuilder();

            //Adapter-Decorator
            //DecoratorPatternProgram.RunAdapterDecorator();

            //Multiple Inheritance with interfaces
            //DecoratorPatternProgram.RunMultipleInheritanceWithInterfaces();

            // Very Intrusive
            //Multiple Inheritance with default interfaces members
            //DecoratorPatternProgram.RunMultipleInheritanceWithDefaultInterfaceMembers();

            // Dynamic Decorator
            //DecoratorPatternProgram.RunDynamicDecoratorComposition();

            //Not good enough in c#, don't use it
            // Static Decorator
            //DecoratorPatternProgram.RunStaticDecoratorComposition();

            //Decorator in Dependency Injection
            //DecoratorPatternProgram.RunDecoratorDI();
            #endregion

            #region Facade
            //FacadePatternProgram.Run();
            #endregion

            #region FlyWeight
            //FlyWeightPatternProgram.Run();
            //FlyWeightPatternProgram.RunTextFormatting();

            //FlyWeightPatternProgram.RunExercise();
            #endregion

            #region Proxy
            //Protection Proxy
            //ProxyPatternProgram.RunProtectionProxy();

            //Property Proxy
            //ProxyPatternProgram.RunPropertyProxy();

            //Value Proxy
            //ProxyPatternProgram.RunValueProxy();

            //Composite Proxy SoA/AoS
            //ProxyPatternProgram.RunCompositeProxy();
            #endregion

            #region Chain of Responsability
            //ChainOfResponsabilityPatternProgram.RunMethodChain();
            //ChainOfResponsabilityPatternProgram.RunBrokerChain();
            //ChainOfResponsabilityPatternProgram.RunExercise();
            #endregion

            #region Command
            //CommandPatternProgram.Run();
            //CommandPatternProgram.RunCompositeCommand();
            #endregion

            #region Interpreter
            //InterpreterPatternProgram.Run();
            InterpreterPatternProgram.RunExercise();
            #endregion

            #endregion
        }
    }
}
