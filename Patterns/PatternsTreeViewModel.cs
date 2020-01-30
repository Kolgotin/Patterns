using System;
using System.Collections.ObjectModel;

namespace Patterns
{
    class PatternsTreeViewModel
    {
        public int WindowWidth { get; set; } = 1500;
        public int PatternWidth => WindowWidth * 4 / 5;
        public string HeaderLabel => "Паттерны";
        public ObservableCollection<KindsModel> Kinds { get; set; }

        public PatternsTreeViewModel()
        {
            PatternsFilling();
        }

        private void PatternsFilling()
        {
            Kinds = new ObservableCollection<KindsModel>
            {
                new KindsModel
                {
                    KindName = "Порождающие",
                    PatternsTree = new ObservableCollection<PatternsModel>
                    {
                        new PatternsModel
                        {
                            Name = "Фабричный метод",
                            Description = "Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс " +
                            "для создания объектов некоторого класса, но непосредственное решение о том, объект какого класса " +
                            "создавать происходит в подклассах. То есть паттерн предполагает, что базовый класс делегирует " +
                            "создание объектов классам-наследникам",
                            Reference = "https://metanit.com/sharp/patterns/2.1.php",
                            CodeExampleFilePath = @"factorymethod",
                            ImageSource = @"Images\factorymethod.png"
                        },
                        new PatternsModel
                        {
                            Name = "Абстрактная фабрика",
                            Description = "Паттерн \"Абстрактная фабрика\" (Abstract Factory) предоставляет интерфейс для " +
                            "создания семейств взаимосвязанных объектов с определенными интерфейсами без указания конкретных " +
                            "типов данных объектов",
                            Reference = "https://metanit.com/sharp/patterns/2.2.php",
                            CodeExampleFilePath = @"abstractfactory",
                            ImageSource = @"Images\abstractfactory.png"
                        },
                        new PatternsModel
                        {
                            Name = "Одиночка",
                            Description = "Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, что " +
                            "для определенного класса будет создан только один объект, а также предоставит к этому объекту " +
                            "точку доступа.",
                            Reference = "https://metanit.com/sharp/patterns/2.3.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Прототип",
                            Description = "Паттерн Прототип (Prototype) позволяет создавать объекты на основе уже ранее " +
                            "созданных объектов-прототипов. То есть по сути данный паттерн предлагает технику клонирования объектов.",
                            Reference = "https://metanit.com/sharp/patterns/2.4.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Строитель",
                            Description = "Строитель (Builder) - шаблон проектирования, который инкапсулирует создание " +
                            "объекта и позволяет разделить его на различные этапы.",
                            Reference = "https://metanit.com/sharp/patterns/2.5.php",
                            CodeExampleFilePath = @""
                        }
                    }
                },
                new KindsModel
                {
                    KindName = "Структурные",
                    PatternsTree = new ObservableCollection<PatternsModel>
                    {
                        new PatternsModel
                        {
                            Name = "Декоратор",
                            Description = "Декоратор (Decorator) представляет структурный шаблон проектирования, " +
                            "который позволяет динамически подключать к объекту дополнительную функциональность.",
                            Reference = "https://metanit.com/sharp/patterns/4.1.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Адаптер",
                            Description = "Паттерн Адаптер (Adapter) предназначен для преобразования интерфейса " +
                            "одного класса в интерфейс другого. Благодаря реализации данного паттерна мы можем " +
                            "использовать вместе классы с несовместимыми интерфейсами.",
                            Reference = "https://metanit.com/sharp/patterns/4.2.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Фасад",
                            Description = "Фасад (Facade) представляет шаблон проектирования, который позволяет скрыть " +
                            "сложность системы с помощью предоставления упрощенного интерфейса для взаимодействия с ней",
                            Reference = "https://metanit.com/sharp/patterns/4.3.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Компоновщик",
                            Description = "Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную " +
                            "структуру по принципу часть-целое и позволяет клиенту одинаково работать как с отдельными " +
                            "объектами, так и с группой объектов.",
                            Reference = "https://metanit.com/sharp/patterns/4.4.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Заместитель",
                            Description = "Паттерн Заместитель (Proxy) предоставляет объект-заместитель, который " +
                            "управляет доступом к другому объекту. То есть создается объект-суррогат, который может " +
                            "выступать в роли другого объекта и замещать его.",
                            Reference = "https://metanit.com/sharp/patterns/4.5.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Мост",
                            Description = "Мост (Bridge) - структурный шаблон проектирования, который позволяет " +
                            "отделить абстракцию от реализации таким образом, чтобы и абстракцию, и реализацию " +
                            "можно было изменять независимо друг от друга.",
                            Reference = "https://metanit.com/sharp/patterns/4.6.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Легковес / Приспособленец",
                            Description = "Паттерн Приспособленец (Flyweight) - структурный шаблон проектирования, " +
                            "который позволяет использовать разделяемые объекты сразу в нескольких контекстах. " +
                            "Данный паттерн используется преимущественно для оптимизации работы с памятью.",
                            Reference = "https://metanit.com/sharp/patterns/4.7.php",
                            CodeExampleFilePath = @""
                        }
                    }
                },
                new KindsModel
                {
                    KindName = "Поведенческие",
                    PatternsTree = new ObservableCollection<PatternsModel>
                    {
                        new PatternsModel
                        {
                            Name = "Стратегия",
                            Description = "Паттерн Стратегия (Strategy) представляет шаблон проектирования, который определяет " +
                            "набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость. В зависимости " +
                            "от ситуации мы можем легко заменить один используемый алгоритм другим. При этом замена алгоритма " +
                            "происходит независимо от объекта, который использует данный алгоритм.",
                            Reference = "https://metanit.com/sharp/patterns/3.1.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Наблюдатель",
                            Description = "Паттерн \"Наблюдатель\" (Observer) представляет поведенческий шаблон проектирования, " +
                            "который использует отношение \"один ко многим\". В этом отношении есть один наблюдаемый объект и " +
                            "множество наблюдателей. И при изменении наблюдаемого объекта автоматически происходит оповещение " +
                            "всех наблюдателей",
                            Reference = "https://metanit.com/sharp/patterns/3.2.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Команда",
                            Description = "Паттерн \"Команда\" (Command) позволяет инкапсулировать запрос на выполнение определенного " +
                            "действия в виде отдельного объекта. Этот объект запроса на действие и называется командой. При этом " +
                            "объекты, инициирующие запросы на выполнение действия, отделяются от объектов, которые выполняют это действие",
                            Reference = "https://metanit.com/sharp/patterns/3.3.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Шаблонный метод",
                            Description = "Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, " +
                            "позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.",
                            Reference = "https://metanit.com/sharp/patterns/3.4.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Итератор",
                            Description = "Паттерн Итератор (Iterator) предоставляет абстрактный интерфейс для последовательного " +
                            "доступа ко всем элементам составного объекта без раскрытия его внутренней структуры",
                            Reference = "https://metanit.com/sharp/patterns/3.5.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Состояние",
                            Description = "Состояние (State) - шаблон проектирования, который позволяет объекту " +
                            "изменять свое поведение в зависимости от внутреннего состояния.",
                            Reference = "https://metanit.com/sharp/patterns/3.6.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Цепочка обязанностей",
                            Description = "Цепочка Обязанностей (Chain of responsibility) - поведенческий шаблон проектирования, " +
                            "который позволяет избежать жесткой привязки отправителя запроса к получателю, позволяя нескольким объектам " +
                            "обработать запрос. Все возможные обработчики запроса образуют цепочку, а сам запрос перемещается по этой " +
                            "цепочке, пока один из ее объектов не обработает запрос. Каждый объект при получении запроса выбирает, либо " +
                            "обработать запрос, либо передать выполнение запроса следующему по цепочке",
                            Reference = "https://metanit.com/sharp/patterns/3.7.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Интерпретатор",
                            Description = "Паттерн Интерпретатор (Interpreter) определяет представление грамматики " +
                            "для заданного языка и интерпретатор предложений этого языка. Как правило, данный " +
                            "шаблон проектирования применяется для часто повторяющихся операций",
                            Reference = "https://metanit.com/sharp/patterns/3.8.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Посредник",
                            Description = "Паттерн Посредник (Mediator) представляет такой шаблон проектирования, " +
                            "который обеспечивает взаимодействие множества объектов без необходимости ссылаться друг " +
                            "на друга. Тем самым достигается слабосвязанность взаимодействующих объектов",
                            Reference = "https://metanit.com/sharp/patterns/3.9.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Снимок / Хранитель",
                            Description = "Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта за его " +
                            "пределы для последующего возможного восстановления объекта без нарушения принципа инкапсуляции",
                            Reference = "https://metanit.com/sharp/patterns/3.10.php",
                            CodeExampleFilePath = @""
                        },
                        new PatternsModel
                        {
                            Name = "Посетитель",
                            Description = "Паттерн Посетитель (Visitor) позволяет определить " +
                            "операцию для объектов других классов без изменения этих классов.",
                            Reference = "https://metanit.com/sharp/patterns/3.11.php",
                            CodeExampleFilePath = @""
                        },
                    }
                }
            };
        }
    }
}
