using System.Collections.Generic;
using Exiled.API.Interfaces;

namespace RPNamesPlus
{
    public class RoleNamePool
    {
        public string Prefix { get; set; } = "";
        public List<string> Names { get; set; } = new List<string>();
    }

    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public Dictionary<string, RoleNamePool> RPNamesPlus { get; set; } = new()
        {
            { "Scientist", new RoleNamePool { Prefix = "Dr. ", Names = new List<string>{
                "Smith", "Johnson", "Brown", "Taylor", "Anderson", "Clark", "Wright", "Harris"
            } } },

            { "FacilityGuard", new RoleNamePool { Prefix = "Guard ", Names = new List<string>{
                "John", "Mike", "David", "Alex", "Chris", "Tom", "James", "Robert"
            } } },

            { "NtfCaptain", new RoleNamePool { Prefix = "Captain ", Names = new List<string>{
                "Hawk", "Falcon", "Wolf", "Viper", "Ghost", "Eagle"
            } } },
            { "NtfPrivate", new RoleNamePool { Prefix = "Private ", Names = new List<string>{
                "Fox", "Bear", "Hawk", "Raven", "Wolf", "Tiger"
            } } },
            { "NtfSergeant", new RoleNamePool { Prefix = "Sergeant ", Names = new List<string>{
                "Blade", "Raptor", "Shadow", "Viper", "Falcon", "Reaper"
            } } },
            { "NtfSpecialist", new RoleNamePool { Prefix = "Specialist ", Names = new List<string>{
                "Ghost", "Sniper", "Scout", "Hawkeye", "Phantom", "Specter"
            } } },

            { "ChaosConscript", new RoleNamePool { Prefix = "Conscript ", Names = new List<string>{
                "Ivan", "Karl", "Nikolai", "Sergei", "Alexei", "Viktor"
            } } },
            { "ChaosMarauder", new RoleNamePool { Prefix = "Marauder ", Names = new List<string>{
                "Drago", "Lukas", "Rico", "Boris", "Milo"
            } } },
            { "ChaosRepressor", new RoleNamePool { Prefix = "Repressor ", Names = new List<string>{
                "Igor", "Otto", "Nico", "Boris", "Rashid"
            } } },
            { "ChaosRifleman", new RoleNamePool { Prefix = "Rifleman ", Names = new List<string>{
                "Alex", "Roman", "Pavel", "Dmitri", "Vlad"
            } } },

            { "Scp106", new RoleNamePool { Prefix = "SCP-106 ", Names = new List<string>{
                "The Elder", "The Crawler", "The Creeper"
            } } },
            { "Scp939", new RoleNamePool { Prefix = "SCP-939 ", Names = new List<string>{
                "The Predator", "Howler", "Shadow"
            } } },
            { "Scp049", new RoleNamePool { Prefix = "SCP-049 ", Names = new List<string>{
                "The Plague Doctor", "Chirurgeon", "Mortis"
            } } },
            { "Scp079", new RoleNamePool { Prefix = "SCP-079 ", Names = new List<string>{
                "AI-Unit", "Overseer", "Control"
            } } },
            { "Scp173", new RoleNamePool { Prefix = "SCP-173 ", Names = new List<string>{
                "The Statue", "Snapper", "Watcher"
            } } },
            { "Scp096", new RoleNamePool { Prefix = "SCP-096 ", Names = new List<string>{
                "Shy Guy", "The Screamer", "Silent One"
            } } },
            { "Scp3114", new RoleNamePool { Prefix = "SCP-3114 ", Names = new List<string>{
                "Mimic", "Replica", "Doppel"
            } } },
            { "Scp0492", new RoleNamePool { Prefix = "SCP-049-2 ", Names = new List<string>{
                "Zombie1", "Zombie2", "Infected"
            } } },
        };
    }
}
