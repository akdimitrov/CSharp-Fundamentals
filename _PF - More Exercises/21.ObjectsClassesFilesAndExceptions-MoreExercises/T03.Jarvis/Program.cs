using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace T03.Jarvis
{
    class Arm
    {
        public Arm(long energy, long reach, long fingers)
        {
            EnergyConsumption = energy;
            ReachDistance = reach;
            FingersCount = fingers;
        }
        public long EnergyConsumption { get; set; }

        public long ReachDistance { get; set; }

        public long FingersCount { get; set; }

        public override string ToString()
        {
            return $"#Arm:\n###Energy consumption: {EnergyConsumption}\n###Reach: {ReachDistance}\n###Fingers: {FingersCount}";
        }
    }

    class Leg
    {
        public Leg(long energy, long strength, long speed)
        {
            EnergyConsumption = energy;
            Strength = strength;
            Speed = speed;
        }
        public long EnergyConsumption { get; set; }

        public long Strength { get; set; }

        public long Speed { get; set; }

        public override string ToString()
        {
            return $"#Leg:\n###Energy consumption: {EnergyConsumption}\n###Strength: {Strength}\n###Speed: {Speed}";
        }
    }

    class Torso
    {
        public Torso(long energy, double size, string material)
        {
            EnergyConsumption = energy;
            ProcessorSizeCm = size;
            HousingMaterial = material;
        }
        public long EnergyConsumption { get; set; }

        public double ProcessorSizeCm { get; set; }

        public string HousingMaterial { get; set; }

        public override string ToString()
        {
            return $"#Torso:\n###Energy consumption: {EnergyConsumption}\n###Processor size: {ProcessorSizeCm:f1}\n###Corpus material: {HousingMaterial}";
        }
    }

    class Head
    {
        public Head(long energy, long iq, string skinMaterial)
        {
            EnergyConsumption = energy;
            IQ = iq;
            SkinMaterial = skinMaterial;
        }
        public long EnergyConsumption { get; set; }

        public long IQ { get; set; }

        public string SkinMaterial { get; set; }

        public override string ToString()
        {
            return $"#Head:\n###Energy consumption: {EnergyConsumption}\n###IQ: {IQ}\n###Skin material: {SkinMaterial}";
        }
    }

    class Robot
    {
        public Robot()
        {
            Head = null;
            Torso = null;
            Arms = new List<Arm>();
            Legs = new List<Leg>();
        }
        public Head Head { get; set; }

        public List<Arm> Arms { get; set; }

        public Torso Torso { get; set; }

        public List<Leg> Legs { get; set; }

        public override string ToString()
        {
            Arms = Arms.OrderBy(x => x.EnergyConsumption).ToList();
            Legs = Legs.OrderBy(x => x.EnergyConsumption).ToList();
            return $"Jarvis:\n{Head}\n{Torso}\n{String.Join("\n", Arms)}\n{String.Join("\n", Legs)}";
        }

        public bool IsEnergyEficcient(BigInteger maxEnergy)
        {
            BigInteger totalEnergy = Head.EnergyConsumption + Torso.EnergyConsumption + Arms.Sum(x => x.EnergyConsumption) + Legs.Sum(x => x.EnergyConsumption);
            if (totalEnergy <= maxEnergy)
            {
                return true;
            }
            return false;
        }

        public bool IsComplete()
        {
            if (Head != null && Torso != null && Arms.Count == 2 && Legs.Count == 2)
            {
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Robot jarvis = new Robot();
            BigInteger maxEnergyCapacitiy = BigInteger.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Assemble!")
            {
                string[] array = command.Split();
                string componentType = array[0].ToLower();
                long energyConsumption = long.Parse(array[1]);
                if (componentType == "arm")
                {
                    long reachDistance = long.Parse(array[2]);
                    long fingers = long.Parse(array[3]);
                    Arm arm = new Arm(energyConsumption, reachDistance, fingers);
                    if (jarvis.Arms.Count > 1)
                    {
                        if (jarvis.Arms.Any(x => x.EnergyConsumption > energyConsumption))
                        {
                            if (jarvis.Arms[0].EnergyConsumption > energyConsumption && jarvis.Arms[1].EnergyConsumption > energyConsumption)
                            {
                                jarvis.Arms.RemoveAt(0);
                                jarvis.Arms.Add(arm);
                            }
                            else if (jarvis.Arms[1].EnergyConsumption > energyConsumption)
                            {
                                jarvis.Arms[1] = arm;
                            }
                            else
                            {
                                jarvis.Arms[0] = arm;
                            }
                        }
                    }
                    else
                    {
                        jarvis.Arms.Add(arm);
                    }
                }
                else if (componentType == "leg")
                {
                    long strength = long.Parse(array[2]);
                    long speed = long.Parse(array[3]);
                    Leg leg = new Leg(energyConsumption, strength, speed);
                    if (jarvis.Legs.Count > 1)
                    {
                        if (jarvis.Legs.Any(x => x.EnergyConsumption > energyConsumption))
                        {
                            if (jarvis.Legs[0].EnergyConsumption > energyConsumption && jarvis.Legs[1].EnergyConsumption > energyConsumption)
                            {
                                jarvis.Legs.RemoveAt(0);
                                jarvis.Legs.Add(leg);
                            }
                            else if (jarvis.Legs[1].EnergyConsumption > energyConsumption)
                            {
                                jarvis.Legs[1] = leg;
                            }
                            else
                            {
                                jarvis.Legs[0] = leg;
                            }
                        }
                    }
                    else
                    {
                        jarvis.Legs.Add(leg);
                    }
                }
                else if (componentType == "torso")
                {
                    double proccessorSize = double.Parse(array[2]);
                    string housingMaterial = array[3];
                    Torso torso = new Torso(energyConsumption, proccessorSize, housingMaterial);
                    if (jarvis.Torso != null)
                    {
                        if (jarvis.Torso.EnergyConsumption > energyConsumption)
                        {
                            jarvis.Torso = torso;
                        }
                    }
                    else
                    {
                        jarvis.Torso = torso;
                    }
                }
                else if (componentType == "head")
                {
                    long iq = long.Parse(array[2]);
                    string skinMaterial = array[3];
                    Head head = new Head(energyConsumption, iq, skinMaterial);
                    if (jarvis.Head != null)
                    {
                        if (jarvis.Head.EnergyConsumption > energyConsumption)
                        {
                            jarvis.Head = head;
                        }
                    }
                    else
                    {
                        jarvis.Head = head;
                    }
                }

                command = Console.ReadLine();
            }

            if (jarvis.IsComplete())
            {
                if (jarvis.IsEnergyEficcient(maxEnergyCapacitiy))
                {
                    Console.WriteLine(jarvis);
                }
                else
                {
                    Console.WriteLine($"We need more power!");
                }
            }
            else
            {
                Console.WriteLine($"We need more parts!");
            }
        }
    }
}
