﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Properties
{
    enum generationTypes
    {
        none,
        truthTableToGraphWithoutOptimization,
        truthTableToGraphWithOptimization
    }

    [Serializable]
    class Settings
    {
        /// <summary>
        /// Путь для сохранения настроек.
        /// </summary>
        private static string fileName = "settings.dat";
        /// <summary>
        /// Экземпляр настроек.
        /// </summary>
        private static Settings instance;

        public static int numThreads { get; private set; }
        
        /// <summary>
        /// Перечисляются используемые логические операции. Формат: {операция: (символ, уровень выполнения)}.
        /// </summary>
        public Dictionary<string, Tuple<string, int>> logicOperations;
        /// <summary>
        /// Соотносят операции и уровень выполнения. Формат: {операция: уровень выполнения}.
        /// </summary>
        public Dictionary<int, List<string>> operationsToHierarchy;
        /// <summary>
        /// Соотносят символ операции и ее обозначение. Формат: {символ: операция}.
        /// </summary>
        public Dictionary<string, string> operationsToName;

        enum generationTypes
        {
            none,
            truthTableToGraphWithoutOptimization,
            truthTableToGraphWithOptimization
        }


        /// <summary>
        /// Конструктор для инициализации настроек.
        /// </summary>
        private Settings()
        {
            numThreads = 4;

            logicOperations = new Dictionary<string, Tuple<string, int>>{
                { "input",  new Tuple<string, int>("",      4)},
                { "output", new Tuple<string, int>("=",     0)},
                { "const",  new Tuple<string, int>("",      4)},
                { "∧",    new Tuple<string, int>("∧",   2)},
                { "|",   new Tuple<string, int>("|",  2)},
                { "∨",     new Tuple<string, int>("∨",    1)},
                { "↓",    new Tuple<string, int>("↓",   1)},
                { "¬",    new Tuple<string, int>("¬",   3)},
                { "⊕",    new Tuple<string, int>("⊕",   2)}
               
            };

            operationsToHierarchy = new Dictionary<int, List<string>>();
            operationsToName = new Dictionary<string, string>();

            foreach (var item in logicOperations)
            {
                int i = item.Value.Item2;
                if (!operationsToHierarchy.ContainsKey(i))
                    operationsToHierarchy.Add(i, new List<string>());
                operationsToHierarchy[i].Add(item.Value.Item1);
                
            }

            foreach (var item in logicOperations)
            {
                if (operationsToName.ContainsKey(item.Value.Item1))
                {
                    continue;
                }
                else
                {
                    operationsToName.Add(item.Value.Item1, item.Key);
                }
                
               
            }
        }

        /// <summary>
        /// Метод, возвращающий экземпляр настроек.
        /// </summary>
        /// <returns>Возвращает экземпляр настроек.</returns>
        public static Settings GetInstance()
        {
            if (instance == null)
                instance = Settings.LoadSettings();
            return instance;
        }


        /// <summary>
        /// Метод загрузки настроек из файла. Происходит поптыка считывания настроек из файла. При неудаче создается базовый экземпляр настроек.
        /// </summary>
        /// <returns>Возвращает класс с настройками.</returns>
        public static Settings LoadSettings()
        {
            Settings settings = null;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    try
                    {
                        settings = (Settings)bf.Deserialize(fs);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"Exception Handler in LoadSettings: {ex}");
                        settings = new Settings();
                    }
                }
            }
            else
            {
                settings = new Settings();
            }

            return settings;
        }

        /// <summary>
        /// Метод сохранения настроек в файл.
        /// </summary>
        public void Save()
        {            
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                bf.Serialize(fs, this);
                fs.Close();
            }
        }

    }
}
