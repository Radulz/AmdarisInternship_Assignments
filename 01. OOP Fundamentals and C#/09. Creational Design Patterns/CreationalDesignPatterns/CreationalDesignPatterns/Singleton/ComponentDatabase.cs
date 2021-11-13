using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class ComponentDatabase
    {
        private static List<Component> components;

        private static ComponentDatabase database;

        private static readonly object padlock = new object();

        private ComponentDatabase()
        {
            components = new List<Component>();
        }

        public static ComponentDatabase Database
        {
            get
            {
                if (database is null)
                {
                    lock (padlock)
                    {
                        if (database is null)
                        {
                            database = new ComponentDatabase();
                        }
                    }
                }
                return database;
            }
            private set { }
        }

        public List<Component> Components
        {
            get
            {
                return components;
            }
            private set { }
        }
    }
}
