\# Перечень артефактов проекта Lab3-Lein



\## Исходный код

\- src/ConsoleApp/Program.cs — основной файл управления программой

\- src/ConsoleApp/Modules/InputModule.cs — модуль ввода данных

\- src/ConsoleApp/Modules/ValidationModule.cs — модуль проверки данных

\- src/ConsoleApp/Modules/ProcessingModule.cs — модуль обработки (НОД)



\## Вспомогательные файлы

\- README.md — описание проекта и инструкция запуска

\- .gitignore — исключения Git



\## Диаграммы

\- UML-диаграмма модулей (создана в ЛР №2)



\## Тестирование

\- Ручное тестирование через консоль (ввод чисел и проверка НОД)

## Анализ модулей и зависимостей



\### Взаимодействие модулей



1\. Program вызывает InputModule.ReadInt() для ввода чисел

2\. Данные передаются в ValidationModule.IsValid() для проверки

3\. После проверки данные передаются в ProcessingModule.FindGCD() для вычисления НОД



\### Таблица зависимостей



| Модуль        | Вызываемый метод                     | Назначение                |

|--------------|-------------------------------------|---------------------------|

| Program.cs   | InputModule.ReadInt()               | Ввод данных               |

| Program.cs   | ValidationModule.IsValid()          | Проверка данных           |

| Program.cs   | ProcessingModule.FindGCD()          | Вычисление НОД            |



\### Передаваемые данные



\- Из InputModule → числа a, b

\- В ValidationModule → a, b

\- В ProcessingModule → a, b

