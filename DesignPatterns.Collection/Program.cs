using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DesignPatterns
{
    class Program
    {
        public static void Main()
        {
            LoadPatternOptions();
        }

        /// <summary>
        /// Options menu
        /// </summary>
        public static void LoadPatternOptions()
        {
            Console.WriteLine("\tChoose an option:");
            Console.WriteLine("\t---------------------------\n");

            var patternList = LoadJson();
            IEnumerable<IGrouping<string, Pattern>> patternGroups = patternList.GroupBy(x => x.Category);
            Dictionary<int, Pattern> groupedPatterns = new Dictionary<int, Pattern>();

            var index = 0;
            foreach (var group in patternGroups)
            {
                string groupKey = group.Key;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t" + groupKey + " Patterns\n");

                foreach (var key in group)
                {
                    ++index;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t" + index + ") " + key.Title);
                    groupedPatterns.Add(index, key);
                }

                Console.WriteLine("\n");
            }

            int choice = int.Parse(Console.ReadLine().ToString());
            if (groupedPatterns.ContainsKey(choice))
            {
                var pattern = groupedPatterns[choice];
                Console.Clear();
                InstanceAndInvoke(pattern);
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }

        /// <summary>
        /// Loads a list of patterns from json file
        /// </summary>
        /// <returns></returns>
        private static List<Pattern> LoadJson()
        {            
            using (StreamReader r = new StreamReader("../../../patterns.json"))
            {
                string json = r.ReadToEnd();
                List<Pattern> patterns = JsonConvert.DeserializeObject<List<Pattern>>(json);
                return patterns; 
            }
        }

        /// <summary>
        /// Instance the chosen pattern and invoke Execute
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private static object InstanceAndInvoke(Pattern pattern)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().First(t => t.Name == pattern.ClassName + "Test");
            object instance =  Activator.CreateInstance(type);

            Console.WriteLine(pattern.Description);
            Console.ForegroundColor = ConsoleColor.White;
            MethodInfo method = type.GetMethod("Execute");
            return method.Invoke(instance, null);
        }        
    }
}
