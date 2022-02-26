using System;
using System.Collections.Generic;
using System.Linq;

namespace T10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] cmd = input.Split(":");
                string command = cmd[0];
                string lesson = cmd[1];
                string lessonExercise = $"{lesson}-Exercise";
                if (command == "Add" && !schedule.Contains(lesson))
                {
                    schedule.Add(lesson);
                }
                else if (command == "Insert" && !schedule.Contains(lesson))
                {
                    schedule.Insert(int.Parse(cmd[2]), lesson);
                }
                else if (command == "Remove")
                {
                    schedule.Remove(lesson);
                    schedule.Remove(lessonExercise);
                }
                else if (command == "Swap")
                {
                    string lesson2 = cmd[2];
                    string lesson2Exercise = $"{lesson2}-Exercise";
                    if (schedule.Contains(lesson) && schedule.Contains(lesson2))
                    {
                        int lesson2Index = schedule.IndexOf(lesson2);
                        schedule[schedule.IndexOf(lesson)] = lesson2;
                        schedule[lesson2Index] = lesson;
                        if (schedule.Remove(lessonExercise))
                        {
                            schedule.Insert(schedule.IndexOf(lesson) + 1, lessonExercise);
                        }
                        if (schedule.Remove(lesson2Exercise))
                        {
                            schedule.Insert(schedule.IndexOf(lesson2) + 1, lesson2Exercise);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                        schedule.Add(lessonExercise);
                    }
                    else if (!schedule.Contains(lessonExercise))
                    {
                        schedule.Insert(schedule.IndexOf(lesson) + 1, lessonExercise);
                    }
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
