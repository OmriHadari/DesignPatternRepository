using System;
using System.Collections.Generic;

namespace Flyweight
{
    // This pattern is better suited for optimization
    // (Specifically, to reduce the number of instances in a multi-object envairoment)

    // Caching the objects, then controlling their state.
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public class Icon
        {
            public Icon(string path)
            {
                // Load icon
            }
        }

        static class IconProvider
        {
            private static Dictionary<string, Icon> _cache = new Dictionary<string, Icon>();

            public static Icon GetIcon(string type)
            {
                if (!_cache.ContainsKey(type))
                    _cache[type] = new Icon(type);

                return _cache[type];
            }
        }

        public abstract class Button
        {
            public Icon Icon { get; set; }
        }

        public class SettingsButton : Button
        {
            public SettingsButton()
            {
                Icon = IconProvider.GetIcon("settings");
            }
        }


        // These classes are reusing the same icon, instead of instantiating new iconObjects.
        public class SolutionWindow
        {
            SettingsButton settings = new SettingsButton();
        }

        public class TerminalWindow
        {
            SettingsButton settings = new SettingsButton();
        }

        public class TestRunnerWindow
        {
            SettingsButton settings = new SettingsButton();
        }
    }
}
