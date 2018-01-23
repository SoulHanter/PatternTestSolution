using PatternsExample.Examples.Abstract_Factory;
using PatternsExample.Examples.Adapter;
using PatternsExample.Examples.Decorator;
using PatternsExample.Examples.DI;
using PatternsExample.Examples.Mediator;
using PatternsExample.Examples.Observer;
using PatternsExample.Shared.Extensions;
using PatternsExample.Shared.Models;
using PatternsExample.SingletonExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatternsExample.TestSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Паттерн Singleton
            TestSingleton();

            //Паттерн Наблюдатель
            //TestObserver();

            //Паттерн Медиатор
            //TestMeduator();

            //Dependency Injection
            //TestDI();

            //Паттерн Адаптер
            //TestAdapter();

            //Паттерн Декоратор
            //TestDecorator();

            //Абстрактная фабрика
            //TestAbstractFactory();

            Console.ReadKey();
        }

        private static void TestSingleton()
        {
            var state = Singleton.GetInstance;
            var stateTo = Singleton.GetInstance;

            Console.WriteLine(state.State.GetDescription());

            state.SetState(State.Info);

            Console.WriteLine(stateTo.State.GetDescription());
        }

        private static void TestObserver()
        {
            var temp = new Thermometer();
            var fun = new Fan(temp);
            var heater = new Heater(temp);

            temp.UpTemp(new Temperature(-3));
            Console.WriteLine("-------------------");

            temp.UpTemp(new Temperature(30));
            Console.WriteLine("-------------------");

            heater.OnCompleted();

            temp.UpTemp(new Temperature(15));
            Console.WriteLine("-------------------");
        }

        private static void TestMeduator()
        {
            var messanger = new Messanger();
            var shop = new Shop(messanger);
            var stock = new Stock(messanger);
            var code = shop.AddBook("Приключение чиполлино");
            var newBook = shop.GetBook(code);

            Console.WriteLine($"Книга \"{newBook.Name}\" - количество:{newBook.Count}");

            stock.Trace(code, 15);

            Console.WriteLine($"Книга \"{newBook.Name}\" - количество:{newBook.Count}");
        }

        private static void TestDI()
        {
            var reader = new ReaderDocument();
            var wReader = new WordReader();
            var exReader = new ExcelReader();

            reader.CreateDocument(wReader, "Документ 1");
            reader.CreateDocument(exReader, "Документ 2");
        }

        private static void TestAdapter()
        {
            var builder = new BuildingCompany();
            var shed = new Shed { Heigth = 2, Width = 2 };
            var house = new House { Heigth = 7, Width = 10 };
            var adapter = new ShedToHouseAdapter(shed);

            builder.Building(house);

            builder.Building(adapter);
        }

        private static void TestDecorator()
        {
            var page = new Page();
            var pageDecorator = new PageDecorator(page);
            var acticle = page.Publish("Новая статья", "Здесь должно что то быть");

            pageDecorator.Delete(acticle);
        }

        private static void TestAbstractFactory()
        {
            var apartment = new Build(new Apartment());
            Console.WriteLine("Тип дома: Квартира");
            apartment.GetBalconyType();
            apartment.GetGlassType();


            Console.WriteLine("-------------------");


            var cottage = new Build(new Cottage());
            Console.WriteLine("Тип дома: Котедж");
            cottage.GetBalconyType();
            cottage.GetGlassType();
        }
    }
}
